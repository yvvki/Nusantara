// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Silk.NET.Maths;

using VertexAttribType = Silk.NET.OpenGL.VertexAttribType;

namespace Nusantara.Engine.OpenGL;

public record Attrib(int Size, VertexAttribType Type)
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static VertexAttribType ParseType([NotNull] Type type!!)
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
