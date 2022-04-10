// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

using Silk.NET.OpenGL;

namespace Nusantara.OpenGL;


[Serializable]
public class GLException : Exception
{
	public GLException()
		: base()
	{ }
	public GLException(string? message)
		: base(message)
	{ }
	public GLException(string? message, Exception? inner)
		: base(message, inner)
	{ }
	protected GLException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{ }

	[DoesNotReturn]
	internal static void Throw(string? message)
	{
		throw new GLException(message);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ThrowIfError(GL gl)
	{
		static GLEnum[] GetErrors(GL gl)
		{
			List<GLEnum> errors = new();

			while (true)
			{
				GLEnum error = gl.GetError();

				if (error is GLEnum.NoError) break;

				errors.Add(error);
			}

			return errors.ToArray();
		}

		GLEnum[] errors = GetErrors(gl);

		if (errors.Length is 0) return;
		else
		{
			if (errors.Length is 1)
				Throw(GetMessage(errors[0]));
			else
				Throw(string.Join(", ", errors));
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static string? GetMessage(GLEnum errorcode)
	{
		return GetMessage((ErrorCode)errorcode);
	}

	// Messages from https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glGetError.xhtml.
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static string? GetMessage(ErrorCode errorcode)
	{
		return errorcode switch
		{
			ErrorCode.NoError => "No error has been recorded.",
			ErrorCode.InvalidEnum => "An unacceptable value is specified for an enumerated argument.",
			ErrorCode.InvalidValue => "A numeric argument is out of range.",
			ErrorCode.InvalidOperation => "The specified operation is not allowed in the current state.",
			ErrorCode.StackOverflow => "An attempt has been made to perform an operation that would cause an internal stack to overflow.",
			ErrorCode.StackUnderflow => "An attempt has been made to perform an operation that would cause an internal stack to underflow.",
			ErrorCode.OutOfMemory => "There is not enough memory left to execute the command.",
			ErrorCode.InvalidFramebufferOperation => "The framebuffer object is not complete.",
			ErrorCode.TableTooLarge => "The specified table exceeds the implementation's maximum supported table size.",
			ErrorCode.TextureTooLargeExt => "The specified texture exceeds the implementation's maximum supported texture size.",
			_ => throw new ArgumentOutOfRangeException(nameof(errorcode))
		};
	}
}
