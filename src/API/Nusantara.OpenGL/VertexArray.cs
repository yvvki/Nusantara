// <https://github.com/yvvki> wrote this file.
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
	internal VertexArray(GL gl, Silk.NET.OpenGL.VertexArray vertexArray) : this(gl, vertexArray.Handle) { }

	public VertexArray(GL gl) : this(gl, Create(gl)) { }

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

	private static uint Create(GL gl)
	{
		lock (gl)
		{
			uint result = gl.CreateVertexArray();
			ThrowIfError(gl);
			return result;
		}
	}

	public void Get(VertexArrayPName pname, out int param)
	{
		lock (GL)
		{
			GL.GetVertexArray(Handle, pname, out param);
			ThrowIfError();
		}
	}

	public void VertexBuffer(uint bindingindex, Buffer? buffer, nint offset = 0, uint stride = 0)
	{
		lock (GL)
		{
			GL.VertexArrayVertexBuffer(Handle, bindingindex, buffer?.Handle ?? default, offset, stride);
			ThrowIfError();
		}
	}

	public void ElementBuffer([AllowNull] Buffer? buffer)
	{
		lock (GL)
		{
			GL.VertexArrayElementBuffer(Handle, buffer?.Handle ?? default);
			ThrowIfError();
		}
	}

	public void AttribBinding(uint attribindex, uint bindingindex)
	{
		lock (GL)
		{
			GL.VertexArrayAttribBinding(Handle, attribindex, bindingindex);
			ThrowIfError();
		}
	}

	public void AttribFormat(uint attribindex, int size, VertexAttribType type, bool normalized = false, uint relativeoffset = 0)
	{
		lock (GL)
		{
			GL.VertexArrayAttribFormat(Handle, attribindex, size, type, normalized, relativeoffset);
			ThrowIfError();
		}
	}

	public void EnableAttrib(uint index)
	{
		lock (GL)
		{
			GL.EnableVertexArrayAttrib(Handle, index);
			ThrowIfError();
		}
	}

	public void Bind()
	{
		lock (GL)
		{
			GL.BindVertexArray(Handle);
			ThrowIfError();
		}
	}

	#endregion

	protected sealed override void Delete()
	{
		lock (GL)
		{
			GL.DeleteVertexArray(Handle);
			ThrowIfError();
		}
	}

	public static implicit operator Silk.NET.OpenGL.VertexArray(VertexArray value)
	{
		return new() { Handle = value.Handle };
	}
}
