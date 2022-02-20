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

	internal sealed override void Get(GLEnum pname, out int @params)
	{
		ThrowIfDisposed();

		_gl.GetTextureParameter(_handle, pname, out @params);
	}

	#region Wrapper

	public void Parameter(TextureParameterName pname, int param)
	{
		ThrowIfDisposed();
		ThrowIfInvalidEnum(pname);

		_gl.TextureParameter(_handle, pname, param);
	}
	public void Parameter(TextureParameterName pname, float param)
	{
		ThrowIfDisposed();
		ThrowIfInvalidEnum(pname);

		_gl.TextureParameter(_handle, pname, param);
	}

	public void GetParameter(GetTextureParameter pname, out int @params)
	{
		ThrowIfDisposed();
		ThrowIfInvalidEnum(pname);

		_gl.GetTextureParameter(_handle, pname, out @params);
	}
	public void GetParameter(GetTextureParameter pname, out float @params)
	{
		ThrowIfDisposed();
		ThrowIfInvalidEnum(pname);

		_gl.GetTextureParameter(_handle, pname, out @params);
	}

	public void Storage2D(
		uint levels,
		SizedInternalFormat format,
		uint width,
		uint height)
	{
		ThrowIfDisposed();
		ThrowIfInvalidEnum(format);

		_gl.TextureStorage2D(
			_handle,
			levels,
			format,
			width,
			height);
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

		_gl.TextureSubImage2D(
			_handle,
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
		_gl.GenerateTextureMipmap(_handle);
	}

	#endregion

	protected sealed override void Delete()
	{
		_gl.DeleteTexture(_handle);
	}
}
