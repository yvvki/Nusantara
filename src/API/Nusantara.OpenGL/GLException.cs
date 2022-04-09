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
				var error = gl.GetError();
				if (error is GLEnum.NoError)
					break;
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

	// Messages from https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glGetError.xhtml.
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static string? GetMessage(GLEnum errorflag)
	{
		return errorflag switch
		{
			GLEnum.NoError => "No error has been recorded.",
			GLEnum.InvalidEnum => "An unacceptable value is specified for an enumerated argument.",
			GLEnum.InvalidValue => "A numeric argument is out of range.",
			GLEnum.InvalidOperation => "The specified operation is not allowed in the current state.",
			GLEnum.InvalidFramebufferOperation => "The framebuffer object is not complete.",
			GLEnum.OutOfMemory => "There is not enough memory left to execute the command.",
			GLEnum.StackUnderflow => "An attempt has been made to perform an operation that would cause an internal stack to underflow.",
			GLEnum.StackOverflow => "An attempt has been made to perform an operation that would cause an internal stack to overflow.",
			_ => throw new ArgumentOutOfRangeException(nameof(errorflag))
		};
	}
}
