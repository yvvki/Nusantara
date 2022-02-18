// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Diagnostics;

using Silk.NET.OpenGL;

namespace Nusantara.OpenGL;

public class VertexArray : GLObject
{
	internal VertexArray(GL gl, uint handle) : base(gl, handle)
	{
		Debug.Assert(_gl.IsVertexArray(_handle));
	}

	public VertexArray(GL gl) : this(gl, Create(gl)) { }

	private static uint Create(GL gl)
	{
		return gl.CreateVertexArray();
	}

	internal override void Get(GLEnum pname, out int param)
	{
		ThrowIfDisposed();

		_gl.GetVertexArray(_handle, pname, out param);
	}
	public void Get(VertexArrayPName pname, out int param)
	{
		ThrowIfDisposed();
		ThrowIfInvalidEnum(pname);

		_gl.GetVertexArray(_handle, pname, out param);
	}

	protected override void Delete()
	{
		_gl.DeleteVertexArray(_handle);
	}
}
