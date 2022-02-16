using System.Numerics;

namespace Nusantara.Core;

public interface ITransformable
{
	Vector3 Translation { get; set; }
	Quaternion Rotation { get; set; }
	Vector3 Scale { get; set; }

	Vector3 Right => Directions.Right;
	Vector3 Forward => Directions.Forward;
	Vector3 Up => Directions.Up;
}
