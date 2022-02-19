// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Diagnostics;

using Silk.NET.OpenGL;

namespace Nusantara.OpenGL;

public class VertexArray : GLObject
{
	internal VertexArray(GL gl, uint handle) : base(gl, handle)
	{
		Debug.Assert(_gl.IsVertexArray(_handle));
	}

	public VertexArray(GL gl) : this(gl, Create(gl)) { }

	private static uint Create(GL gl)
	{
		return gl.CreateVertexArray();
	}

	#region Constructors

	// Attribs are not handled. 
	public static VertexArray FromBuffers(GL gl, Buffer? elementBuffer, uint bindingindex, Buffer? vertexBuffer, nint offset = 0, uint stride = 0)
	{
		VertexArray vertexArray = new(gl);

		vertexArray.ElementBuffer(elementBuffer);
		vertexArray.VertexBuffer(bindingindex, vertexBuffer, offset, stride);

		return vertexArray;
	}

	#endregion

	internal sealed override void Get(GLEnum pname, out int param)
	{
		ThrowIfDisposed();

		_gl.GetVertexArray(_handle, pname, out param);
	}
	public void Get(VertexArrayPName pname, out int param)
	{
		ThrowIfDisposed();
		ThrowIfInvalidEnum(pname);

		_gl.GetVertexArray(_handle, pname, out param);
	}

	#region Wrapper

	public void VertexBuffer(uint bindingindex, Buffer? buffer, nint offset = 0, uint stride = 0)
	{
		ThrowIfDisposed();

		uint buffer_handle = default;

		if (buffer is not null)
		{
			ThrowIfNullOrInvalidGLObject(buffer, false);
			buffer_handle = buffer._handle;
		}

		_gl.VertexArrayVertexBuffer(_handle, bindingindex, buffer_handle, offset, stride);
	}

	public void ElementBuffer(Buffer? buffer)
	{
		ThrowIfDisposed();

		uint buffer_handle = default;

		if (buffer is not null)
		{
			ThrowIfNullOrInvalidGLObject(buffer, false);
			buffer_handle = buffer._handle;
		}

		_gl.VertexArrayElementBuffer(_handle, buffer_handle);
	}

	public void AttribBinding(uint attribindex, uint bindingindex)
	{
		ThrowIfDisposed();

		_gl.VertexArrayAttribBinding(_handle, attribindex, bindingindex);
	}

	public void AttribFormat(uint attribindex, int size, VertexAttribType type, bool normalized = false, uint relativeoffset = 0)
	{
		ThrowIfDisposed();

		_gl.VertexArrayAttribFormat(_handle, attribindex, size, type, normalized, relativeoffset);
	}

	public void EnableAttrib(uint index)
	{
		ThrowIfDisposed();

		_gl.EnableVertexArrayAttrib(_handle, index);
	}

	#endregion

	protected sealed override void Delete()
	{
		_gl.DeleteVertexArray(_handle);
	}
}
