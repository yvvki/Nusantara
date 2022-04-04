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
		Debug.Assert(GL.IsProgram(Handle));
	}

	public Program(GL gl) : this(gl, Create(gl)) { }

	private static uint Create(GL gl)
	{
		return gl.CreateProgram();
	}

	#region Constructors

	public static Program CreateFromShaders(GL gl, params Shader[] shaders)
	{
		return CreateFromShaders(gl, shaders.AsEnumerable());
	}

	public static Program CreateFromShaders(GL gl, IEnumerable<Shader> shaders)
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

	#region Wrapper

	public void Get(ProgramPropertyARB pname, out int @params)
	{
		ThrowIfDisposed();
		ThrowIfInvalidEnum(pname);

		GL.GetProgram(Handle, pname, out @params);
	}

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
		ThrowIfArgumentGLObjectNullOrInvalid(shader, false);

		GL.AttachShader(Handle, shader.Handle);
	}

	public void Detach([NotNull] Shader shader)
	{
		ThrowIfDisposed();
		ThrowIfArgumentGLObjectNullOrInvalid(shader, false);

		GL.DetachShader(Handle, shader.Handle);
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
			throw new InvalidOperationException(GL.GetProgramInfoLog(Handle));
		}
	}

	public bool TryLink()
	{
		ThrowIfDisposed();

		GL.LinkProgram(Handle);

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
		int location = GL.GetUniformLocation(Handle, name);

		return location;
	}

	public void Use()
	{
		GL.UseProgram(Handle);
	}

	#endregion

	protected sealed override void Delete()
	{
		GL.DeleteProgram(Handle);
	}
}
