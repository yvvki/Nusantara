using System.Diagnostics;

using Silk.NET.OpenGL;

namespace Nusantara.OpenGL;

public class Shader: GLObject
{
	internal Shader(GL gl, uint handle) : base(gl, handle)
	{
		Debug.Assert(_gl.IsShader(_handle));
	}

	internal Shader(GL gl, GLEnum type) : this(gl, Create(gl, type)) { }

	public Shader(GL gl, ShaderType type) : this(gl, Create(gl, type)) { }

	private static uint Create(GL gl, GLEnum type)
	{
		return gl.CreateShader(type);
	}

	private static uint Create(GL gl, ShaderType type)
	{
		ThrowIfInvalidEnum(type);

		return Create(gl, (GLEnum)type);
	}

	internal override void Get(GLEnum pname, out int param)
	{
		ThrowIfDisposed();

		_gl.GetShader(_handle, pname, out param);
	}
	public void Get(BufferPNameARB pname, out int param)
	{
		ThrowIfInvalidEnum(pname);

		Get((GLEnum)pname, out param);
	}

	protected override void Delete()
	{
		_gl.DeleteShader(_handle);
	}
}
