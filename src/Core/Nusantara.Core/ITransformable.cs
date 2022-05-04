// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;

namespace Nusantara;

public interface ITransformable
{
	Transform Transform { get; set; }

	Vector3 Translation
	{
		get => Transform.Translation;
		set => Transform = Transform with { Translation = value };
	}
	Quaternion Rotation
	{
		get => Transform.Rotation;
		set => Transform = Transform with { Rotation = value };
	}
	Vector3 Scale
	{
		get => Transform.Scale;
		set => Transform = Transform with { Scale = value };
	}

	Vector3 Right
		=> Vector3.Transform(Directions.Right, Rotation);
	Vector3 Forward
		=> Vector3.Transform(Directions.Forward, Rotation);
	Vector3 Up
		=> Vector3.Transform(Directions.Up, Rotation);
}
