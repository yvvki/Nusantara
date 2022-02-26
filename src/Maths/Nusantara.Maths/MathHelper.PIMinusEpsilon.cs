// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

namespace Nusantara.Maths;

public static partial class MathHelper
{
	/// <summary>
	///   Represents the smallest difference value that is less than PI.
	/// </summary>
	/*
	 * Subtracting with float.Epsilon is impossible due to single floating point imprecision.
	 * The bits on MathF.PI is: 1000000010010010000111111011011,
	 * while this constant is:  1000000010010010000111111011010
	 */
	public const float PIMinusEpsilon = MathF.PI - 0.000000119209286f;
}
