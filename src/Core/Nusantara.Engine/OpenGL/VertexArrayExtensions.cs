// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Diagnostics.CodeAnalysis;

using Nusantara.OpenGL;

using VertexAttribType = Silk.NET.OpenGL.VertexAttribType;

namespace Nusantara.Engine.OpenGL;

public static class VertexArrayExtensions
{
	public static void AttribFormat<T>(
		this VertexArray @this,
		uint attribindex,
		bool normalized = false,
		uint relativeoffset = 0)
	{
		@this.AttribFormat(attribindex, typeof(T), normalized, relativeoffset);
	}

	public static void AttribFormat(
		this VertexArray @this,
		uint attribindex,
		[NotNull] Type type,
		bool normalized = false,
		uint relativeoffset = 0)
	{
		(int size, VertexAttribType @enum) = AttribHelper.GetSizeEnum(type);
		@this.AttribFormat(attribindex, size, @enum, normalized, relativeoffset);
	}

	public static void EnableAttribBindingFormat(
		this VertexArray @this,
		uint attribindex,
		uint bindingindex,
		int size,
		VertexAttribType type,
		bool normalized = false,
		uint relativeoffset = 0)
	{
		@this.AttribBinding(attribindex, bindingindex);
		@this.AttribFormat(attribindex, size, type, normalized, relativeoffset);
		@this.EnableAttrib(attribindex);
	}
}
