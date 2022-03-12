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

	internal Texture(GL gl, GLEnum target) : this(gl, Create(gl, target)) { }

	public Texture(GL gl, TextureTarget target) : this(gl, Create(gl, target)) { }

	private static uint Create(GL gl, GLEnum target)
	{
		gl.CreateTextures(target, 1, out uint handle);
		return handle;
	}
	private static uint Create(GL gl, TextureTarget target)
	{
		ThrowIfInvalidEnum(target);

		gl.CreateTextures(target, 1, out uint handle);
		return handle;
	}

	#region Wrapper

	public void Parameter(TextureParameterName pname, int param)
	{
		ThrowIfDisposed();
		ThrowIfInvalidEnum(pname);

		GL.TextureParameter(Handle, pname, param);
	}
	public void Parameter(TextureParameterName pname, float param)
	{
		ThrowIfDisposed();
		ThrowIfInvalidEnum(pname);

		GL.TextureParameter(Handle, pname, param);
	}

	public void GetParameter(GetTextureParameter pname, out int @params)
	{
		ThrowIfDisposed();
		ThrowIfInvalidEnum(pname);

		GL.GetTextureParameter(Handle, pname, out @params);
	}
	public void GetParameter(GetTextureParameter pname, out float @params)
	{
		ThrowIfDisposed();
		ThrowIfInvalidEnum(pname);

		GL.GetTextureParameter(Handle, pname, out @params);
	}

	public void Storage2D(
		uint levels,
		SizedInternalFormat format,
		uint width,
		uint height)
	{
		ThrowIfDisposed();
		ThrowIfInvalidEnum(format);

		GL.TextureStorage2D(
			Handle,
			levels,
			format,
			width,
			height);
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
		ThrowIfDisposed();

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
		ThrowIfDisposed();
		ThrowIfInvalidEnum(format);
		ThrowIfInvalidEnum(type);

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
	}

	public void GenerateMipmap()
	{
		GL.GenerateTextureMipmap(Handle);
	}

	public void Bind(uint unit)
	{
		GL.BindTextureUnit(unit, Handle);
	}

	#endregion

	protected sealed override void Delete()
	{
		GL.DeleteTexture(Handle);
	}
}
