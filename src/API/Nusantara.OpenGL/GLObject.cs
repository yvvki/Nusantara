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

		GL = gl;
		Handle = handle;
	}

	public GL GL { get; }
	public uint Handle { get; }

	public bool Equals([NotNullWhen(true)] GLObject? other)
	{
		return other is not null
			&& GL.Equals(other.GL)
			&& Handle.Equals(other.Handle);
	}
	public override bool Equals([NotNullWhen(true)] object? obj)
	{
		return obj is GLObject other && Equals(other);
	}
	public override int GetHashCode()
	{
		return HashCode.Combine(GL, Handle);
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
	internal void ThrowIfArgumentGLNullOrMismatch([NotNull] GL argument!!)
	{
		if (GL.Equals(argument) is false)
		{
			ThrowArgumentGLMismatchException();
		}

		[DoesNotReturn]
		static void ThrowArgumentGLMismatchException()
		{
			// Throw InvalidOperationException since we expect both value is true.
			throw new InvalidOperationException();
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal void ThrowIfArgumentGLObjectNullOrInvalid(
		[NotNull] GLObject argument!!,
		bool throwIfDisposed = true)
	{
		ThrowIfArgumentGLNullOrMismatch(argument.GL);

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
