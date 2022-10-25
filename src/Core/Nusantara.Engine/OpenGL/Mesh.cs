// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Reflection;
using System.Runtime.InteropServices;

using Silk.NET.OpenGL;

namespace Nusantara.OpenGL;

// Class for containing VertexArray of Vertex and the Buffer-s.
public class Mesh : IDisposable
{
	private readonly VertexArray _vao;

	private readonly Buffer? _vbo;
	private readonly Buffer? _ebo;

	// No need to reference the array, since the data will get copied to the GPU memory.
	public Mesh(GL gl, ReadOnlySpan<Vertex> vertices, ReadOnlySpan<uint> indices)
	{
		if (vertices.IsEmpty is false)
		{
			_vbo = Buffer.CreateStorage(gl, vertices);
		}

		if (indices.IsEmpty is false)
		{
			_ebo = Buffer.CreateStorage(gl, indices);
		}

		Type vertexType = typeof(Vertex);

		// Binding buffers to VertexArray.
		_vao = VertexArray.CreateFromBuffers(
			gl,
			_ebo,
			0,
			_vbo,
			0,
			(uint)Marshal.SizeOf(vertexType));

		// Handling attribs.
		FieldInfo[] vertexFields = vertexType.GetFields();
		for (uint i = 0; i < vertexFields.Length; i++)
		{
			_vao.EnableAttribBindingFormat(
				i,
				0,
				vertexFields[i].FieldType,
				false,
				(uint)Marshal.OffsetOf(vertexType, vertexFields[i].Name));
		}
	}

	public void Bind()
	{
		_vao.Bind();
	}

	public void Dispose()
	{
		GC.SuppressFinalize(this);
		Dispose(disposing: true);
	}
	~Mesh() => Dispose(disposing: false);

	protected virtual void Dispose(bool disposing)
	{
		_vao.Dispose();
		_vbo?.Dispose();
		_ebo?.Dispose();
	}
}
