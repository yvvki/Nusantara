// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;
using System.Runtime.CompilerServices;

using Nusantara.Maths;

namespace Nusantara;

public static class TransformableExtensions
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T WithTransform<T>(this T transformable, Transform transform)
		where T : ITransformable
	{
		T result = transformable;

		result.Translation = transform.Translation;
		result.Rotation = transform.Rotation;
		result.Scale = transform.Scale;

		return result;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Negate<T>(this T transformable)
		where T : ITransformable
	{
		Transform transform = new(transformable);
		transform = Transform.Negate(transform);

		T result = transformable.WithTransform(transform);

		return result;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Concatenate<T>(this T transformable, Transform other)
		where T : ITransformable
	{
		Transform transform = new(transformable);
		transform = Transform.Concatenate(transform, other);

		T result = transformable.WithTransform(transform);

		return result;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Matrix4x4 GetMatrix<T>(this T transformable)
		where T : ITransformable
	{
		return MathHelper.CreateTransform(
			transformable.Translation,
			transformable.Rotation,
			transformable.Scale);
	}
}
