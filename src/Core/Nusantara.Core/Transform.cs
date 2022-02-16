using System.Numerics;

namespace Nusantara.Core;

public record struct Transform(Vector3 Translation, Quaternion Rotation, Vector3 Scale) : ITransformable
{
	public Transform(ITransformable Transformable)
		: this(
			Transformable.Translation,
			Transformable.Rotation,
			Transformable.Scale)
	{ }
};
