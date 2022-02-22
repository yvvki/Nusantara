// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;

using Nusantara.Maths;

namespace Nusantara;

public interface ITransformable
{
	Vector4 Translation { get; set; }
	Quaternion Rotation { get; set; }
	Vector4 Scale { get; set; }

	static Matrix4x4 GetMatrix(ITransformable transformable)
	{
		// Scaling
		Matrix4x4 matrix = Matrix4x4.CreateScale(MathHelper.NormalizeHomogenous(transformable.Scale));
		// Rotating
		matrix = Matrix4x4.Transform(matrix, transformable.Rotation);
		// Translating
		matrix.Translation = MathHelper.NormalizeHomogenous(transformable.Translation);

		return matrix;
	}
}
