// <https://github.com/yvvki> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

using Silk.NET.OpenGL;

namespace Nusantara.OpenGL;

public abstract class GLObject : object, IEquatable<GLObject>, IDisposable
{
	protected GLObject(GL gl, uint handle)
	{
		ArgumentNullException.ThrowIfNull(gl);
		
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

	public static bool ThrowOnError { get; set; } = true;
	internal static void ThrowIfError(GL gl)
	{
		if (ThrowOnError is false) return;
		GLException.ThrowIfError(gl);
	}
	protected void ThrowIfError()
	{
		ThrowIfError(GL);
	}
}
