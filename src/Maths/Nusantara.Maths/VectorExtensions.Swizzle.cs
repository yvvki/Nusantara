// <https://github.com/yvvki> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;
using System.Runtime.CompilerServices;

using Silk.NET.Maths;

namespace Nusantara.Maths;

public static partial class VectorExtensions
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 XX(this Vector2 @this)
	{
		return new(
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> XX<T>(this Vector2D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 XY(this Vector2 @this)
	{
		return new(
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> XY<T>(this Vector2D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 YX(this Vector2 @this)
	{
		return new(
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> YX<T>(this Vector2D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 YY(this Vector2 @this)
	{
		return new(
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> YY<T>(this Vector2D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void XY(this ref Vector2 @this, Vector2 value)
	{
		@this = @this with
		{
			X = value.X,
			Y = value.Y
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void XY<T>(this ref Vector2D<T> @this, Vector2D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			X = value.X,
			Y = value.Y
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YX(this ref Vector2 @this, Vector2 value)
	{
		@this = @this with
		{
			Y = value.X,
			X = value.Y
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YX<T>(this ref Vector2D<T> @this, Vector2D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Y = value.X,
			X = value.Y
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XXX(this Vector2 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XXX<T>(this Vector2D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XXY(this Vector2 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XXY<T>(this Vector2D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XYX(this Vector2 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XYX<T>(this Vector2D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XYY(this Vector2 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XYY<T>(this Vector2D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YXX(this Vector2 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YXX<T>(this Vector2D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YXY(this Vector2 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YXY<T>(this Vector2D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YYX(this Vector2 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YYX<T>(this Vector2D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YYY(this Vector2 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YYY<T>(this Vector2D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXXX(this Vector2 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXXX<T>(this Vector2D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXXY(this Vector2 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXXY<T>(this Vector2D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXYX(this Vector2 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXYX<T>(this Vector2D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXYY(this Vector2 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXYY<T>(this Vector2D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYXX(this Vector2 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYXX<T>(this Vector2D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYXY(this Vector2 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYXY<T>(this Vector2D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYYX(this Vector2 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYYX<T>(this Vector2D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYYY(this Vector2 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYYY<T>(this Vector2D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXXX(this Vector2 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXXX<T>(this Vector2D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXXY(this Vector2 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXXY<T>(this Vector2D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXYX(this Vector2 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXYX<T>(this Vector2D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXYY(this Vector2 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXYY<T>(this Vector2D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYXX(this Vector2 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYXX<T>(this Vector2D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYXY(this Vector2 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYXY<T>(this Vector2D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYYX(this Vector2 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYYX<T>(this Vector2D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYYY(this Vector2 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYYY<T>(this Vector2D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 XX(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> XX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 XY(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> XY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 XZ(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> XZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 YX(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> YX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 YY(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> YY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 YZ(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> YZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 ZX(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> ZX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 ZY(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> ZY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 ZZ(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> ZZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void XY(this ref Vector3 @this, Vector2 value)
	{
		@this = @this with
		{
			X = value.X,
			Y = value.Y
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void XY<T>(this ref Vector3D<T> @this, Vector2D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			X = value.X,
			Y = value.Y
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YX(this ref Vector3 @this, Vector2 value)
	{
		@this = @this with
		{
			Y = value.X,
			X = value.Y
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YX<T>(this ref Vector3D<T> @this, Vector2D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Y = value.X,
			X = value.Y
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YZ(this ref Vector3 @this, Vector2 value)
	{
		@this = @this with
		{
			Y = value.X,
			Z = value.Y
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YZ<T>(this ref Vector3D<T> @this, Vector2D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Y = value.X,
			Z = value.Y
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZY(this ref Vector3 @this, Vector2 value)
	{
		@this = @this with
		{
			Z = value.X,
			Y = value.Y
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZY<T>(this ref Vector3D<T> @this, Vector2D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Z = value.X,
			Y = value.Y
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XXX(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XXX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XXY(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XXY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XXZ(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XXZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XYX(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XYX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XYY(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XYY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XYZ(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XYZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XZX(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XZX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XZY(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XZY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XZZ(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XZZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YXX(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YXX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YXY(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YXY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YXZ(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YXZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YYX(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YYX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YYY(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YYY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YYZ(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YYZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YZX(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YZX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YZY(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YZY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YZZ(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YZZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ZXX(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> ZXX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ZXY(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> ZXY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ZXZ(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> ZXZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ZYX(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> ZYX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ZYY(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> ZYY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ZYZ(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> ZYZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ZZX(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> ZZX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ZZY(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> ZZY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ZZZ(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> ZZZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void XYZ(this ref Vector3 @this, Vector3 value)
	{
		@this = @this with
		{
			X = value.X,
			Y = value.Y,
			Z = value.Z
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void XYZ<T>(this ref Vector3D<T> @this, Vector3D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			X = value.X,
			Y = value.Y,
			Z = value.Z
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void XZY(this ref Vector3 @this, Vector3 value)
	{
		@this = @this with
		{
			X = value.X,
			Z = value.Y,
			Y = value.Z
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void XZY<T>(this ref Vector3D<T> @this, Vector3D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			X = value.X,
			Z = value.Y,
			Y = value.Z
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YXZ(this ref Vector3 @this, Vector3 value)
	{
		@this = @this with
		{
			Y = value.X,
			X = value.Y,
			Z = value.Z
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YXZ<T>(this ref Vector3D<T> @this, Vector3D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Y = value.X,
			X = value.Y,
			Z = value.Z
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YZX(this ref Vector3 @this, Vector3 value)
	{
		@this = @this with
		{
			Y = value.X,
			Z = value.Y,
			X = value.Z
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YZX<T>(this ref Vector3D<T> @this, Vector3D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Y = value.X,
			Z = value.Y,
			X = value.Z
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZYX(this ref Vector3 @this, Vector3 value)
	{
		@this = @this with
		{
			Z = value.X,
			Y = value.Y,
			X = value.Z
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZYX<T>(this ref Vector3D<T> @this, Vector3D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Z = value.X,
			Y = value.Y,
			X = value.Z
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZXY(this ref Vector3 @this, Vector3 value)
	{
		@this = @this with
		{
			Z = value.X,
			X = value.Y,
			Y = value.Z
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZXY<T>(this ref Vector3D<T> @this, Vector3D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Z = value.X,
			X = value.Y,
			Y = value.Z
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXXX(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXXX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXXY(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXXY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXXZ(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXXZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXYX(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXYX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXYY(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXYY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXYZ(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXYZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXZX(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXZX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXZY(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXZY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXZZ(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXZZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYXX(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYXX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYXY(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYXY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYXZ(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYXZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYYX(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYYX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYYY(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYYY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYYZ(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYYZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYZX(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYZX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYZY(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYZY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYZZ(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYZZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XZXX(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XZXX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XZXY(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XZXY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XZXZ(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XZXZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XZYX(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XZYX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XZYY(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XZYY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XZYZ(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XZYZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XZZX(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XZZX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XZZY(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XZZY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XZZZ(this Vector3 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XZZZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXXX(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXXX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXXY(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXXY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXXZ(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXXZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXYX(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXYX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXYY(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXYY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXYZ(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXYZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXZX(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXZX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXZY(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXZY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXZZ(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXZZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYXX(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYXX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYXY(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYXY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYXZ(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYXZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYYX(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYYX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYYY(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYYY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYYZ(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYYZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYZX(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYZX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYZY(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYZY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYZZ(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYZZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YZXX(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YZXX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YZXY(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YZXY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YZXZ(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YZXZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YZYX(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YZYX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YZYY(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YZYY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YZYZ(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YZYZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YZZX(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YZZX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YZZY(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YZZY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YZZZ(this Vector3 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YZZZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZXXX(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZXXX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZXXY(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZXXY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZXXZ(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZXXZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZXYX(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZXYX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZXYY(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZXYY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZXYZ(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZXYZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZXZX(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZXZX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZXZY(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZXZY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZXZZ(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZXZZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZYXX(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZYXX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZYXY(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZYXY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZYXZ(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZYXZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZYYX(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZYYX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZYYY(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZYYY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZYYZ(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZYYZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZYZX(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZYZX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZYZY(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZYZY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZYZZ(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZYZZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZZXX(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZZXX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZZXY(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZZXY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZZXZ(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZZXZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZZYX(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZZYX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZZYY(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZZYY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZZYZ(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZZYZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZZZX(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZZZX<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZZZY(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZZZY<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZZZZ(this Vector3 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZZZZ<T>(this Vector3D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 XX(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> XX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 XY(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> XY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 XZ(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> XZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 XW(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> XW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 YX(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> YX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 YY(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> YY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 YZ(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> YZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 YW(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> YW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 ZX(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> ZX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 ZY(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> ZY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 ZZ(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> ZZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 ZW(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> ZW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 WX(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> WX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 WY(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> WY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 WZ(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> WZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 WW(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> WW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void XY(this ref Vector4 @this, Vector2 value)
	{
		@this = @this with
		{
			X = value.X,
			Y = value.Y
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void XY<T>(this ref Vector4D<T> @this, Vector2D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			X = value.X,
			Y = value.Y
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YX(this ref Vector4 @this, Vector2 value)
	{
		@this = @this with
		{
			Y = value.X,
			X = value.Y
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YX<T>(this ref Vector4D<T> @this, Vector2D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Y = value.X,
			X = value.Y
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YZ(this ref Vector4 @this, Vector2 value)
	{
		@this = @this with
		{
			Y = value.X,
			Z = value.Y
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YZ<T>(this ref Vector4D<T> @this, Vector2D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Y = value.X,
			Z = value.Y
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZY(this ref Vector4 @this, Vector2 value)
	{
		@this = @this with
		{
			Z = value.X,
			Y = value.Y
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZY<T>(this ref Vector4D<T> @this, Vector2D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Z = value.X,
			Y = value.Y
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZW(this ref Vector4 @this, Vector2 value)
	{
		@this = @this with
		{
			Z = value.X,
			W = value.Y
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZW<T>(this ref Vector4D<T> @this, Vector2D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Z = value.X,
			W = value.Y
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WZ(this ref Vector4 @this, Vector2 value)
	{
		@this = @this with
		{
			W = value.X,
			Z = value.Y
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WZ<T>(this ref Vector4D<T> @this, Vector2D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			W = value.X,
			Z = value.Y
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XXX(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XXX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XXY(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XXY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XXZ(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XXZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XXW(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XXW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XYX(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XYX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XYY(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XYY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XYZ(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XYZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XYW(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XYW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XZX(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XZX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XZY(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XZY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XZZ(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XZZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XZW(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XZW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XWX(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XWX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XWY(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XWY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XWZ(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XWZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 XWW(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> XWW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YXX(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YXX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YXY(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YXY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YXZ(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YXZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YXW(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YXW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YYX(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YYX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YYY(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YYY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YYZ(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YYZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YYW(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YYW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YZX(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YZX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YZY(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YZY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YZZ(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YZZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YZW(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YZW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YWX(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YWX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YWY(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YWY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YWZ(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YWZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 YWW(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> YWW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ZXX(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> ZXX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ZXY(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> ZXY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ZXZ(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> ZXZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ZXW(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> ZXW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ZYX(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> ZYX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ZYY(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> ZYY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ZYZ(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> ZYZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ZYW(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> ZYW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ZZX(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> ZZX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ZZY(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> ZZY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ZZZ(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> ZZZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ZZW(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> ZZW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ZWX(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> ZWX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ZWY(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> ZWY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ZWZ(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> ZWZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 ZWW(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> ZWW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 WXX(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> WXX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 WXY(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> WXY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 WXZ(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> WXZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 WXW(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> WXW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 WYX(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> WYX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 WYY(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> WYY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 WYZ(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> WYZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 WYW(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> WYW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 WZX(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> WZX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 WZY(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> WZY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 WZZ(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> WZZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 WZW(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> WZW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 WWX(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> WWX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 WWY(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> WWY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 WWZ(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> WWZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 WWW(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> WWW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void XYZ(this ref Vector4 @this, Vector3 value)
	{
		@this = @this with
		{
			X = value.X,
			Y = value.Y,
			Z = value.Z
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void XYZ<T>(this ref Vector4D<T> @this, Vector3D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			X = value.X,
			Y = value.Y,
			Z = value.Z
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void XZY(this ref Vector4 @this, Vector3 value)
	{
		@this = @this with
		{
			X = value.X,
			Z = value.Y,
			Y = value.Z
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void XZY<T>(this ref Vector4D<T> @this, Vector3D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			X = value.X,
			Z = value.Y,
			Y = value.Z
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YXZ(this ref Vector4 @this, Vector3 value)
	{
		@this = @this with
		{
			Y = value.X,
			X = value.Y,
			Z = value.Z
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YXZ<T>(this ref Vector4D<T> @this, Vector3D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Y = value.X,
			X = value.Y,
			Z = value.Z
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YZX(this ref Vector4 @this, Vector3 value)
	{
		@this = @this with
		{
			Y = value.X,
			Z = value.Y,
			X = value.Z
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YZX<T>(this ref Vector4D<T> @this, Vector3D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Y = value.X,
			Z = value.Y,
			X = value.Z
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZYX(this ref Vector4 @this, Vector3 value)
	{
		@this = @this with
		{
			Z = value.X,
			Y = value.Y,
			X = value.Z
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZYX<T>(this ref Vector4D<T> @this, Vector3D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Z = value.X,
			Y = value.Y,
			X = value.Z
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZXY(this ref Vector4 @this, Vector3 value)
	{
		@this = @this with
		{
			Z = value.X,
			X = value.Y,
			Y = value.Z
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZXY<T>(this ref Vector4D<T> @this, Vector3D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Z = value.X,
			X = value.Y,
			Y = value.Z
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YZW(this ref Vector4 @this, Vector3 value)
	{
		@this = @this with
		{
			Y = value.X,
			Z = value.Y,
			W = value.Z
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YZW<T>(this ref Vector4D<T> @this, Vector3D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Y = value.X,
			Z = value.Y,
			W = value.Z
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YWZ(this ref Vector4 @this, Vector3 value)
	{
		@this = @this with
		{
			Y = value.X,
			W = value.Y,
			Z = value.Z
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YWZ<T>(this ref Vector4D<T> @this, Vector3D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Y = value.X,
			W = value.Y,
			Z = value.Z
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZYW(this ref Vector4 @this, Vector3 value)
	{
		@this = @this with
		{
			Z = value.X,
			Y = value.Y,
			W = value.Z
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZYW<T>(this ref Vector4D<T> @this, Vector3D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Z = value.X,
			Y = value.Y,
			W = value.Z
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZWY(this ref Vector4 @this, Vector3 value)
	{
		@this = @this with
		{
			Z = value.X,
			W = value.Y,
			Y = value.Z
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZWY<T>(this ref Vector4D<T> @this, Vector3D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Z = value.X,
			W = value.Y,
			Y = value.Z
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WZY(this ref Vector4 @this, Vector3 value)
	{
		@this = @this with
		{
			W = value.X,
			Z = value.Y,
			Y = value.Z
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WZY<T>(this ref Vector4D<T> @this, Vector3D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			W = value.X,
			Z = value.Y,
			Y = value.Z
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WYZ(this ref Vector4 @this, Vector3 value)
	{
		@this = @this with
		{
			W = value.X,
			Y = value.Y,
			Z = value.Z
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WYZ<T>(this ref Vector4D<T> @this, Vector3D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			W = value.X,
			Y = value.Y,
			Z = value.Z
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXXX(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXXX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXXY(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXXY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXXZ(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXXZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXXW(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXXW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXYX(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXYX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXYY(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXYY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXYZ(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXYZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXYW(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXYW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXZX(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXZX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXZY(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXZY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXZZ(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXZZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXZW(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXZW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXWX(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXWX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXWY(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXWY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXWZ(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXWZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XXWW(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.X,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XXWW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.X,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYXX(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYXX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYXY(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYXY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYXZ(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYXZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYXW(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYXW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYYX(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYYX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYYY(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYYY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYYZ(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYYZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYYW(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYYW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYZX(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYZX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYZY(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYZY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYZZ(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYZZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYZW(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYZW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYWX(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYWX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYWY(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYWY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYWZ(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYWZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XYWW(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Y,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XYWW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Y,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XZXX(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XZXX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XZXY(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XZXY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XZXZ(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XZXZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XZXW(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XZXW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XZYX(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XZYX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XZYY(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XZYY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XZYZ(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XZYZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XZYW(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XZYW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XZZX(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XZZX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XZZY(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XZZY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XZZZ(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XZZZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XZZW(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XZZW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XZWX(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XZWX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XZWY(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XZWY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XZWZ(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XZWZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XZWW(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.Z,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XZWW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.Z,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XWXX(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.W,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XWXX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.W,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XWXY(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.W,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XWXY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.W,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XWXZ(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.W,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XWXZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.W,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XWXW(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.W,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XWXW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.W,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XWYX(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.W,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XWYX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.W,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XWYY(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.W,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XWYY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.W,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XWYZ(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.W,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XWYZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.W,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XWYW(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.W,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XWYW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.W,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XWZX(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.W,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XWZX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.W,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XWZY(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.W,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XWZY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.W,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XWZZ(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.W,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XWZZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.W,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XWZW(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.W,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XWZW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.W,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XWWX(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.W,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XWWX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.W,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XWWY(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.W,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XWWY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.W,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XWWZ(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.W,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XWWZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.W,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 XWWW(this Vector4 @this)
	{
		return new(
			@this.X,
			@this.W,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> XWWW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.X,
			@this.W,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXXX(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXXX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXXY(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXXY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXXZ(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXXZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXXW(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXXW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXYX(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXYX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXYY(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXYY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXYZ(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXYZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXYW(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXYW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXZX(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXZX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXZY(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXZY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXZZ(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXZZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXZW(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXZW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXWX(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXWX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXWY(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXWY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXWZ(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXWZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YXWW(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.X,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YXWW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.X,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYXX(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYXX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYXY(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYXY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYXZ(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYXZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYXW(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYXW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYYX(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYYX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYYY(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYYY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYYZ(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYYZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYYW(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYYW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYZX(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYZX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYZY(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYZY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYZZ(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYZZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYZW(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYZW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYWX(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYWX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYWY(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYWY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYWZ(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYWZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YYWW(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Y,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YYWW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Y,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YZXX(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YZXX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YZXY(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YZXY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YZXZ(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YZXZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YZXW(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YZXW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YZYX(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YZYX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YZYY(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YZYY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YZYZ(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YZYZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YZYW(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YZYW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YZZX(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YZZX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YZZY(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YZZY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YZZZ(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YZZZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YZZW(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YZZW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YZWX(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YZWX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YZWY(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YZWY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YZWZ(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YZWZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YZWW(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.Z,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YZWW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.Z,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YWXX(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.W,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YWXX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.W,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YWXY(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.W,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YWXY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.W,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YWXZ(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.W,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YWXZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.W,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YWXW(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.W,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YWXW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.W,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YWYX(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.W,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YWYX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.W,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YWYY(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.W,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YWYY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.W,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YWYZ(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.W,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YWYZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.W,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YWYW(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.W,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YWYW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.W,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YWZX(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.W,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YWZX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.W,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YWZY(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.W,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YWZY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.W,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YWZZ(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.W,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YWZZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.W,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YWZW(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.W,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YWZW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.W,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YWWX(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.W,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YWWX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.W,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YWWY(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.W,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YWWY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.W,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YWWZ(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.W,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YWWZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.W,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 YWWW(this Vector4 @this)
	{
		return new(
			@this.Y,
			@this.W,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> YWWW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Y,
			@this.W,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZXXX(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZXXX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZXXY(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZXXY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZXXZ(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZXXZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZXXW(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZXXW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZXYX(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZXYX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZXYY(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZXYY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZXYZ(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZXYZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZXYW(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZXYW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZXZX(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZXZX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZXZY(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZXZY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZXZZ(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZXZZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZXZW(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZXZW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZXWX(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZXWX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZXWY(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZXWY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZXWZ(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZXWZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZXWW(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.X,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZXWW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.X,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZYXX(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZYXX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZYXY(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZYXY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZYXZ(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZYXZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZYXW(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZYXW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZYYX(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZYYX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZYYY(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZYYY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZYYZ(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZYYZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZYYW(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZYYW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZYZX(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZYZX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZYZY(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZYZY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZYZZ(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZYZZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZYZW(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZYZW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZYWX(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZYWX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZYWY(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZYWY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZYWZ(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZYWZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZYWW(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Y,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZYWW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Y,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZZXX(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZZXX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZZXY(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZZXY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZZXZ(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZZXZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZZXW(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZZXW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZZYX(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZZYX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZZYY(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZZYY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZZYZ(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZZYZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZZYW(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZZYW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZZZX(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZZZX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZZZY(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZZZY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZZZZ(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZZZZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZZZW(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZZZW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZZWX(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZZWX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZZWY(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZZWY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZZWZ(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZZWZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZZWW(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.Z,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZZWW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.Z,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZWXX(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.W,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZWXX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.W,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZWXY(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.W,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZWXY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.W,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZWXZ(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.W,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZWXZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.W,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZWXW(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.W,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZWXW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.W,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZWYX(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.W,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZWYX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.W,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZWYY(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.W,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZWYY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.W,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZWYZ(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.W,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZWYZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.W,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZWYW(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.W,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZWYW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.W,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZWZX(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.W,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZWZX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.W,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZWZY(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.W,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZWZY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.W,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZWZZ(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.W,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZWZZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.W,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZWZW(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.W,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZWZW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.W,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZWWX(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.W,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZWWX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.W,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZWWY(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.W,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZWWY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.W,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZWWZ(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.W,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZWWZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.W,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 ZWWW(this Vector4 @this)
	{
		return new(
			@this.Z,
			@this.W,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> ZWWW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.Z,
			@this.W,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WXXX(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.X,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WXXX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.X,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WXXY(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.X,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WXXY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.X,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WXXZ(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.X,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WXXZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.X,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WXXW(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.X,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WXXW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.X,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WXYX(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.X,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WXYX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.X,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WXYY(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.X,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WXYY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.X,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WXYZ(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.X,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WXYZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.X,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WXYW(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.X,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WXYW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.X,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WXZX(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.X,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WXZX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.X,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WXZY(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.X,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WXZY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.X,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WXZZ(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.X,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WXZZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.X,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WXZW(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.X,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WXZW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.X,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WXWX(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.X,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WXWX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.X,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WXWY(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.X,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WXWY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.X,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WXWZ(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.X,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WXWZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.X,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WXWW(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.X,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WXWW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.X,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WYXX(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Y,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WYXX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Y,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WYXY(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Y,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WYXY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Y,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WYXZ(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Y,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WYXZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Y,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WYXW(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Y,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WYXW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Y,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WYYX(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Y,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WYYX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Y,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WYYY(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Y,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WYYY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Y,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WYYZ(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Y,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WYYZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Y,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WYYW(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Y,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WYYW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Y,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WYZX(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Y,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WYZX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Y,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WYZY(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Y,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WYZY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Y,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WYZZ(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Y,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WYZZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Y,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WYZW(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Y,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WYZW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Y,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WYWX(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Y,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WYWX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Y,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WYWY(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Y,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WYWY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Y,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WYWZ(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Y,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WYWZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Y,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WYWW(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Y,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WYWW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Y,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WZXX(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Z,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WZXX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Z,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WZXY(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Z,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WZXY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Z,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WZXZ(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Z,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WZXZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Z,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WZXW(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Z,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WZXW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Z,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WZYX(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Z,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WZYX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Z,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WZYY(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Z,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WZYY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Z,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WZYZ(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Z,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WZYZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Z,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WZYW(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Z,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WZYW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Z,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WZZX(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Z,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WZZX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Z,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WZZY(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Z,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WZZY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Z,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WZZZ(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Z,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WZZZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Z,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WZZW(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Z,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WZZW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Z,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WZWX(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Z,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WZWX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Z,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WZWY(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Z,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WZWY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Z,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WZWZ(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Z,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WZWZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Z,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WZWW(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.Z,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WZWW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.Z,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WWXX(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.W,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WWXX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.W,
			@this.X,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WWXY(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.W,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WWXY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.W,
			@this.X,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WWXZ(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.W,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WWXZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.W,
			@this.X,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WWXW(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.W,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WWXW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.W,
			@this.X,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WWYX(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.W,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WWYX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.W,
			@this.Y,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WWYY(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.W,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WWYY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.W,
			@this.Y,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WWYZ(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.W,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WWYZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.W,
			@this.Y,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WWYW(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.W,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WWYW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.W,
			@this.Y,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WWZX(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.W,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WWZX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.W,
			@this.Z,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WWZY(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.W,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WWZY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.W,
			@this.Z,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WWZZ(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.W,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WWZZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.W,
			@this.Z,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WWZW(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.W,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WWZW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.W,
			@this.Z,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WWWX(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.W,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WWWX<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.W,
			@this.W,
			@this.X);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WWWY(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.W,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WWWY<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.W,
			@this.W,
			@this.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WWWZ(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.W,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WWWZ<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.W,
			@this.W,
			@this.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 WWWW(this Vector4 @this)
	{
		return new(
			@this.W,
			@this.W,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4D<T> WWWW<T>(this Vector4D<T> @this)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return new(
			@this.W,
			@this.W,
			@this.W,
			@this.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void XYZW(this ref Vector4 @this, Vector4 value)
	{
		@this = @this with
		{
			X = value.X,
			Y = value.Y,
			Z = value.Z,
			W = value.W
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void XYZW<T>(this ref Vector4D<T> @this, Vector4D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			X = value.X,
			Y = value.Y,
			Z = value.Z,
			W = value.W
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void XYWZ(this ref Vector4 @this, Vector4 value)
	{
		@this = @this with
		{
			X = value.X,
			Y = value.Y,
			W = value.Z,
			Z = value.W
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void XYWZ<T>(this ref Vector4D<T> @this, Vector4D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			X = value.X,
			Y = value.Y,
			W = value.Z,
			Z = value.W
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void XZYW(this ref Vector4 @this, Vector4 value)
	{
		@this = @this with
		{
			X = value.X,
			Z = value.Y,
			Y = value.Z,
			W = value.W
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void XZYW<T>(this ref Vector4D<T> @this, Vector4D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			X = value.X,
			Z = value.Y,
			Y = value.Z,
			W = value.W
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void XZWY(this ref Vector4 @this, Vector4 value)
	{
		@this = @this with
		{
			X = value.X,
			Z = value.Y,
			W = value.Z,
			Y = value.W
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void XZWY<T>(this ref Vector4D<T> @this, Vector4D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			X = value.X,
			Z = value.Y,
			W = value.Z,
			Y = value.W
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void XWZY(this ref Vector4 @this, Vector4 value)
	{
		@this = @this with
		{
			X = value.X,
			W = value.Y,
			Z = value.Z,
			Y = value.W
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void XWZY<T>(this ref Vector4D<T> @this, Vector4D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			X = value.X,
			W = value.Y,
			Z = value.Z,
			Y = value.W
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void XWYZ(this ref Vector4 @this, Vector4 value)
	{
		@this = @this with
		{
			X = value.X,
			W = value.Y,
			Y = value.Z,
			Z = value.W
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void XWYZ<T>(this ref Vector4D<T> @this, Vector4D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			X = value.X,
			W = value.Y,
			Y = value.Z,
			Z = value.W
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YXZW(this ref Vector4 @this, Vector4 value)
	{
		@this = @this with
		{
			Y = value.X,
			X = value.Y,
			Z = value.Z,
			W = value.W
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YXZW<T>(this ref Vector4D<T> @this, Vector4D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Y = value.X,
			X = value.Y,
			Z = value.Z,
			W = value.W
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YXWZ(this ref Vector4 @this, Vector4 value)
	{
		@this = @this with
		{
			Y = value.X,
			X = value.Y,
			W = value.Z,
			Z = value.W
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YXWZ<T>(this ref Vector4D<T> @this, Vector4D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Y = value.X,
			X = value.Y,
			W = value.Z,
			Z = value.W
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YZXW(this ref Vector4 @this, Vector4 value)
	{
		@this = @this with
		{
			Y = value.X,
			Z = value.Y,
			X = value.Z,
			W = value.W
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YZXW<T>(this ref Vector4D<T> @this, Vector4D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Y = value.X,
			Z = value.Y,
			X = value.Z,
			W = value.W
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YZWX(this ref Vector4 @this, Vector4 value)
	{
		@this = @this with
		{
			Y = value.X,
			Z = value.Y,
			W = value.Z,
			X = value.W
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YZWX<T>(this ref Vector4D<T> @this, Vector4D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Y = value.X,
			Z = value.Y,
			W = value.Z,
			X = value.W
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YWZX(this ref Vector4 @this, Vector4 value)
	{
		@this = @this with
		{
			Y = value.X,
			W = value.Y,
			Z = value.Z,
			X = value.W
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YWZX<T>(this ref Vector4D<T> @this, Vector4D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Y = value.X,
			W = value.Y,
			Z = value.Z,
			X = value.W
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YWXZ(this ref Vector4 @this, Vector4 value)
	{
		@this = @this with
		{
			Y = value.X,
			W = value.Y,
			X = value.Z,
			Z = value.W
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void YWXZ<T>(this ref Vector4D<T> @this, Vector4D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Y = value.X,
			W = value.Y,
			X = value.Z,
			Z = value.W
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZYXW(this ref Vector4 @this, Vector4 value)
	{
		@this = @this with
		{
			Z = value.X,
			Y = value.Y,
			X = value.Z,
			W = value.W
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZYXW<T>(this ref Vector4D<T> @this, Vector4D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Z = value.X,
			Y = value.Y,
			X = value.Z,
			W = value.W
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZYWX(this ref Vector4 @this, Vector4 value)
	{
		@this = @this with
		{
			Z = value.X,
			Y = value.Y,
			W = value.Z,
			X = value.W
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZYWX<T>(this ref Vector4D<T> @this, Vector4D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Z = value.X,
			Y = value.Y,
			W = value.Z,
			X = value.W
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZXYW(this ref Vector4 @this, Vector4 value)
	{
		@this = @this with
		{
			Z = value.X,
			X = value.Y,
			Y = value.Z,
			W = value.W
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZXYW<T>(this ref Vector4D<T> @this, Vector4D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Z = value.X,
			X = value.Y,
			Y = value.Z,
			W = value.W
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZXWY(this ref Vector4 @this, Vector4 value)
	{
		@this = @this with
		{
			Z = value.X,
			X = value.Y,
			W = value.Z,
			Y = value.W
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZXWY<T>(this ref Vector4D<T> @this, Vector4D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Z = value.X,
			X = value.Y,
			W = value.Z,
			Y = value.W
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZWXY(this ref Vector4 @this, Vector4 value)
	{
		@this = @this with
		{
			Z = value.X,
			W = value.Y,
			X = value.Z,
			Y = value.W
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZWXY<T>(this ref Vector4D<T> @this, Vector4D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Z = value.X,
			W = value.Y,
			X = value.Z,
			Y = value.W
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZWYX(this ref Vector4 @this, Vector4 value)
	{
		@this = @this with
		{
			Z = value.X,
			W = value.Y,
			Y = value.Z,
			X = value.W
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ZWYX<T>(this ref Vector4D<T> @this, Vector4D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			Z = value.X,
			W = value.Y,
			Y = value.Z,
			X = value.W
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WYZX(this ref Vector4 @this, Vector4 value)
	{
		@this = @this with
		{
			W = value.X,
			Y = value.Y,
			Z = value.Z,
			X = value.W
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WYZX<T>(this ref Vector4D<T> @this, Vector4D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			W = value.X,
			Y = value.Y,
			Z = value.Z,
			X = value.W
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WYXZ(this ref Vector4 @this, Vector4 value)
	{
		@this = @this with
		{
			W = value.X,
			Y = value.Y,
			X = value.Z,
			Z = value.W
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WYXZ<T>(this ref Vector4D<T> @this, Vector4D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			W = value.X,
			Y = value.Y,
			X = value.Z,
			Z = value.W
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WZYX(this ref Vector4 @this, Vector4 value)
	{
		@this = @this with
		{
			W = value.X,
			Z = value.Y,
			Y = value.Z,
			X = value.W
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WZYX<T>(this ref Vector4D<T> @this, Vector4D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			W = value.X,
			Z = value.Y,
			Y = value.Z,
			X = value.W
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WZXY(this ref Vector4 @this, Vector4 value)
	{
		@this = @this with
		{
			W = value.X,
			Z = value.Y,
			X = value.Z,
			Y = value.W
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WZXY<T>(this ref Vector4D<T> @this, Vector4D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			W = value.X,
			Z = value.Y,
			X = value.Z,
			Y = value.W
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WXZY(this ref Vector4 @this, Vector4 value)
	{
		@this = @this with
		{
			W = value.X,
			X = value.Y,
			Z = value.Z,
			Y = value.W
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WXZY<T>(this ref Vector4D<T> @this, Vector4D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			W = value.X,
			X = value.Y,
			Z = value.Z,
			Y = value.W
		};
	}


	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WXYZ(this ref Vector4 @this, Vector4 value)
	{
		@this = @this with
		{
			W = value.X,
			X = value.Y,
			Y = value.Z,
			Z = value.W
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WXYZ<T>(this ref Vector4D<T> @this, Vector4D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		@this = @this with
		{
			W = value.X,
			X = value.Y,
			Y = value.Z,
			Z = value.W
		};
	}


}
