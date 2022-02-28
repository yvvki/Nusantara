// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;

namespace Nusantara.Maths;

public record struct EulerRotation(float Yaw, float Pitch, float Roll)
{
	public static implicit operator Quaternion(EulerRotation value)
	{
		return Quaternion.CreateFromYawPitchRoll(value.Yaw, value.Pitch, value.Roll);
	}
};
