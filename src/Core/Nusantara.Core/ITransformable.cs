using System.Numerics;

namespace Nusantara.Core;

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
		Matrix4x4 matrix = Matrix4x4.Identity;

		Vector4 scale = Scale;
		Vector3 scale_normalized = new(
			scale.X / scale.W,
			scale.Y / scale.W,
			scale.Z / scale.W);

		Vector4 translation = Translation;
		Vector3 translation_normalized = new(
			translation.X / translation.W,
			translation.Y / translation.W,
			translation.Z / translation.W);

		matrix *= Matrix4x4.CreateScale(scale_normalized);
		Matrix4x4.Transform(matrix, Rotation);
		matrix.Translation = translation_normalized;

		return matrix;
	}
}
