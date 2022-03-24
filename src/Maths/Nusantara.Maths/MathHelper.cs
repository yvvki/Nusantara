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

	#region Create Matrix

	/// <inheritdoc cref="Matrix4x4.CreateScale(Vector3)"/>
	public static Matrix4x4 CreateScale(Vector4 scales)
	{
		Matrix4x4 result = Matrix4x4.Identity;
		result.M11 = scales.X;
		result.M22 = scales.Y;
		result.M33 = scales.Z;
		result.M44 = scales.W;
		return result;
	}

	/// <inheritdoc cref="Matrix4x4.CreateTranslation(Vector3)"/>
	public static Matrix4x4 CreateTranslation(Vector4 position)
	{
		Matrix4x4 result = Matrix4x4.Identity;
		result.M41 = position.X;
		result.M42 = position.Y;
		result.M43 = position.Z;
		result.M44 = position.W;
		return result;
	}

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

	public static Matrix4x4 CreateTransform(Vector4 translation, Quaternion rotation, Vector4 scale)
	{
		Matrix4x4 result;

		// Scale
		Matrix4x4 m_scale = CreateScale(scale);
		// Rotation
		Matrix4x4 m_rotation = Matrix4x4.CreateFromQuaternion(rotation);

		result = Matrix4x4.Multiply(m_scale, m_rotation);

		// Translation
		result.Translation = translation.XYZ();
		result.M44 *= translation.W;

		return result;
	}

	#endregion
}
