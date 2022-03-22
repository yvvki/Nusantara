// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Nusantara.Maths;

// Based of: https://en.wikipedia.org/wiki/Conversion_between_quaternions_and_Euler_angles
public struct EulerRotation :
	IEquatable<EulerRotation>
{
	public EulerRotation(float yaw, float pitch, float roll)
	{
		Yaw = yaw;
		Pitch = pitch;
		Roll = roll;
	}

	public float Yaw;
	public float Pitch;
	public float Roll;

	// I am very smart yes.
	public static EulerRotation CreateFromQuaternion(Quaternion q)
	{
		EulerRotation euler;

		// Yaw (y-axis rotation)
		float siny_cosp = 2 * (q.W * q.Y + q.X * q.Z);
		float cosy_cosp = 1 - 2 * (q.Y * q.Y + q.X * q.X);
		euler.Yaw = MathF.Atan2(siny_cosp, cosy_cosp);

		// Pitch (x-axis rotation)
		float sinp = 2 * (q.W * q.X - q.Z * q.Y);
		euler.Pitch = (MathF.Abs(sinp) >= 1) ? MathF.CopySign(MathF.PI / 2, sinp) : MathF.Asin(sinp);

		// Roll (z-axis rotation)
		float sinr_cosp = 2 * (q.W * q.Z + q.X * q.Y);
		float cosr_cosp = 1 - 2 * (q.Z * q.Z + q.X * q.X);
		euler.Roll = MathF.Atan2(sinr_cosp, cosr_cosp);

		return euler;
	}

	public bool Equals(EulerRotation other)
	{
		return this == other;
	}
	public override bool Equals([NotNullWhen(true)] object? obj)
	{
		return obj is EulerRotation other && Equals(other);
	}
	public override int GetHashCode()
	{
		return unchecked(Yaw.GetHashCode() + Pitch.GetHashCode() + Roll.GetHashCode());
	}

	public static bool operator ==(EulerRotation left, EulerRotation right)
	{
		return left.Yaw == right.Yaw
			&& left.Pitch == right.Pitch
			&& left.Roll == right.Roll;
	}
	public static bool operator !=(EulerRotation left, EulerRotation right)
	{
		return !(left == right);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static EulerRotation Negate(EulerRotation value)
	{
		return -value;
	}
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static EulerRotation Add(EulerRotation left, EulerRotation right)
	{
		return left + right;
	}
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static EulerRotation Subtract(EulerRotation left, EulerRotation right)
	{
		return left - right;
	}
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static EulerRotation Multiply(EulerRotation left, EulerRotation right)
	{
		return left * right;
	}
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static EulerRotation Divide(EulerRotation left, EulerRotation right)
	{
		return left / right;
	}

	public static EulerRotation operator -(EulerRotation value)
	{
		EulerRotation result;

		result.Yaw = -value.Yaw;
		result.Pitch = -value.Pitch;
		result.Roll = -value.Roll;

		return result;
	}
	public static EulerRotation operator +(EulerRotation left, EulerRotation right)
	{
		EulerRotation result;

		result.Yaw = left.Yaw + right.Yaw;
		result.Pitch = left.Pitch + right.Pitch;
		result.Roll = left.Roll + right.Roll;

		return result;
	}
	public static EulerRotation operator -(EulerRotation left, EulerRotation right)
	{
		EulerRotation result;

		result.Yaw = left.Yaw - right.Yaw;
		result.Pitch = left.Pitch - right.Pitch;
		result.Roll = left.Roll - right.Roll;

		return result;
	}
	public static EulerRotation operator *(EulerRotation left, EulerRotation right)
	{
		EulerRotation result;

		result.Yaw = left.Yaw * right.Yaw;
		result.Pitch = left.Pitch * right.Pitch;
		result.Roll = left.Roll * right.Roll;

		return result;
	}
	public static EulerRotation operator /(EulerRotation left, EulerRotation right)
	{
		EulerRotation result;

		result.Yaw = left.Yaw / right.Yaw;
		result.Pitch = left.Pitch / right.Pitch;
		result.Roll = left.Roll / right.Roll;

		return result;
	}

	public override string ToString()
	{
		return $"{{Yaw:{Yaw} Pitch:{Pitch} Roll:{Roll}}}";
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator Quaternion(EulerRotation value)
	{
		return Quaternion.CreateFromYawPitchRoll(value.Yaw, value.Pitch, value.Roll);
	}
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static explicit operator EulerRotation(Quaternion value)
	{
		return CreateFromQuaternion(value);
	}
}