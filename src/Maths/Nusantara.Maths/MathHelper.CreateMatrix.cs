// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;

namespace Nusantara.Maths;

public static partial class MathHelper
{
	public static Matrix4x4 CreateMatrix(Vector4 translation, Quaternion rotation, Vector4 scale)
	{
		// Scaling
		Matrix4x4 matrix = Matrix4x4.CreateScale(NormalizeHomogenous(scale));
		// Rotating
		matrix = Matrix4x4.Transform(matrix, rotation);
		// Translating
		matrix.Translation = NormalizeHomogenous(translation);

		return matrix;
	}
}
