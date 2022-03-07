// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using Nusantara.OpenGL;

using VertexAttribType = Silk.NET.OpenGL.VertexAttribType;

namespace Nusantara.Engine.OpenGL;

public static class VertexArrayExtensions
{
	public static void EnableAttribBindingFormat(
		this VertexArray @this,
		uint attribindex,
		uint bindingindex,
		int size,
		VertexAttribType type,
		bool normalized,
		uint relativeoffset)
	{
		@this.AttribBinding(attribindex, bindingindex);
		@this.AttribFormat(attribindex, size, type, normalized, relativeoffset);
		@this.EnableAttrib(attribindex);
	}
}
