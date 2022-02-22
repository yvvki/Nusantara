// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;

namespace Nusantara;

public static class Transformable
{
	public static void Combine(this ITransformable @this, ITransformable transformable)
	{
		@this.Translation = Vector4.Add(@this.Translation, transformable.Translation);
		@this.Rotation = Quaternion.Add(@this.Rotation, transformable.Rotation);
		@this.Scale = Vector4.Multiply(@this.Scale, transformable.Scale);
	}

	public static Matrix4x4 GetMatrix(this ITransformable @this)
	{
		return ITransformable.GetMatrix(@this);
	}
}
