// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Diagnostics;

using Silk.NET.OpenGL;

namespace Nusantara.OpenGL;

public class Program : GLObject
{
	internal Program(GL gl, uint handle) : base(gl, handle)
	{
		Debug.Assert(_gl.IsProgram(_handle));
	}

	public Program(GL gl) : this(gl, Create(gl)) { }

	private static uint Create(GL gl)
	{
		return gl.CreateProgram();
	}

	internal override void Get(GLEnum pname, out int @params)
	{
		ThrowIfDisposed();

		_gl.GetProgram(_handle, pname, out @params);
	}
	public void Get(ProgramPropertyARB pname, out int @params)
	{
		ThrowIfDisposed();
		ThrowIfInvalidEnum(pname);

		_gl.GetProgram(_handle, pname, out @params);
	}

	protected override void Delete()
	{
		_gl.DeleteProgram(_handle);
	}
}
