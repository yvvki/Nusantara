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

	protected override void Delete()
	{
		_gl.DeleteBuffer(_handle);
	}
}
