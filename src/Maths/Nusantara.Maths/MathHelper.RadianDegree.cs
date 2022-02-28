// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Runtime.CompilerServices;

namespace Nusantara.Maths;

public static partial class MathHelper
{
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
}
