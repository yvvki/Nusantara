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

	// I am very smart yes.
	public static EulerRotation CreateFromQuaternion(Quaternion q)
	{
		EulerRotation euler;

		// Yaw (y-axis rotation)
		float siny_cosp = 2 * (q.W * q.Y + q.X * q.Z);
		float cosy_cosp = 1 - 2 * (q.Y * q.Y + q.X * q.X);
		euler.Yaw = Atan2(siny_cosp, cosy_cosp);

		// Pitch (x-axis rotation)
		float sinp = 2 * (q.W * q.X - q.Z * q.Y);
		euler.Pitch = (Abs(sinp) >= 1) ? CopySign(PI / 2, sinp) : Asin(sinp);

		// Roll (z-axis rotation)
		float sinr_cosp = 2 * (q.W * q.Z + q.X * q.Y);
		float cosr_cosp = 1 - 2 * (q.Z * q.Z + q.X * q.X);
		euler.Roll = Atan2(sinr_cosp, cosr_cosp);

		return euler;
	}

	public static explicit operator Quaternion(EulerRotation value)
	{
		return Quaternion.CreateFromYawPitchRoll(value.Yaw, value.Pitch, value.Roll);
	}
	public static explicit operator EulerRotation(Quaternion value)
	{
		return CreateFromQuaternion(value);
	}
};
