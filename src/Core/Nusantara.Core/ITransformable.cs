// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;

namespace Nusantara;

public interface ITransformable
{
	Vector3 Translation { get; set; }
	Quaternion Rotation { get; set; }
	Vector3 Scale { get; set; }

	Vector3 Right
		=> Vector3.Transform(Directions.Right, Rotation);
	Vector3 Forward
		=> Vector3.Transform(Directions.Forward, Rotation);
	Vector3 Up
		=> Vector3.Transform(Directions.Up, Rotation);
}
