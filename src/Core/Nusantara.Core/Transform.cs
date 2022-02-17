using System.Numerics;

namespace Nusantara.Core;

public record struct Transform(Vector4 Translation, Quaternion Rotation, Vector4 Scale) : ITransformable
{
	public Transform(ITransformable Transformable)
		: this(
			Transformable.Translation,
			Transformable.Rotation,
			Transformable.Scale)
	{ }
};
