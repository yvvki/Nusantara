// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;
using System.Runtime.CompilerServices;

using Nusantara.Maths;

namespace Nusantara;

public record struct Transform(Vector4 Translation, Quaternion Rotation, Vector4 Scale) : ITransformable
{
	public static Transform Identity => new();

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

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Transform Normalize(Transform value)
	{
		Transform result = value;
		Transformable.Normalize(ref result);
		return result;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Transform Negate(Transform value)
	{
		Transform result = value;
		Transformable.Negate(ref result);
		return result;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Transform Concatenate(Transform left, Transform right)
	{
		Transform result = left;
		Transformable.Concatenate(ref result, right);
		return result;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Transform operator +(Transform value)
	{
		return Normalize(value);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Transform operator -(Transform value)
	{
		return Negate(value);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Transform operator +(Transform left, Transform right)
	{
		return Concatenate(left, right);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Transform operator -(Transform left, Transform right)
	{
		return left + (-right);
	}
};
