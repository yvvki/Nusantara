// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Diagnostics;
using System.Runtime.CompilerServices;

using Silk.NET.OpenGL;

namespace Nusantara.OpenGL;

public class Buffer : GLObject
{
	internal Buffer(GL gl, uint handle) : base(gl, handle)
	{
		Debug.Assert(GL.IsBuffer(Handle));
	}
	internal Buffer(GL gl, Silk.NET.OpenGL.Buffer buffer) : this(gl, buffer.Handle) { }

	public Buffer(GL gl) : this(gl, Create(gl)) { }

	#region Constructors

	public static Buffer CreateData<T>(GL gl, ReadOnlySpan<T> data, VertexBufferObjectUsage usage)
		where T : unmanaged
	{
		Buffer buffer = new(gl);

		buffer.Data(data, usage);

		return buffer;
	}

	public static Buffer CreateStorage<T>(GL gl, ReadOnlySpan<T> data, BufferStorageMask flags = default)
		where T : unmanaged
	{
		Buffer buffer = new(gl);

		buffer.Storage(data, flags);

		return buffer;
	}

	#endregion

	#region Wrapper

	private static uint Create(GL gl)
	{
		lock (gl)
		{
			uint result = gl.CreateBuffer();
			ThrowIfError(gl);
			return result;
		}
	}

	public void GetParameter(BufferPNameARB pname, out int @params)
	{
		lock (GL)
		{
			GL.GetNamedBufferParameter(Handle, pname, out @params);
			ThrowIfError();
		}
	}
	public void GetParameter(BufferPNameARB pname, out long @params)
	{
		lock (GL)
		{
			GL.GetNamedBufferParameter(Handle, pname, out @params);
			ThrowIfError();
		}
	}

	public void Data<T>(ReadOnlySpan<T> data, VertexBufferObjectUsage usage)
		where T : unmanaged
	{
		lock (GL)
		{
			GL.NamedBufferData(Handle, (nuint)data.Length * (nuint)Unsafe.SizeOf<T>(), data, usage);
			ThrowIfError();
		}
	}

	public void SubData<T>(nint offset, ReadOnlySpan<T> data)
		where T : unmanaged
	{
		lock (GL)
		{
			GL.NamedBufferSubData(Handle, offset, (nuint)data.Length * (nuint)Unsafe.SizeOf<T>(), data);
			ThrowIfError();
		}
	}

	public void InvalidateData<T>()
		where T : unmanaged
	{
		lock (GL)
		{
			GL.InvalidateBufferData(Handle);
			ThrowIfError();
		}
	}

	public void InvalidateSubData<T>(nint offset, nuint length)
		where T : unmanaged
	{
		lock (GL)
		{
			GL.InvalidateBufferSubData(Handle, offset, length);
			ThrowIfError();
		}
	}

	public void Storage<T>(ReadOnlySpan<T> data, BufferStorageMask flags = default)
		where T : unmanaged
	{
		lock (GL)
		{
			GL.NamedBufferStorage(Handle, data, flags);
			ThrowIfError();
		}
	}

	#endregion

	protected sealed override void Delete()
	{
		lock (GL)
		{
			GL.DeleteBuffer(Handle);
			ThrowIfError();
		}
	}

	public static implicit operator Silk.NET.OpenGL.Buffer(Buffer value)
	{
		return new() { Handle = value.Handle };
	}
}
