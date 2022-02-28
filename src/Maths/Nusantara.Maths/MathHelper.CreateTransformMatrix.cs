// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;
using System.Runtime.CompilerServices;

namespace Nusantara.Maths;

public static partial class MathHelper
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Matrix4x4 CreateTransformMatrix(Vector3 translation, Quaternion rotation, Vector3 scale)
	{
		// Scaling
		Matrix4x4 matrix = Matrix4x4.CreateScale(scale);
		// Rotating
		matrix = Matrix4x4.Transform(matrix, rotation);
		// Translating
		matrix.Translation = translation;

		return matrix;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Matrix4x4 CreateTransformMatrix(Vector4 translation, Quaternion rotation, Vector4 scale)
	{
		Matrix4x4 matrix = CreateTransformMatrix(
			NormalizeHomogenous(translation),
			rotation,
			NormalizeHomogenous(scale));

		return matrix;
	}
}
