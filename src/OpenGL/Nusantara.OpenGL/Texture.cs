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

	internal override void Get(GLEnum pname, out int @params)
	{
		ThrowIfDisposed();

		_gl.GetTextureParameter(_handle, pname, out @params);
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
	public void GetParameterI(GetTextureParameter pname, out int @params)
	{
		ThrowIfDisposed();
		ThrowIfInvalidEnum(pname);

		_gl.GetTextureParameterI(_handle, pname, out @params);
	}
	public void GetParameterI(GetTextureParameter pname, out uint @params)
	{
		ThrowIfDisposed();
		ThrowIfInvalidEnum(pname);

		_gl.GetTextureParameterI(_handle, pname, out @params);
	}

	protected override void Delete()
	{
		_gl.DeleteTexture(_handle);
	}
}
