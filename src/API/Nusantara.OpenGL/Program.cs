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
	internal Program(GL gl, Silk.NET.OpenGL.Program program) : this(gl, program.Handle) { }

	public Program(GL gl) : this(gl, Create(gl)) { }

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

		program.LinkAndThrowOnFail();

		foreach (Shader shader in shaders)
		{
			program.Detach(shader);
		}

		return program;
	}

	#endregion

	#region Wrapper

	private static uint Create(GL gl)
	{
		lock (gl)
		{
			uint result = gl.CreateProgram();
			ThrowIfError(gl);
			return result;
		}
	}

	public void Get(ProgramPropertyARB pname, out int @params)
	{
		lock (GL)
		{
			GL.GetProgram(Handle, pname, out @params);
			ThrowIfError();
		}
	}

	public void Attach([NotNull] Shader shader)
	{
		lock (GL)
		{
			GL.AttachShader(Handle, shader.Handle);
			ThrowIfError();
		}
	}

	public void Detach([NotNull] Shader shader)
	{
		lock (GL)
		{
			GL.DetachShader(Handle, shader.Handle);
			ThrowIfError();
		}
	}

	public void Link()
	{
		lock (GL)
		{
			GL.LinkProgram(Handle);
			ThrowIfError();
		}
	}

	public string GetInfoLog()
	{
		lock (GL)
		{
			string result = GL.GetProgramInfoLog(Handle);
			ThrowIfError();
			return result;
		}
	}

	public int GetUniformLocation(string name)
	{
		lock (GL)
		{
			int result = GL.GetUniformLocation(Handle, name);
			ThrowIfError();
			return result;
		}
	}

	public void Use()
	{
		lock (GL)
		{
			GL.UseProgram(Handle);
			ThrowIfError();
		}
	}

	#endregion

	#region Helper

	public bool LinkStatus
	{
		get
		{
			Get(ProgramPropertyARB.LinkStatus, out int linkStatus);
			return linkStatus is not 0;
		}
	}

	public void LinkAndThrowOnFail()
	{
		Link();
		if (LinkStatus is false)
		{
			ThrowFail();
		}

		[DoesNotReturn]
		void ThrowFail()
		{
			throw new InvalidOperationException(GetInfoLog());
		}
	}


	#endregion

	protected sealed override void Delete()
	{
		lock (GL)
		{
			GL.DeleteProgram(Handle);
			ThrowIfError();
		}
	}

	public static implicit operator Silk.NET.OpenGL.Program(Program value)
	{
		return new() { Handle = value.Handle };
	}
}
