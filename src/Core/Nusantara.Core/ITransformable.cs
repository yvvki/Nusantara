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

	Vector3 Right => Directions.Right;
	Vector3 Forward => Directions.Forward;
	Vector3 Up => Directions.Up;

	void Combine(ITransformable transformable)
	{
		Translation = Vector4.Add(Translation, transformable.Translation);
		Rotation = Quaternion.Add(Rotation, transformable.Rotation);
		Scale *= Vector4.Multiply(Scale, transformable.Scale);
	}

	Matrix4x4 GetMatrix()
	{
		// Scaling
		Matrix4x4 matrix = Matrix4x4.CreateScale(MathHelper.NormalizeHomogenous(Scale));
		// Rotating
		matrix = Matrix4x4.Transform(matrix, Rotation);
		// Translating
		matrix.Translation = MathHelper.NormalizeHomogenous(Translation);

		return matrix;
	}
}
