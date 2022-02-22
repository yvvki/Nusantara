// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;

namespace Nusantara;

public record struct Transform(Vector4 Translation, Quaternion Rotation, Vector4 Scale) : ITransformable
{
	public Transform()
		: this(
			Vector4.UnitW,
			Quaternion.Identity,
			Vector4.One)
	{ }

	public Transform(Vector4? Translation = null, Quaternion? Rotation = null, Vector4? Scale = null)
		: this(
			Translation ?? Vector4.UnitW,
			Rotation ?? Quaternion.Identity,
			Scale ?? Vector4.One)
	{ }

	public Transform(ITransformable Transformable)
		: this(
			Transformable.Translation,
			Transformable.Rotation,
			Transformable.Scale)
	{ }

	//public static Transform Negate(Transform value)
	//{
	//	Transform result = new(
	//		Vector4.Negate(value.Translation),
	//		Quaternion.Negate(value.Rotation),
	//		Vector4.Divide(Vector4.One, value.Scale));

	//	return result;
	//}

	public static Transform Combine(Transform left, Transform right)
	{
		Transform result = left;
		result.Combine(right);
		return result;
	}

	//public static Transform operator -(Transform value)
	//{
	//	return Negate(value);
	//}

	public static Transform operator +(Transform left, Transform right)
	{
		return Combine(left, right);
	}

	//public static Transform operator -(Transform left, Transform right)
	//{
	//	return left + (-right);
	//}
};
