// <https://github.com/yvvki> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

using Nusantara.Maths;

namespace Nusantara;

public struct Transform :
	ITransformable,

	IEquatable<Transform>
{
	public Transform(Vector3 translation, Quaternion rotation, Vector3 scale)
	{
		Translation = translation;
		Rotation = rotation;
		Scale = scale;
	}

	public Transform(Vector3? translation = null, Quaternion? rotation = null, Vector3? scale = null)
	{
		Translation = translation ?? Vector3.Zero;
		Rotation = rotation ?? Quaternion.Identity;
		Scale = scale ?? Vector3.One;
	}

	public Transform()
	{
		Translation = Vector3.Zero;
		Rotation = Quaternion.Identity;
		Scale = Vector3.One;
	}

	public Transform(ITransformable transformable)
	{
		this = transformable.Transform;
	}

	public Vector3 Translation;
	public Quaternion Rotation;
	public Vector3 Scale;

	Transform ITransformable.Transform { get => this; set => this = value; }

	Vector3 ITransformable.Translation { get => Translation; set => Translation = value; }
	Quaternion ITransformable.Rotation { get => Rotation; set => Rotation = value; }
	Vector3 ITransformable.Scale { get => Scale; set => Scale = value; }

	public static Transform Identity => new();

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

	public static Transform Lerp(Transform value1, Transform value2, float amount)
	{
		Transform result;

		result.Translation = Vector3.Lerp(value1.Translation, value2.Translation, amount);
		result.Rotation = Quaternion.Lerp(value1.Rotation, value2.Rotation, amount);
		result.Scale = Vector3.Lerp(value1.Scale, value2.Scale, amount);

		return result;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Matrix4x4 GetMatrix()
	{
		return MathHelper.CreateTransform(
			Translation,
			Rotation,
			Scale);
	}

	public override string ToString()
	{
		StringBuilder sb = new();
		sb.Append('{');
		sb.Append(Translation);
		sb.Append(' ');
		sb.Append(Rotation);
		sb.Append(' ');
		sb.Append(Scale);
		sb.Append('}');
		return sb.ToString();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(Transform other)
	{
		return Translation.Equals(other.Translation)
			&& Rotation.Equals(other.Rotation)
			&& Scale.Equals(other.Scale);
	}
	public override bool Equals([NotNullWhen(true)] object? obj)
	{
		return obj is Transform other && Equals(other);
	}
	public override int GetHashCode()
	{
		return HashCode.Combine(Translation, Rotation, Scale);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator ==(Transform left, Transform right)
	{
		return left.Translation == right.Translation
			&& left.Rotation == right.Rotation
			&& left.Scale == right.Scale;
	}
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator !=(Transform left, Transform right)
	{
		return left.Translation != right.Translation
			|| left.Rotation != right.Rotation
			|| left.Scale != right.Scale;
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
}