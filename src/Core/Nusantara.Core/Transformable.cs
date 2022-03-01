// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;
using System.Runtime.CompilerServices;

using Nusantara.Maths;

namespace Nusantara;

public static class Transformable
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Normalize<T>(ref T transformable)
		where T : ITransformable
	{
		transformable.Translation = Vector4.Divide(transformable.Translation, transformable.Translation.W);
		transformable.Rotation = Quaternion.Normalize(transformable.Rotation);
		transformable.Scale = Vector4.Divide(transformable.Scale, transformable.Scale.W);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Negate<T>(ref T transformable)
		where T : ITransformable
	{
		transformable.Translation = MathHelper.NegateHomogeneous(transformable.Translation);
		transformable.Rotation = Quaternion.Inverse(transformable.Rotation);
		transformable.Scale = Vector4.Divide(Vector4.One, transformable.Scale);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Concatenate<T>(ref T transformable, ITransformable other)
		where T : ITransformable
	{
		transformable.Translation = MathHelper.AddHomogeneous(transformable.Translation, other.Translation);
		transformable.Rotation = Quaternion.Concatenate(transformable.Rotation, other.Rotation);
		transformable.Scale = Vector4.Multiply(transformable.Scale, other.Scale);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Matrix4x4 CreateMatrix(ITransformable transformable)
	{
		return MathHelper.CreateTransform(
			transformable.Translation,
			transformable.Rotation,
			transformable.Scale);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Matrix4x4 GetMatrix(this ITransformable @this)
	{
		return CreateMatrix(@this);
	}
}
