// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;

namespace Nusantara;

public record struct Transform(Vector4 Translation, Quaternion Rotation, Vector4 Scale) : ITransformable
{
	public Transform(ITransformable Transformable)
		: this(
			Transformable.Translation,
			Transformable.Rotation,
			Transformable.Scale)
	{ }
};
