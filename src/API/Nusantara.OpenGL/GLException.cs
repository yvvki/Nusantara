// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

using Silk.NET.Core.Native;
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
		ErrorCode firstError = (ErrorCode)gl.GetError();
		if (firstError is ErrorCode.NoError) return;

		IEnumerable<ErrorCode> GetErrors()
		{
			yield return firstError;

			while (true)
			{
				ErrorCode error = (ErrorCode)gl.GetError();
				if (error is ErrorCode.NoError) break;

				yield return error;
			}
		}

		ErrorCode[] errors = GetErrors().ToArray();

		if (errors.Length is 1)
			Throw(GetMessage(firstError));
		else
			Throw(string.Join(", ", errors));
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

	// You still need to use debug flags and enable debug output.
	public static unsafe void HandleDebugMessageCallback(GL gl)
	{
		gl.DebugMessageCallback(DebugProc, null);
	}

	private static unsafe void DebugProc(GLEnum source, GLEnum type, int id, GLEnum severity, int length, nint message, nint userParam)
	{
		DebugSource _source = (DebugSource)source;
		DebugType _type = (DebugType)type;
		DebugSeverity _severity = (DebugSeverity)severity;
		string? _message = SilkMarshal.PtrToString(message);

		if (_severity is DebugSeverity.DebugSeverityHigh)
		{
			Throw(_message);
		}
		else
		{
			Console.WriteLine(_message);
		}
	}
}
