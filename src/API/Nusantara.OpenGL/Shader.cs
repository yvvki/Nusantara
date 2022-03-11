// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

using Silk.NET.OpenGL;

namespace Nusantara.OpenGL;

public class Shader : GLObject
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

		return gl.CreateShader(type);
	}

	#region Constructors

	public static Shader FromSource(GL gl, ShaderType type, string @string)
	{
		Shader shader = new(gl, type);

		shader.Source(@string);
		shader.Compile();

		return shader;
	}

	public static Shader FromFile(GL gl, ShaderType type, string path)
	{
		string @string = File.ReadAllText(path);

		return FromSource(gl, type, @string);
	}

	public static Shader FromStream(GL gl, ShaderType type, Stream stream)
	{
		using StreamReader streamReader = new(stream, leaveOpen: true);

		string @string = streamReader.ReadToEnd();

		return FromSource(gl, type, @string);
	}

	#endregion

	internal sealed override void Get(GLEnum pname, out int param)
	{
		ThrowIfDisposed();

		_gl.GetShader(_handle, pname, out param);
	}
	public void Get(ShaderParameterName pname, out int param)
	{
		ThrowIfDisposed();
		ThrowIfInvalidEnum(pname);

		_gl.GetShader(_handle, pname, out param);
	}

	#region Wrapper

	public bool CompileStatus
	{
		get
		{
			Get(ShaderParameterName.CompileStatus, out int result);
			return result is not 0;
		}
	}

	public void Source(string @string)
	{
		ThrowIfDisposed();

		_gl.ShaderSource(_handle, @string);
	}

	public void Compile()
	{
		if (TryCompile() is false)
		{
			ThrowFailCompile();
		}

		[DoesNotReturn]
		void ThrowFailCompile()
		{
			throw new InvalidOperationException(_gl.GetShaderInfoLog(_handle));
		}
	}

	public bool TryCompile()
	{
		ThrowIfDisposed();

		_gl.CompileShader(_handle);

		return CompileStatus;
	}

	#endregion

	protected sealed override void Delete()
	{
		_gl.DeleteShader(_handle);
	}
}
