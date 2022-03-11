// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Diagnostics;
using System.Numerics;

namespace Nusantara.Maths;

// Based on: https://en.wikipedia.org/wiki/Conversion_between_quaternions_and_Euler_angles
public record struct EulerRotation(float Yaw, float Pitch, float Roll)
{
	public float Yaw = Yaw;
	public float Pitch = Pitch;
	public float Roll = Roll;

	// wikipedia
	public static Quaternion ToQuaternionZYX(EulerRotation euler)
	{
		float sr, cr, sp, cp, sy, cy;

		float halfYaw = euler.Yaw * 0.5f;
		sy = MathF.Sin(halfYaw);
		cy = MathF.Cos(halfYaw);

		float halfPitch = euler.Pitch * 0.5f;
		sp = MathF.Sin(halfPitch);
		cp = MathF.Cos(halfPitch);

		float halfRoll = euler.Roll * 0.5f;
		sr = MathF.Sin(halfRoll);
		cr = MathF.Cos(halfRoll);

		Quaternion result;

		result.Z = sy * cp * cr - cy * sp * sr;
		result.Y = cy * sp * cr + sy * cp * sr;
		result.X = cy * cp * sr - sy * sp * cr;
		result.W = cy * cp * cr + sy * sp * sr;

		return result;
	}

	// wikipedia
	public static EulerRotation CreateFromQuaternionZYX(Quaternion q)
	{
		EulerRotation euler;

		// roll (x-axis rotation)
		float sinr_cosp = 2 * (q.W * q.X + q.Y * q.Z);
		float cosr_cosp = 1 - 2 * (q.X * q.X + q.Y * q.Y);
		euler.Roll = MathF.Atan2(sinr_cosp, cosr_cosp);

		// pitch (y-axis rotation)
		float sinp = 2 * (q.W * q.Y - q.Z * q.X);
		if (MathF.Abs(sinp) >= 1)
			euler.Pitch = MathF.CopySign(MathF.PI / 2, sinp); // use 90 degrees if out of range
		else
			euler.Pitch = MathF.Asin(sinp);

		// yaw (z-axis rotation)
		float siny_cosp = 2 * (q.W * q.Z + q.X * q.Y);
		float cosy_cosp = 1 - 2 * (q.Y * q.Y + q.Z * q.Z);
		euler.Yaw = MathF.Atan2(siny_cosp, cosy_cosp);

		return euler;
	}

	// dotnet
	public static Quaternion ToQuaternionYXZ(EulerRotation euler)
	{
		float sr, cr, sp, cp, sy, cy;

		float halfYaw = euler.Yaw * 0.5f;
		sy = MathF.Sin(halfYaw);
		cy = MathF.Cos(halfYaw);

		float halfPitch = euler.Pitch * 0.5f;
		sp = MathF.Sin(halfPitch);
		cp = MathF.Cos(halfPitch);

		float halfRoll = euler.Roll * 0.5f;
		sr = MathF.Sin(halfRoll);
		cr = MathF.Cos(halfRoll);

		Quaternion result;

		result.Y = sy * cp * cr - cy * sp * sr;
		result.X = cy * sp * cr + sy * cp * sr;
		result.Z = cy * cp * sr - sy * sp * cr;
		result.W = cy * cp * cr + sy * sp * sr;

		return result;
	}

	// dotnet style
	public static EulerRotation CreateFromQuaternionYXZ(Quaternion q)
	{
		EulerRotation euler;

		// yaw (y-axis rotation)
		float sinp = 2 * (q.W * q.Y - q.Z * q.X);
		if (MathF.Abs(sinp) >= 1)
			euler.Yaw = MathF.CopySign(MathF.PI / 2, sinp); // use 90 degrees if out of range
		else
			euler.Yaw = MathF.Asin(sinp);

		// pitch (x-axis rotation)
		float sinr_cosp = 2 * (q.W * q.X + q.Y * q.Z);
		float cosr_cosp = 1 - 2 * (q.X * q.X + q.Y * q.Y);
		euler.Pitch = MathF.Atan2(sinr_cosp, cosr_cosp);

		// roll (z-axis rotation)
		float siny_cosp = 2 * (q.W * q.Z + q.X * q.Y);
		float cosy_cosp = 1 - 2 * (q.Y * q.Y + q.Z * q.Z);
		euler.Roll = MathF.Atan2(siny_cosp, cosy_cosp);

		return euler;
	}

	public static void Test()
	{
		Random r = new();

		Quaternion q1 = new(r.NextSingle(), r.NextSingle(), r.NextSingle(), r.NextSingle());

		EulerRotation euler = CreateFromQuaternionYXZ(q1);

		Quaternion q2 = ToQuaternionYXZ(euler);

		Debug.Assert(q1.Equals(q2));
	}

	public static implicit operator Quaternion(EulerRotation value)
	{
		return Quaternion.CreateFromYawPitchRoll(value.Yaw, value.Pitch, value.Roll);
	}
};
