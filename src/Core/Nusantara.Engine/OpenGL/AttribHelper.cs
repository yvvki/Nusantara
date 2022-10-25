// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;

using Silk.NET.Maths;
using Silk.NET.OpenGL;

namespace Nusantara.OpenGL;

// thanks to <https://github.com/Windows10CE> for helping!
internal static class AttribHelper
{
	public static bool IsSupported<T>()
		where T : struct
	{
		return IsSupported(typeof(T));
	}

	// Only supports primitive, System.Numerics, and Silk.NET.Maths namespaces types.
	// Subject to change.	
	public static bool IsSupported(Type? type)
	{
		if (type is null)
		{
			return false;
		}

		if (type.IsPrimitive)
		{
			return true;
		}
		else if (type.IsGenericType)
		{
			type = type.GetGenericTypeDefinition();
		}

		return
			type == typeof(Vector2) || type == typeof(Vector2D<>) ||
			type == typeof(Vector3) || type == typeof(Vector3D<>) ||
			type == typeof(Vector4) || type == typeof(Vector4D<>) ||
			type == typeof(Matrix2X2<>) ||
			type == typeof(Matrix2X3<>) || type == typeof(Matrix3X2<>) || type == typeof(Matrix3x2) ||
			type == typeof(Matrix2X4<>) || type == typeof(Matrix4X2<>) ||
			type == typeof(Matrix3X3<>) ||
			type == typeof(Matrix3X4<>) ||
			type == typeof(Matrix4X4<>) || type == typeof(Matrix4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static (int size, VertexAttribType type) GetSizeType<T>()
		where T : struct
	{
		return GetSizeType(typeof(T));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static (int size, VertexAttribType type) GetSizeType([NotNull] Type type)
	{
		// Auto checks supported type.
		int size = GetSize(type);
		VertexAttribType @enum;

		if (type.IsPrimitive)
		{
			@enum = GetType(type);
		}
		else if (type.IsGenericType)
		{
			Type genericArgument = type.GetGenericArguments()[0];
			@enum = GetType(genericArgument);
		}
		else
		{
			// System.Numerics namespace uses single float.
			@enum = VertexAttribType.Float;
		}

		return (size, @enum);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int GetSize<T>()
		where T : struct
	{
		return GetSize(typeof(T));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int GetSize(Type type)
	{
		ArgumentNullException.ThrowIfNull(type);
		
		if (type.IsPrimitive)
		{
			return 1;
		}
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

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static VertexAttribType GetType<T>()
		where T : unmanaged
	{
		return GetType(typeof(T));
	}

	// Only accept primitive and enum type.
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static VertexAttribType GetType(Type type)
	{
		ArgumentNullException.ThrowIfNull(type);
		
		if (type.IsEnum)
		{
			type = Enum.GetUnderlyingType(type);
		}

		return
			  type == typeof(sbyte)
			? VertexAttribType.Byte
			: type == typeof(byte)
			? VertexAttribType.UnsignedByte
			: type == typeof(short)
			? VertexAttribType.Short
			: type == typeof(ushort) || type == typeof(char) // sizeof char is 16 bit and will be marshaled to ushort.
			? VertexAttribType.UnsignedShort
			: type == typeof(int) || type == typeof(long) || type == typeof(nint)
			? VertexAttribType.Int
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
