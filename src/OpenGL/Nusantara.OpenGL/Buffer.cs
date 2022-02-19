// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Diagnostics;

using Silk.NET.OpenGL;

namespace Nusantara.OpenGL;

public class Buffer : GLObject
{
	internal Buffer(GL gl, uint handle) : base(gl, handle)
	{
		Debug.Assert(_gl.IsBuffer(_handle));
	}

	public Buffer(GL gl) : this(gl, Create(gl)) { }

	private static uint Create(GL gl)
	{
		return gl.CreateBuffer();
	}

	#region Constructors

	public static Buffer FromData<T>(GL gl, ReadOnlySpan<T> data)
		where T : unmanaged
	{
		Buffer buffer = new(gl);

		buffer.Storage(data);

		return buffer;
	}

	#endregion

	internal override void Get(GLEnum pname, out int @params)
	{
		ThrowIfDisposed();

		_gl.GetNamedBufferParameter(_handle, pname, out @params);
	}
	public void Get(BufferPNameARB pname, out int @params)
	{
		ThrowIfDisposed();
		ThrowIfInvalidEnum(pname);

		_gl.GetNamedBufferParameter(_handle, pname, out @params);
	}

	#region Wrapper

	public void Storage<T>(ReadOnlySpan<T> data, BufferStorageMask flags = default)
		where T : unmanaged
	{
		ThrowIfDisposed();
		//ThrowIfInvalidEnum(flags); // Do not throw, flags.

		_gl.NamedBufferStorage(_handle, data, flags);
	}

	#endregion

	protected override void Delete()
	{
		_gl.DeleteBuffer(_handle);
	}
}
