// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;
using System.Runtime.CompilerServices;

namespace Nusantara;

public record struct Transform(Vector3 Translation, Quaternion Rotation, Vector3 Scale) : ITransformable
{
	public static Transform Identity => new();

	public Transform()
		: this(
			Vector3.Zero,
			Quaternion.Identity,
			Vector3.One)
	{ }

	public Transform(Vector3? Translation = null, Quaternion? Rotation = null, Vector3? Scale = null)
		: this(
			Translation ?? Vector3.Zero,
			Rotation ?? Quaternion.Identity,
			Scale ?? Vector3.One)
	{ }

	public Transform(ITransformable Transformable)
		: this(
			Transformable.Translation,
			Transformable.Rotation,
			Transformable.Scale)
	{ }

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Transform Negate(Transform value)
	{
		Transform result = value;
		TransformableExtensions.Negate(ref result);
		return result;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Transform Concatenate(Transform left, Transform right)
	{
		Transform result = left;
		TransformableExtensions.Concatenate(ref result, right);
		return result;
	}

	//[MethodImpl(MethodImplOptions.AggressiveInlining)]
	//public static Transform operator -(Transform value)
	//{
	//	return Negate(value);
	//}

	//[MethodImpl(MethodImplOptions.AggressiveInlining)]
	//public static Transform operator +(Transform left, Transform right)
	//{
	//	return Concatenate(left, right);
	//}

	//[MethodImpl(MethodImplOptions.AggressiveInlining)]
	//public static Transform operator -(Transform left, Transform right)
	//{
	//	return left + (-right);
	//}
};
