// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;
using System.Runtime.InteropServices;

using Nusantara.OpenGL;

using GL = Silk.NET.OpenGL.GL;
using GLBuffer = Nusantara.OpenGL.Buffer;

namespace Nusantara.Engine.OpenGL;

public class Mesh
{
	public VertexArray VertexArray { get; }

	public GLBuffer VertexBuffer { get; }
	public GLBuffer ElementBuffer { get; }

	public Texture[] Textures { get; init; }

	public Mesh(GL gl, ReadOnlySpan<Vertex> vertices, ReadOnlySpan<uint> indices, Texture[] textures)
	{
		VertexBuffer = GLBuffer.FromData(gl, vertices);
		ElementBuffer = GLBuffer.FromData(gl, indices);

		Textures = textures;

		// Binding buffers to VertexArray.
		VertexArray = VertexArray.FromBuffers(
			gl,
			ElementBuffer,
			0,
			VertexBuffer,
			0,
			(uint)Marshal.SizeOf<Vertex>());

		// Positions.
		VertexArray.EnableAttribBindingFormat(
			0,
			0,
			// Vector4
			4,
			Silk.NET.OpenGL.VertexAttribType.Float,
			false,
			(uint)Marshal.OffsetOf<Vertex>("Position"));

		// Normals.
		VertexArray.EnableAttribBindingFormat(
			0,
			0,
			// Vector4
			4,
			Silk.NET.OpenGL.VertexAttribType.Float,
			false,
			(uint)Marshal.OffsetOf<Vertex>("Normal"));

		// UVs.
		VertexArray.EnableAttribBindingFormat(
			0,
			0,
			// Vector2
			2,
			Silk.NET.OpenGL.VertexAttribType.Float,
			false,
			(uint)Marshal.OffsetOf<Vertex>("UV"));
	}
}
