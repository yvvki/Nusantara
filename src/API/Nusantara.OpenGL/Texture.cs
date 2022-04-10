// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Diagnostics;

using Silk.NET.OpenGL;

namespace Nusantara.OpenGL;

public class Texture : GLObject
{
	internal Texture(GL gl, uint handle) : base(gl, handle)
	{
		Debug.Assert(gl.IsTexture(handle));
	}
	internal Texture(GL gl, Silk.NET.OpenGL.Texture texture) : this(gl, texture.Handle) { }

	internal Texture(GL gl, GLEnum target) : this(gl, Create(gl, target)) { }
	public Texture(GL gl, TextureTarget target) : this(gl, Create(gl, target)) { }

	#region Wrapper

	private static uint Create(GL gl, GLEnum target)
	{
		lock (gl)
		{
			gl.CreateTextures(target, 1, out uint handle);
			ThrowIfError(gl);
			return handle;
		}
	}
	private static uint Create(GL gl, TextureTarget target)
	{
		lock (gl)
		{
			gl.CreateTextures(target, 1, out uint handle);
			ThrowIfError(gl);
			return handle;
		}
	}

	public void Parameter(TextureParameterName pname, int param)
	{
		lock (GL)
		{
			GL.TextureParameter(Handle, pname, param);
			ThrowIfError();
		}
	}
	public void Parameter(TextureParameterName pname, float param)
	{
		lock (GL)
		{
			GL.TextureParameter(Handle, pname, param);
			ThrowIfError();
		}
	}

	public void GetParameter(GetTextureParameter pname, out int @params)
	{
		lock (GL)
		{
			GL.GetTextureParameter(Handle, pname, out @params);
			ThrowIfError();
		}
	}
	public void GetParameter(GetTextureParameter pname, out float @params)
	{
		lock (GL)
		{
			GL.GetTextureParameter(Handle, pname, out @params);
			ThrowIfError();
		}
	}

	public void Storage2D(
		uint levels,
		SizedInternalFormat format,
		uint width,
		uint height)
	{
		lock (GL)
		{
			GL.TextureStorage2D(
				Handle,
				levels,
				format,
				width,
				height);
			ThrowIfError();
		}

	}

	internal unsafe void SubImage2D(
		int level,
		int xoffset,
		int yoffset,
		uint width,
		uint height,
		GLEnum format,
		GLEnum type,
		void* pixels)
	{
		lock (GL)
		{
			GL.TextureSubImage2D(
				Handle,
				level,
				xoffset,
				yoffset,
				width,
				height,
				format,
				type,
				pixels);
			ThrowIfError();
		}
	}

	public unsafe void SubImage2D(
		int level,
		int xoffset,
		int yoffset,
		uint width,
		uint height,
		PixelFormat format,
		PixelType type,
		void* pixels)
	{
		lock (GL)
		{
			GL.TextureSubImage2D(
				Handle,
				level,
				xoffset,
				yoffset,
				width,
				height,
				format,
				type,
				pixels);
			ThrowIfError();
		}
	}

	public void GenerateMipmap()
	{
		lock (GL)
		{
			GL.GenerateTextureMipmap(Handle);
			ThrowIfError();
		}
	}

	public void Bind(uint unit)
	{
		lock (GL)
		{
			GL.BindTextureUnit(unit, Handle);
			ThrowIfError();
		}
	}

	#endregion

	protected sealed override void Delete()
	{
		lock (GL)
		{
			GL.DeleteTexture(Handle);
			ThrowIfError();
		}
	}

	public static implicit operator Silk.NET.OpenGL.Texture(Texture value)
	{
		return new() { Handle = value.Handle };
	}
}
