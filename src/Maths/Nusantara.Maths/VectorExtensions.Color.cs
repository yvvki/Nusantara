using System.Drawing;
using System.Runtime.CompilerServices;

using Silk.NET.Maths;

namespace Nusantara.Maths;

public static partial class VectorExtensions
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static Vector4D<byte> AsVector(this Color @this)
	{
		int argb = @this.ToArgb();

		return Unsafe.As<int, Vector4D<byte>>(ref argb);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<byte> ARGB(this Color @this)
	{
		return @this.AsVector();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<byte> RGBA(this Color @this)
	{
		return @this.AsVector().YZWX(); // amazing, an actual use, wow
	}
}
