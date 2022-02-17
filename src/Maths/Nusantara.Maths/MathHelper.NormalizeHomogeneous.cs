using System.Numerics;
using System.Runtime.CompilerServices;

using Silk.NET.Maths;

namespace Nusantara.Maths;

public static partial class MathHelper
{
	public static Vector3D<T> NormalizeHomogenous<T>(Vector4D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		Vector3D<T> result = Unsafe.As<Vector4D<T>, Vector3D<T>>(ref value);
		result = Vector3D.Divide(result, value.W);

		return result;
	}

	public static Vector3 NormalizeHomogenous(Vector4 value)
	{
		Vector3 result = Unsafe.As<Vector4, Vector3>(ref value);
		result = Vector3.Divide(result, value.W);

		return result;
	}

	public static Vector2D<T> NormalizeHomogenous<T>(Vector3D<T> value)
		where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
	{
		Vector2D<T> result = Unsafe.As<Vector3D<T>, Vector2D<T>>(ref value);
		result = Vector2D.Divide(result, value.Z);

		return result;
	}

	public static Vector2 NormalizeHomogenous(Vector3 value)
	{
		Vector2 result = Unsafe.As<Vector3, Vector2>(ref value);
		result = Vector2.Divide(result, value.Z);

		return result;
	}
}
