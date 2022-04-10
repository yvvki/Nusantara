// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Drawing;
using System.Runtime.CompilerServices;

using Silk.NET.Maths;

namespace Nusantara.Maths;

public static partial class VectorExtensions
{
	#region Color

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<byte> ARGB(this Color @this)
	{
		int argb = @this.ToArgb();

		// int as Vector4D<byte>.
		return Unsafe.As<int, Vector4D<byte>>(ref argb);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<byte> RGB(this Color @this)
	{
		// ARGB (XYZW) as RGB (YZW).
		return @this.ARGB().YZW();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<byte> RGBA(this Color @this)
	{
		// ARGB (XYZW) as RGBA (YZWX).
		return @this.ARGB().YZWX();
	}

	#endregion
}
