// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Diagnostics;
using System.Numerics;

using static System.MathF;

namespace Nusantara.Maths;

// Based on: https://en.wikipedia.org/wiki/Conversion_between_quaternions_and_Euler_angles
public record struct EulerRotation(float Yaw, float Pitch, float Roll)
{
	public float Yaw = Yaw;
	public float Pitch = Pitch;
	public float Roll = Roll;

	// wikipedia
	public static Quaternion ToQuaternionWikipedia(EulerRotation euler)
	{
		// Abbreviations for the various angular functions
		float cy = Cos(euler.Yaw * 0.5f);
		float sy = Sin(euler.Yaw * 0.5f);
		float cp = Cos(euler.Pitch * 0.5f);
		float sp = Sin(euler.Pitch * 0.5f);
		float cr = Cos(euler.Roll * 0.5f);
		float sr = Sin(euler.Roll * 0.5f);

		Quaternion q;
		q.W = cr * cp * cy + sr * sp * sy;
		q.X = sr * cp * cy - cr * sp * sy;
		q.Y = cr * sp * cy + sr * cp * sy;
		q.Z = cr * cp * sy - sr * sp * cy;

		return q;
	}
	public static EulerRotation FromQuaternionWikipedia(Quaternion q)
	{
		EulerRotation euler;

		// roll (x-axis rotation)
		float sinr_cosp = 2 * (q.W * q.X + q.Y * q.Z);
		float cosr_cosp = 1 - 2 * (q.X * q.X + q.Y * q.Y);
		euler.Roll = Atan2(sinr_cosp, cosr_cosp);

		// pitch (y-axis rotation)
		float sinp = 2 * (q.W * q.Y - q.Z * q.X);
		if (Abs(sinp) >= 1)
			euler.Pitch = CopySign(PI / 2, sinp); // use 90 degrees if out of range
		else
			euler.Pitch = Asin(sinp);

		// yaw (z-axis rotation)
		float siny_cosp = 2 * (q.W * q.Z + q.X * q.Y);
		float cosy_cosp = 1 - 2 * (q.Y * q.Y + q.Z * q.Z);
		euler.Yaw = Atan2(siny_cosp, cosy_cosp);

		return euler;
	}

	// dotnet
	public static Quaternion ToQuaternionDotnet(EulerRotation euler)
	{
		//  Roll first, about axis the object is facing, then
		//  pitch upward, then yaw to face into the new heading
		float sr, cr, sp, cp, sy, cy;

		float halfRoll = euler.Roll * 0.5f;
		sr = Sin(halfRoll);
		cr = Cos(halfRoll);

		float halfPitch = euler.Pitch * 0.5f;
		sp = Sin(halfPitch);
		cp = Cos(halfPitch);

		float halfYaw = euler.Yaw * 0.5f;
		sy = Sin(halfYaw);
		cy = Cos(halfYaw);

		Quaternion result;

		result.X = cy * sp * cr + sy * cp * sr;
		result.Y = sy * cp * cr - cy * sp * sr;
		result.Z = cy * cp * sr - sy * sp * cr;
		result.W = cy * cp * cr + sy * sp * sr;

		return result;
	}
	public static EulerRotation FromQuaternionDotnet(Quaternion q)
	{
		throw new NotImplementedException();
	}

	public static implicit operator Quaternion(EulerRotation value)
	{
		return Quaternion.CreateFromYawPitchRoll(value.Yaw, value.Pitch, value.Roll);
	}
};
