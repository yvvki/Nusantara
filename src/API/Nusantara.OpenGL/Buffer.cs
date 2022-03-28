﻿// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Diagnostics;

using Silk.NET.OpenGL;

namespace Nusantara.OpenGL;

public class Buffer : GLObject
{
	internal Buffer(GL gl, uint handle) : base(gl, handle)
	{
		Debug.Assert(GL.IsBuffer(Handle));
	}

	public Buffer(GL gl) : this(gl, Create(gl)) { }

	private static uint Create(GL gl)
	{
		return gl.CreateBuffer();
	}

	#region Constructors

	public static Buffer CreateStorage<T>(GL gl, ReadOnlySpan<T> data, BufferStorageMask flags = default)
		where T : unmanaged
	{
		Buffer buffer = new(gl);

		buffer.Storage(data, flags);

		return buffer;
	}

	#endregion

	#region Wrapper

	public void GetParameter(BufferPNameARB pname, out int @params)
	{
		ThrowIfDisposed();
		ThrowIfInvalidEnum(pname);

		GL.GetNamedBufferParameter(Handle, pname, out @params);
	}
	public void GetParameter(BufferPNameARB pname, out long @params)
	{
		ThrowIfDisposed();
		ThrowIfInvalidEnum(pname);

		GL.GetNamedBufferParameter(Handle, pname, out @params);
	}

	public void Storage<T>(ReadOnlySpan<T> data, BufferStorageMask flags = default)
		where T : unmanaged
	{
		ThrowIfDisposed();
		//ThrowIfInvalidEnum(flags); // Do not throw, flags.

		GL.NamedBufferStorage(Handle, data, flags);
	}

	#endregion

	protected sealed override void Delete()
	{
		GL.DeleteBuffer(Handle);
	}
}
