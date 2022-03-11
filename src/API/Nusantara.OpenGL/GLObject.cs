// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

using Silk.NET.OpenGL;

namespace Nusantara.OpenGL;

public abstract class GLObject : object, IEquatable<GLObject>, IDisposable
{
	protected GLObject([NotNull] GL gl!!, uint handle)
	{
		Debug.Assert(handle is not default(uint));

		_gl = gl;
		_handle = handle;
	}

	protected internal readonly GL _gl;
	protected internal readonly uint _handle;

	// To be derived for any glGet* methods.
	internal abstract void Get(GLEnum pname, out int @params);

	public GL GL => _gl;
	public uint Handle => _handle;

	public bool Equals([NotNullWhen(true)] GLObject? other)
	{
		return other is not null
			&& _gl.Equals(other._gl)
			&& _handle.Equals(other._handle);
	}
	public override bool Equals([NotNullWhen(true)] object? obj)
	{
		return obj is GLObject other && Equals(other);
	}
	public override int GetHashCode()
	{
		return HashCode.Combine(_gl, _handle);
	}

	public static bool operator ==(GLObject left, GLObject right)
	{
		return left.Equals(right);
	}
	public static bool operator !=(GLObject left, GLObject right)
	{
		return !(left == right);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}
	~GLObject() => Dispose(disposing: false);
	private bool _disposed;
	protected virtual void Dispose(bool disposing)
	{
		if (_disposed) return;

		if (disposing)
		{
			Delete();
		}

		_disposed = true;
	}

	protected abstract void Delete();

	#region Throw Helper

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private protected void ThrowIfDisposed()
	{
		if (_disposed)
		{
			ThrowObjectDisposedException();
		}

		[DoesNotReturn]
		void ThrowObjectDisposedException()
		{
			throw new ObjectDisposedException(GetType().Name);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal void ThrowIfNullOrInvalidGLObject(
		[NotNull] GLObject argument!!,
		bool throwIfDisposed = true,
		[CallerArgumentExpression("argument")] string? paramName = null)
	{
		if (_gl.Equals(argument._gl) is false)
		{
			ThrowArgumentGLMismatchException();
		}

		[DoesNotReturn]
		void ThrowArgumentGLMismatchException()
		{
			throw new ArgumentException("Argument GL object does not match.", paramName);
		}

		if (throwIfDisposed)
		{
			argument.ThrowIfDisposed();
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private protected static void ThrowIfInvalidEnum<T>(
		T argument,
		[CallerArgumentExpression("argument")] string? paramName = null)
		where T : struct, Enum
	{
		if (Enum.IsDefined(argument) is false)
		{
			ThrowInvalidEnumArgumentException();
		}

		[DoesNotReturn]
		void ThrowInvalidEnumArgumentException()
		{
			throw new InvalidEnumArgumentException(
				paramName,
				(int)(object)argument,
				typeof(T));
		}
	}

	#endregion
}
