// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;
using System.Runtime.CompilerServices;

namespace Nusantara;

public record struct Transform(Vector3 Translation, Quaternion Rotation, Vector3 Scale) : ITransformable
{
	public Vector3 Translation = Translation;
	public Quaternion Rotation = Rotation;
	public Vector3 Scale = Scale;

	Vector3 ITransformable.Translation { get => Translation; set => Translation = value; }
	Quaternion ITransformable.Rotation { get => Rotation; set => Rotation = value; }
	Vector3 ITransformable.Scale { get => Scale; set => Scale = value; }

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
		Transform result;

		result.Translation = Vector3.Negate(value.Translation);
		result.Rotation = Quaternion.Inverse(value.Rotation);
		result.Scale = Vector3.Divide(Vector3.One, value.Scale);

		return result;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Transform Concatenate(Transform value1, Transform value2)
	{
		Transform result;

		result.Translation = Vector3.Add(value1.Translation, value2.Translation);
		result.Rotation = Quaternion.Concatenate(value1.Rotation, value2.Rotation);
		result.Scale = Vector3.Multiply(value1.Scale, value2.Scale);

		return result;
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
