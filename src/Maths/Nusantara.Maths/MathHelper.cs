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

	#region Radians Degrees

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float DegreesToRadians(float degrees)
	{
		const float constant = MathF.PI / 180.0f;
		return degrees * constant;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float RadiansToDegree(float radians)
	{
		const float constant = 180.0f / MathF.PI;
		return radians * constant;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double DegreesToRadians(double degrees)
	{
		const double constant = Math.PI / 180.0;
		return degrees * constant;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double RadiansToDegree(double radians)
	{
		const double constant = 180.0 / Math.PI;
		return radians * constant;
	}

	#endregion

	#region Homogeneous Vector

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 AddHomogeneous(Vector4 left, Vector4 right)
	{
		return new(
			left.X + right.X,
			left.Y + right.Y,
			left.Z + right.Z,
			left.W * right.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 SubtractHomogeneous(Vector4 left, Vector4 right)
	{
		return new(
			left.X - right.X,
			left.Y - right.Y,
			left.Z - right.Z,
			left.W / right.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 NegateHomogeneous(Vector4 value)
	{
		return SubtractHomogeneous(Vector4.UnitW, value);
	}

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

	#region To Euler Angles

	// https://en.wikipedia.org/wiki/Conversion_between_quaternions_and_Euler_angles#Source_code_2
	public static (float yaw, float pitch, float roll) ToEulerAngles(Quaternion q)
	{
		float yaw, pitch, roll;

		// roll (x-axis rotation)
		float sinr_cosp = 2 * (q.W * q.X + q.Y * q.Z);
		float cosr_cosp = 1 - 2 * (q.X * q.X + q.Y * q.Y);
		roll = MathF.Atan2(sinr_cosp, cosr_cosp);

		// pitch (y-axis rotation)
		float sinp = 2 * (q.W * q.Y - q.Z * q.X);
		if (MathF.Abs(sinp) >= 1)
			pitch = MathF.CopySign(MathF.PI / 2, sinp); // use 90 degrees if out of range
		else
			pitch = MathF.Asin(sinp);

		// yaw (z-axis rotation)
		float siny_cosp = 2 * (q.W * q.Z + q.X * q.Y);
		float cosy_cosp = 1 - 2 * (q.Y * q.Y + q.Z * q.Z);
		yaw = MathF.Atan2(siny_cosp, cosy_cosp);

		return (yaw, pitch, roll);
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
