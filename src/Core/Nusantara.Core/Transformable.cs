// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;
using System.Runtime.CompilerServices;

using Nusantara.Maths;

namespace Nusantara;

public static class Transformable
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Negate(this ITransformable @this)
	{
		@this.Translation = CalculateTranslation(@this.Translation);
		@this.Rotation = Quaternion.Negate(@this.Rotation);
		@this.Scale = Vector4.Divide(Vector4.One, @this.Scale);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static Vector4 CalculateTranslation(Vector4 value)
		{
			Vector4 result = value;
			Vector3 vector = Unsafe.As<Vector4, Vector3>(ref result);

			vector = Vector3.Negate(vector);
			result.XYZ(vector);

			return result;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Combine(this ITransformable @this, ITransformable other)
	{
		@this.Translation = Vector4.Add(@this.Translation, other.Translation);
		@this.Rotation = Quaternion.Add(@this.Rotation, other.Rotation);
		@this.Scale = Vector4.Multiply(@this.Scale, other.Scale);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Transform GetTransform(this ITransformable @this)
	{
		return new(@this);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void SetTransform(this ITransformable @this, Transform transform)
	{
		@this.Translation = transform.Translation;
		@this.Rotation = transform.Rotation;
		@this.Scale = transform.Scale;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Matrix4x4 GetMatrix(this ITransformable @this)
	{
		return MathHelper.CreateTransformMatrix(@this.Translation, @this.Rotation, @this.Scale);
	}
}
