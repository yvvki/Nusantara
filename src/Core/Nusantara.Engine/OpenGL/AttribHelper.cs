﻿// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;

using Silk.NET.Maths;
using Silk.NET.OpenGL;

namespace Nusantara.Engine.OpenGL;

// thanks to <https://github.com/Windows10CE> for helping!
public static class AttribHelper
{
	public static (int, VertexAttribType) GetSizeEnum([NotNull] Type type)
	{
		if (type.IsPrimitive)
		{
			return (1, GetEnum(type));
		}

		// Auto checks supported type.
		int size = GetSize(type);
		VertexAttribType @enum;

		if (type.IsGenericType)
		{
			Type genericArgument = type.GetGenericArguments()[0];
			@enum = GetEnum(genericArgument);
		}
		else
		{
			// System.Numerics namespace uses float.
			@enum = VertexAttribType.Float;
		}

		return (size, @enum);
	}

	// Only supports System.Numerics and Silk.NET.Maths namespaces.
	// Subject to change.
	public static int GetSize<T>()
	{
		return GetSize(typeof(T));
	}

	public static int GetSize([NotNull] Type type!!)
	{
		if (type.IsGenericType)
		{
			type = type.GetGenericTypeDefinition();
		}

		return
			  type == typeof(Vector2) || type == typeof(Vector2D<>)
			? 2
			: type == typeof(Vector3) || type == typeof(Vector3D<>)
			? 3
			: type == typeof(Vector4) || type == typeof(Vector4D<>)
			? 4
			: type == typeof(Matrix2X2<>)
			? 2 * 2
			: type == typeof(Matrix2X3<>) || type == typeof(Matrix3X2<>) || type == typeof(Matrix3x2)
			? 2 * 3
			: type == typeof(Matrix2X4<>) || type == typeof(Matrix4X2<>)
			? 2 * 4
			: type == typeof(Matrix3X3<>)
			? 3 * 3
			: type == typeof(Matrix3X4<>)
			? 3 * 4
			: type == typeof(Matrix4X4<>) || type == typeof(Matrix4x4)
			? 4 * 4
			: throw new NotSupportedException();
	}

	// Only accept primitive types.
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static VertexAttribType GetEnum<T>()
		where T : struct
	{
		return GetEnum(typeof(T));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static VertexAttribType GetEnum([NotNull] Type type!!)
	{
		return
			  type == typeof(sbyte)
			? VertexAttribType.Byte
			: type == typeof(short)
			? VertexAttribType.Short
			: type == typeof(int) || type == typeof(long) || type == typeof(nint)
			? VertexAttribType.Int
			: type == typeof(byte)
			? VertexAttribType.UnsignedByte
			: type == typeof(ushort)
			? VertexAttribType.UnsignedShort
			: type == typeof(uint) || type == typeof(ulong) || type == typeof(nuint)
			? VertexAttribType.UnsignedInt
			: type == typeof(Half)
			? VertexAttribType.HalfFloat
			: type == typeof(float)
			? VertexAttribType.Float
			: type == typeof(double)
			? VertexAttribType.Double
			: throw new NotSupportedException();
	}
};
