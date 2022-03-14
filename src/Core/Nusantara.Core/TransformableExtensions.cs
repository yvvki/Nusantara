// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;
using System.Runtime.CompilerServices;

using Nusantara.Maths;

namespace Nusantara;

public static class TransformableExtensions
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Negate<T>(this ref T transformable)
		where T : struct, ITransformable
	{
		transformable.Translation = Vector3.Negate(transformable.Translation);
		transformable.Rotation = Quaternion.Inverse(transformable.Rotation);
		transformable.Scale = Vector3.Divide(Vector3.One, transformable.Scale);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Concatenate<T>(this ref T @this, ITransformable other)
		where T : struct, ITransformable
	{
		@this.Translation = Vector3.Add(@this.Translation, other.Translation);
		@this.Rotation = Quaternion.Concatenate(@this.Rotation, other.Rotation);
		@this.Scale = Vector3.Multiply(@this.Scale, other.Scale);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Matrix4x4 GetMatrix(this ITransformable transformable)
	{
		return MathHelper.CreateTransform(
			transformable.Translation,
			transformable.Rotation,
			transformable.Scale);
	}
}
