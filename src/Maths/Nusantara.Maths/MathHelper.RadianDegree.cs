namespace Nusantara.Maths;

public static partial class MathHelper
{
	public static float DegreesToRadians(float degrees)
	{
		const float constant = MathF.PI / 180.0f;
		return degrees * constant;
	}

	public static float RadiansToDegree(float radians)
	{
		const float constant = 180.0f / MathF.PI;
		return radians * constant;
	}

	public static double DegreesToRadians(double degrees)
	{
		const double constant = Math.PI / 180.0;
		return degrees * constant;
	}

	public static double RadiansToDegree(double radians)
	{
		const double constant = 180.0 / Math.PI;
		return radians * constant;
	}
}
