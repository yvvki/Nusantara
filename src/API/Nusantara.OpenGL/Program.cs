// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

using Silk.NET.OpenGL;

namespace Nusantara.OpenGL;

public partial class Program : GLObject
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

	#region Constructors

	public static Program FromShaders(GL gl, params Shader[] shaders)
	{
		return FromShaders(gl, shaders.AsEnumerable());
	}

	public static Program FromShaders(GL gl, IEnumerable<Shader> shaders)
	{
		Program program = new(gl);

		foreach (Shader shader in shaders)
		{
			program.Attach(shader);
		}

		program.Link();

		foreach (Shader shader in shaders)
		{
			program.Detach(shader);
		}

		return program;
	}

	#endregion

	internal sealed override void Get(GLEnum pname, out int @params)
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

	#region Wrapper

	public bool LinkStatus
	{
		get
		{
			Get(ProgramPropertyARB.LinkStatus, out int result);

			return result is not 0;
		}
	}

	public void Attach([NotNull] Shader shader)
	{
		ThrowIfDisposed();
		ThrowIfNullOrInvalidGLObject(shader, false);

		_gl.AttachShader(_handle, shader._handle);
	}

	public void Detach([NotNull] Shader shader)
	{
		ThrowIfDisposed();
		ThrowIfNullOrInvalidGLObject(shader, false);

		_gl.DetachShader(_handle, shader._handle);
	}

	public void Link()
	{
		if (TryLink() is false)
		{
			ThrowFailLink();
		}

		[DoesNotReturn]
		void ThrowFailLink()
		{
			throw new InvalidOperationException(_gl.GetProgramInfoLog(_handle));
		}
	}

	public bool TryLink()
	{
		ThrowIfDisposed();

		_gl.LinkProgram(_handle);

		return LinkStatus;
	}

	public int GetUniformLocation(string name)
	{
		ThrowIfDisposed();

		int location = GetUniformLocationUnsafe(name);

		return location;
	}

	private int GetUniformLocationUnsafe(string name)
	{
		int location = _gl.GetUniformLocation(_handle, name);

		return location;
	}

	#endregion

	protected sealed override void Delete()
	{
		_gl.DeleteProgram(_handle);
	}
}
