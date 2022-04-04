// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

using Silk.NET.OpenGL;

namespace Nusantara.OpenGL;

public class VertexArray : GLObject
{
	internal VertexArray(GL gl, uint handle) : base(gl, handle)
	{
		Debug.Assert(GL.IsVertexArray(Handle));
	}

	public VertexArray(GL gl) : this(gl, Create(gl)) { }

	private static uint Create(GL gl)
	{
		return gl.CreateVertexArray();
	}

	#region Constructors

	// Attribs are not handled.
	public static VertexArray CreateFromBuffers(
		GL gl,
		Buffer? elementBuffer,
		uint bindingindex,
		Buffer? vertexBuffer,
		nint offset = 0,
		uint stride = 0)
	{
		VertexArray vertexArray = new(gl);

		vertexArray.ElementBuffer(elementBuffer);
		vertexArray.VertexBuffer(bindingindex, vertexBuffer, offset, stride);

		return vertexArray;
	}

	#endregion

	#region Wrapper

	public void Get(VertexArrayPName pname, out int param)
	{
		ThrowIfDisposed();
		ThrowIfInvalidEnum(pname);

		GL.GetVertexArray(Handle, pname, out param);
	}

	public void VertexBuffer(uint bindingindex, [AllowNull] Buffer? buffer, nint offset = 0, uint stride = 0)
	{
		ThrowIfDisposed();

		uint bufferHandle = default;

		if (buffer is not null)
		{
			// Checks the equality of the GL members.
			ThrowIfArgumentGLObjectNullOrInvalid(buffer, false);
			bufferHandle = buffer.Handle;
		}

		GL.VertexArrayVertexBuffer(Handle, bindingindex, bufferHandle, offset, stride);
	}

	public void ElementBuffer([AllowNull] Buffer? buffer)
	{
		ThrowIfDisposed();

		uint bufferHandle = default;

		if (buffer is not null)
		{
			// Checks the equality of the GL members.
			ThrowIfArgumentGLObjectNullOrInvalid(buffer, false);
			bufferHandle = buffer.Handle;
		}

		GL.VertexArrayElementBuffer(Handle, bufferHandle);
	}

	public void AttribBinding(uint attribindex, uint bindingindex)
	{
		ThrowIfDisposed();

		GL.VertexArrayAttribBinding(Handle, attribindex, bindingindex);
	}

	public void AttribFormat(uint attribindex, int size, VertexAttribType type, bool normalized = false, uint relativeoffset = 0)
	{
		ThrowIfDisposed();

		GL.VertexArrayAttribFormat(Handle, attribindex, size, type, normalized, relativeoffset);
	}

	public void EnableAttrib(uint index)
	{
		ThrowIfDisposed();

		GL.EnableVertexArrayAttrib(Handle, index);
	}

	public void Bind()
	{
		GL.BindVertexArray(Handle);
	}

	#endregion

	protected sealed override void Delete()
	{
		GL.DeleteVertexArray(Handle);
	}
}
