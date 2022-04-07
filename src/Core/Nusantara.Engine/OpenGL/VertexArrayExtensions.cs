// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.InteropServices;

using Silk.NET.OpenGL;

namespace Nusantara.OpenGL;

public static class VertexArrayExtensions
{
	public static void AttribFormat<T>(
		this VertexArray @this,
		uint attribindex,
		bool normalized = false,
		uint relativeoffset = 0)
		where T : struct
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
		(int size, VertexAttribType attribType) = AttribHelper.GetSizeType(type);
		@this.AttribFormat(attribindex, size, attribType, normalized, relativeoffset);
	}

	public static void EnableAttribBindingFormat<T>(
		this VertexArray @this,
		uint attribindex,
		uint bindingindex,
		bool normalized = false,
		uint relativeoffset = 0)
		where T : struct
	{
		@this.EnableAttribBindingFormat(attribindex, bindingindex, typeof(T), normalized, relativeoffset);
	}

	public static void EnableAttribBindingFormat(
		this VertexArray @this,
		uint attribindex,
		uint bindingindex,
		[NotNull] Type type,
		bool normalized = false,
		uint relativeoffset = 0)
	{
		@this.AttribBinding(attribindex, bindingindex);
		@this.AttribFormat(attribindex, type, normalized, relativeoffset);
		@this.EnableAttrib(attribindex);
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

	// Experimental methods
	// Handle attrib from user struct types.
	public static void AttribFormatStruct<T>(
		this VertexArray @this,
		uint attribindexoffset,
		bool normalized = false,
		uint relativeoffset = 0)
		where T : struct
	{
		@this.AttribFormatStruct(attribindexoffset, typeof(T), normalized, relativeoffset);
	}

	public static void AttribFormatStruct(
		this VertexArray @this,
		uint attribindexoffset,
		[NotNull] Type type,
		bool normalized = false,
		uint relativeoffset = 0)
	{
		FieldInfo[] typeFields = type.GetFields();

		for (uint i = 0; i < typeFields.Length; i++)
		{
			@this.AttribFormat(
				attribindexoffset + i,
				typeFields[i].FieldType,
				false,
				(uint)Marshal.OffsetOf(type, typeFields[i].Name));
		}
	}

	public static void EnableAttribBindingFormatStruct<T>(
		this VertexArray @this,
		uint attribindexoffset,
		uint bindingindex,
		bool normalized = false,
		uint relativeoffset = 0)
		where T : struct
	{
		@this.EnableAttribBindingFormatStruct(attribindexoffset, bindingindex, typeof(T), normalized, relativeoffset);
	}

	public static void EnableAttribBindingFormatStruct(
		this VertexArray @this,
		uint attribindexoffset,
		uint bindingindex,
		[NotNull] Type type,
		bool normalized = false,
		uint relativeoffset = 0)
	{
		@this.AttribBinding(attribindexoffset, bindingindex);
		@this.AttribFormatStruct(attribindexoffset, type, normalized, relativeoffset);
		@this.EnableAttrib(attribindexoffset);
	}
}
