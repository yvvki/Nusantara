using System.Numerics;

using Silk.NET.Maths;

namespace Nusantara.Maths;

public static partial class VectorExtensions
{
	public static void Deconstruct(
		this Vector2 @this,
		out float x,
		out float y)
	{
		x = @this.X;
		y = @this.Y;
	}

	public static void Deconstruct<T>(
		this Vector2D<T> @this,
		out T x,
		out T y)
		where T : unmanaged, IEquatable<T>, IComparable<T>, IFormattable
	{
		x = @this.X;
		y = @this.Y;
	}

	public static void Deconstruct(
		this Vector3 @this,
		out float x,
		out float y,
		out float z)
	{
		x = @this.X;
		y = @this.Y;
		z = @this.Z;
	}

	public static void Deconstruct<T>(
		this Vector3D<T> @this,
		out T x,
		out T y,
		out T z)
		where T : unmanaged, IEquatable<T>, IComparable<T>, IFormattable
	{
		x = @this.X;
		y = @this.Y;
		z = @this.Z;
	}

	public static void Deconstruct(
		this Vector4 @this,
		out float x,
		out float y,
		out float z,
		out float w)
	{
		x = @this.X;
		y = @this.Y;
		z = @this.Z;
		w = @this.W;
	}

	public static void Deconstruct<T>(
		this Vector4D<T> @this,
		out T x,
		out T y,
		out T z,
		out T w)
		where T : unmanaged, IEquatable<T>, IComparable<T>, IFormattable
	{
		x = @this.X;
		y = @this.Y;
		z = @this.Z;
		w = @this.W;
	}

}