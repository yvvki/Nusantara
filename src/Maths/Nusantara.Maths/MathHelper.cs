// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;
using System.Runtime.CompilerServices;

using Silk.NET.Maths;

namespace Nusantara.Maths;

public static partial class MathHelper
{
	#region PI Minus Epsilon

	/// <summary>
	///   Represents the smallest difference value that is less than PI.
	/// </summary>
	/*
	 * Subtracting with float.Epsilon is impossible due to single floating point imprecision.
	 * The bits on MathF.PI is: 1000000010010010000111111011011,
	 * while this constant is:  1000000010010010000111111011010
	 */
	public const float PIMinusEpsilon = MathF.PI - 0.000000119209286f;

	#endregion

	#region Homogeneous Vector

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3D<T> NormalizeHomogeneous<T>(Vector4D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return Vector3D.Divide(value.XYZ(), value.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 NormalizeHomogeneous(Vector4 value)
	{
		return Vector3.Divide(value.XYZ(), value.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D<T> NormalizeHomogeneous<T>(Vector3D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return Vector2D.Divide(value.XY(), value.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 NormalizeHomogeneous(Vector3 value)
	{
		return Vector2.Divide(value.XY(), value.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T NormalizeHomogeneous<T>(Vector2D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		return Scalar.Divide(value.X, value.Y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float NormalizeHomogeneous(Vector2 value)
	{
		return value.X / value.Y;
	}

	#endregion

	#region Smooth Linear Interpolation

	public static Vector2 Slerp(Vector2 value1, Vector2 value2, float amount)
	{
		float dot = Vector2.Dot(value1, value2);

		dot = Math.Clamp(dot, -1.0f, 1.0f);

		float theta_0 = MathF.Acos(dot);
		float theta = theta_0 * amount;

		Vector2 value3 = new(-value1.Y, value1.X);

		return value1 * MathF.Cos(theta) + value3 * MathF.Sin(theta);
	}

	#endregion

	#region Rectangle

	public static System.Drawing.RectangleF CalculateBounds(ReadOnlySpan<Vector2> vectors)
	{
		// Return if empty
		if (vectors.IsEmpty) return new(System.Drawing.PointF.Empty, System.Drawing.SizeF.Empty);

		Vector2 left_top;
		Vector2 right_bottom;

		// Assign the first 
		left_top = right_bottom = vectors[0];

		for (int i = 1; i < vectors.Length; i++)
		{
			var vector = vectors[i];

			left_top = Vector2.Min(left_top, vector);
			right_bottom = Vector2.Max(right_bottom, vector);
		}


		return System.Drawing.RectangleF.FromLTRB(left_top.X, left_top.Y, right_bottom.X, right_bottom.Y);
	}

	public static Rectangle<T> CalculateBounds<T>(ReadOnlySpan<Vector2D<T>> vectors)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		// Return early if empty.
		if (vectors.IsEmpty) return new(Vector2D<T>.Zero, Vector2D<T>.Zero);

		Vector2D<T> left_top;
		Vector2D<T> right_bottom;

		// Assign the first 
		left_top = right_bottom = vectors[0];

		for (int i = 1; i < vectors.Length; i++)
		{
			var vector = vectors[i];

			left_top = Vector2D.Min(left_top, vector);
			right_bottom = Vector2D.Max(right_bottom, vector);
		}

		return Rectangle.FromLTRB(left_top.X, left_top.Y, right_bottom.X, right_bottom.Y);
	}

	#endregion

	#region Create Matrix

	public static Matrix4x4 CreateTransform(Vector3 translation, Quaternion rotation, Vector3 scale)
	{
		Matrix4x4 result;

		// Scale
		Matrix4x4 m_scale = Matrix4x4.CreateScale(scale);
		// Rotation
		Matrix4x4 m_rotation = Matrix4x4.CreateFromQuaternion(rotation);

		result = Matrix4x4.Multiply(m_scale, m_rotation);

		// Translation
		result.Translation = translation;

		return result;
	}

	#endregion
}
