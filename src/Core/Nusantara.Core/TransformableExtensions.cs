// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;
using System.Runtime.CompilerServices;

using Nusantara.Maths;

namespace Nusantara;

public static class TransformableExtensions
{
	// Returns the @this argument for dealing with struct types.

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T SetTransform<T>(this T @this, Transform transform)
		where T : ITransformable
	{
		T result = @this;

		result.Translation = transform.Translation;
		result.Rotation = transform.Rotation;
		result.Scale = transform.Scale;

		return result;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Negate<T>(this T @this)
		where T : ITransformable
	{
		Transform transform = new(@this);
		transform = Transform.Negate(transform);

		T result = @this.SetTransform(transform);

		return result;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Concatenate<T>(this T @this, Transform other)
		where T : ITransformable
	{
		Transform transform = new(@this);
		transform = Transform.Concatenate(transform, other);

		T result = @this.SetTransform(transform);

		return result;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Matrix4x4 GetMatrix<T>(this T @this)
		where T : ITransformable
	{
		return MathHelper.CreateTransform(
			@this.Translation,
			@this.Rotation,
			@this.Scale);
	}
}
