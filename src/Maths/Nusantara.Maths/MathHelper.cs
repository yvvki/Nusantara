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

	#region Get Rotation

	// https://stackoverflow.com/a/13459068/14511192
	// https://www.gamedev.net/forums/topic/697501-get-rotation-angle-from-normalized-2d-vector/5382911/
	public static float GetRotation(Vector2 direction)
	{
		if (direction == Vector2.UnitX)
		{
			return 0;
		}
		else if (direction == Vector2.UnitY)
		{
			return MathF.PI / 2;
		}
		else if (direction == -Vector2.UnitX)
		{
			return MathF.PI;
		}
		else if (direction == -Vector2.UnitY)
		{
			return -MathF.PI / 2;
		}

		return MathF.Atan2(direction.Y, direction.X);
	}

	#endregion

	#region Interpolation

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Lerp(float value1, float value2, float amount)
	{
		return (value1 * (1 - amount)) + (value2 * amount);
	}

	// https://en.wikipedia.org/wiki/Slerp
	// Implementation based of
	// https://stackoverflow.com/questions/3039026/edges-on-polygon-outlines-not-always-correct/3058978#3058978
	public static Vector2 Slerp(Vector2 value1, Vector2 value2, float amount)
	{
		float dot = Vector2.Dot(value1, value2);
		dot = Math.Clamp(dot, -1.0f, 1.0f);

		float theta_1 = MathF.Acos(dot);
		float theta = theta_1 * amount;

		Vector2 relative = value2 - (value1 * dot);
		Vector2 relative_normalized = Vector2.Normalize(relative);

		(float sin, float cos) = MathF.SinCos(theta);

		return value1 * cos + relative_normalized * sin;
	}

	#endregion

	#region Line Intersection

	// https://en.wikipedia.org/wiki/Line%E2%80%93line_intersection
	public static Vector2 Intersection(Vector2 value1, Vector2 value2, Vector2 value3, Vector2 value4)
	{
		float x1 = value1.X;
		float y1 = value1.Y;
		float x2 = value2.X;
		float y2 = value2.Y;
		float x3 = value3.X;
		float y3 = value3.Y;
		float x4 = value4.X;
		float y4 = value4.Y;

		float D = (x1 - x2) * (y3 - y4) - (y1 - y2) * (x3 - x4);
		if (D is 0)
		{
			return new(float.NaN);
		}

		float x1y2_y1x2 = x1 * y2 - y1 * x2;
		float x3y4_y3x4 = x3 * y4 - y3 * x4;

		float Px = (x1y2_y1x2 * (x3 - x4) - (x1 - x2) * x3y4_y3x4) / D;
		float Py = (x1y2_y1x2 * (y3 - y4) - (y1 - y2) * x3y4_y3x4) / D;

		return new(Px, Py);
	}

	#endregion

	#region Rectangle

	public static System.Drawing.RectangleF CalculateBounds(ReadOnlySpan<Vector2> vectors)
	{
		if (vectors.IsEmpty) return System.Drawing.RectangleF.Empty;

		Vector2 left_top;
		Vector2 right_bottom;

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
		if (vectors.IsEmpty) return new(Vector2D<T>.Zero, Vector2D<T>.Zero);

		Vector2D<T> left_top;
		Vector2D<T> right_bottom;

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

		Matrix4x4 m_scale = Matrix4x4.CreateScale(scale);
		Matrix4x4 m_rotation = Matrix4x4.CreateFromQuaternion(rotation);

		result = Matrix4x4.Multiply(m_scale, m_rotation);
		result.Translation = translation;

		return result;
	}

	public static Matrix3x2 CreateTransform(Vector2 translation, float rotation, Vector2 scale)
	{
		Matrix3x2 result;

		Matrix3x2 m_scale = Matrix3x2.CreateScale(scale);
		Matrix3x2 m_rotation = Matrix3x2.CreateRotation(rotation);

		result = Matrix3x2.Multiply(m_scale, m_rotation);
		result.Translation = translation;

		return result;
	}

	#endregion
}
