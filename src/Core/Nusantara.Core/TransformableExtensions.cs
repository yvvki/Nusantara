// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;
using System.Runtime.CompilerServices;

using Nusantara.Maths;

namespace Nusantara;

public static class TransformableExtensions
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Negate<T>(this T transformable)
		where T : class, ITransformable
	{
		Transform result = new(transformable);
		result = Transform.Negate(result);

		transformable.Translation = result.Translation;
		transformable.Rotation = result.Rotation;
		transformable.Scale = result.Scale;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Concatenate<T>(this T transformable, Transform other)
		where T : class, ITransformable
	{
		Transform result = new(transformable);
		result = Transform.Concatenate(result, other);

		transformable.Translation = result.Translation;
		transformable.Rotation = result.Rotation;
		transformable.Scale = result.Scale;
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
