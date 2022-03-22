﻿// <https://github.com/YvvkiRika> wrote this file.
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

	public float Yaw;
	public float Pitch;
	public float Roll;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static Vector3 ToVector(EulerRotation euler)
	{
		return new(euler.Yaw, euler.Pitch, euler.Roll);
	}
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static EulerRotation FromVector(Vector3 vector)
	{
		return new(vector.X, vector.Y, vector.Z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(EulerRotation other)
	{
		return ToVector(this).Equals(ToVector(other));
	}
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override bool Equals([NotNullWhen(true)] object? obj)
	{
		return obj is EulerRotation other && Equals(other);
	}
	public override int GetHashCode()
	{
		return ToVector(this).GetHashCode();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator ==(EulerRotation left, EulerRotation right)
	{
		return ToVector(left) == ToVector(right);
	}
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator !=(EulerRotation left, EulerRotation right)
	{
		return ToVector(left) != ToVector(right);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static EulerRotation Negate(EulerRotation value)
	{
		return FromVector(Vector3.Negate(ToVector(value)));
	}
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static EulerRotation Add(EulerRotation left, EulerRotation right)
	{
		return FromVector(Vector3.Add(ToVector(left), ToVector(right)));
	}
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static EulerRotation Subtract(EulerRotation left, EulerRotation right)
	{
		return FromVector(Vector3.Subtract(ToVector(left), ToVector(right)));
	}
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static EulerRotation Multiply(EulerRotation left, EulerRotation right)
	{
		return FromVector(Vector3.Multiply(ToVector(left), ToVector(right)));
	}
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static EulerRotation Divide(EulerRotation left, EulerRotation right)
	{
		return FromVector(Vector3.Divide(ToVector(left), ToVector(right)));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static EulerRotation operator -(EulerRotation value)
	{
		return FromVector(-ToVector(value));
	}
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static EulerRotation operator +(EulerRotation left, EulerRotation right)
	{
		return FromVector(ToVector(left) + ToVector(right));
	}
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static EulerRotation operator -(EulerRotation left, EulerRotation right)
	{
		return FromVector(ToVector(left) - ToVector(right));
	}
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static EulerRotation operator *(EulerRotation left, EulerRotation right)
	{
		return FromVector(ToVector(left) * ToVector(right));
	}
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static EulerRotation operator *(EulerRotation left, float right)
	{
		return FromVector(ToVector(left) * right);
	}
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static EulerRotation operator *(float left, EulerRotation right)
	{
		return FromVector(left * ToVector(right));
	}
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static EulerRotation operator /(EulerRotation left, EulerRotation right)
	{
		return FromVector(ToVector(left) / ToVector(right));
	}
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static EulerRotation operator /(EulerRotation left, float right)
	{
		return FromVector(ToVector(left) / right);
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