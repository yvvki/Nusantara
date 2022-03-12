// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Reflection;
using System.Runtime.InteropServices;

using Nusantara.OpenGL;

using GL = Silk.NET.OpenGL.GL;
using GLBuffer = Nusantara.OpenGL.Buffer;

namespace Nusantara.Engine.OpenGL;

// Class for containing VertexArray of Vertex and the Buffer-s.
public class Mesh : IDisposable
{
	public VertexArray VertexArray { get; }

	public GLBuffer VertexBuffer { get; }
	public GLBuffer ElementBuffer { get; }

	// No need to reference the array, since the data will get copied to the GPU memory.
	public Mesh(GL gl, ReadOnlySpan<Vertex> vertices, ReadOnlySpan<uint> indices)
	{
		VertexBuffer = GLBuffer.FromData(gl, vertices);
		ElementBuffer = GLBuffer.FromData(gl, indices);

		Type vertexType = typeof(Vertex);

		// Binding buffers to VertexArray.
		VertexArray = VertexArray.FromBuffers(
			gl,
			ElementBuffer,
			0,
			VertexBuffer,
			0,
			(uint)Marshal.SizeOf(vertexType));

		// Handling attribs.
		FieldInfo[] vertexFields = vertexType.GetFields();
		for (uint i = 0; i < vertexFields.Length; i++)
		{
			VertexArray.EnableAttribBindingFormat(
				i,
				0,
				vertexFields[i].FieldType,
				false,
				(uint)Marshal.OffsetOf(vertexType, vertexFields[i].Name));
		}
	}

	public void Bind()
	{
		VertexArray.Bind();
	}

	public void Dispose()
	{
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		VertexArray.Dispose();
		VertexBuffer.Dispose();
		ElementBuffer.Dispose();
	}

	public static implicit operator VertexArray(Mesh value)
	{
		return value.VertexArray;
	}
}
