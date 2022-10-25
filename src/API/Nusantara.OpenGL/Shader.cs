// <https://github.com/yvvki> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

using Silk.NET.OpenGL;

namespace Nusantara.OpenGL;

public class Shader : GLObject
{
	internal Shader(GL gl, uint handle) : base(gl, handle)
	{
		Debug.Assert(GL.IsShader(Handle));
	}
	internal Shader(GL gl, Silk.NET.OpenGL.Shader shader) : this(gl, shader.Handle) { }

	internal Shader(GL gl, GLEnum type) : this(gl, Create(gl, type)) { }
	public Shader(GL gl, ShaderType type) : this(gl, Create(gl, type)) { }

	#region Constructors

	public static Shader CreateFromSource(GL gl, ShaderType type, string @string)
	{
		Shader shader = new(gl, type);

		shader.Source(@string);
		shader.CompileAndThrowOnFail();

		return shader;
	}

	public static Shader CreateFromFile(GL gl, ShaderType type, string path)
	{
		string @string = File.ReadAllText(path);

		return CreateFromSource(gl, type, @string);
	}

	public static Shader CreateFromStream(GL gl, ShaderType type, Stream stream)
	{
		using StreamReader streamReader = new(stream, leaveOpen: true);

		string @string = streamReader.ReadToEnd();

		return CreateFromSource(gl, type, @string);
	}

	#endregion

	#region Wrapper

	private static uint Create(GL gl, GLEnum type)
	{
		lock (gl)
		{
			uint result = gl.CreateShader(type);
			ThrowIfError(gl);
			return result;
		}
	}
	private static uint Create(GL gl, ShaderType type)
	{
		lock (gl)
		{
			uint result = gl.CreateShader(type);
			ThrowIfError(gl);
			return result;
		}
	}

	public void Get(ShaderParameterName pname, out int param)
	{
		lock (GL)
		{
			GL.GetShader(Handle, pname, out param);
			ThrowIfError();
		}
	}

	public void Source(string @string)
	{
		lock (GL)
		{
			GL.ShaderSource(Handle, @string);
			ThrowIfError();
		}
	}

	public void Compile()
	{
		lock (GL)
		{
			GL.CompileShader(Handle);
			ThrowIfError();
		}
	}

	public string GetInfoLog()
	{
		lock (GL)
		{
			string result = GL.GetShaderInfoLog(Handle);
			ThrowIfError();
			return result;
		}
	}

	#endregion

	#region Helper

	public bool CompileStatus
	{
		get
		{
			Get(ShaderParameterName.CompileStatus, out int result);
			return result is not 0;
		}
	}

	public void CompileAndThrowOnFail()
	{
		Compile();

		if (CompileStatus is false)
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
			GL.DeleteShader(Handle);
			ThrowIfError();
		}
	}

	public static implicit operator Silk.NET.OpenGL.Shader(Shader value)
	{
		return new() { Handle = value.Handle };
	}
}
