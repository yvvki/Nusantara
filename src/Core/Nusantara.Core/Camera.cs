// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;

using Nusantara.Maths;

namespace Nusantara;

public sealed class Camera : ICamera, ITransformable
{
	public Camera(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance)
	{
		_fieldOfView = fieldOfView;
		_aspectRatio = aspectRatio;
		_nearPlaneDistance = nearPlaneDistance;
		_farPlaneDistance = farPlaneDistance;

		_projection = CalculateProjection();
	}

	public Vector4 Position { get; set; }
	Vector4 ITransformable.Translation { get => Position; set => Position = value; }
	public Quaternion Rotation { get; set; }
	Vector4 ITransformable.Scale { get; set; } // Unused.

	// Facing down.
	public Vector3 Right => Vector3.Transform(Directions.Right, Rotation);
	public Vector3 Forward => Vector3.Transform(-Directions.Up, Rotation);
	public Vector3 Up => Vector3.Transform(Directions.Forward, Rotation);

	public Vector4 Target => Position + new Vector4(Forward, 0);

	// Automatically throws.
	private float _fieldOfView;
	public float FieldOfView
	{
		get => _fieldOfView;
		set
		{
			_fieldOfView = value;
			_projection = CalculateProjection();
		}
	}

	private float _aspectRatio;
	public float AspectRatio
	{
		get => _aspectRatio;
		set
		{
			_aspectRatio = value;
			_projection = CalculateProjection();
		}
	}

	private float _nearPlaneDistance;
	public float NearPlaneDistance
	{
		get => _nearPlaneDistance;
		set
		{
			_nearPlaneDistance = value;
			_projection = CalculateProjection();
		}
	}

	private float _farPlaneDistance;
	public float FarPlaneDistance
	{
		get => _farPlaneDistance;
		set
		{
			_farPlaneDistance = value;
			_projection = CalculateProjection();
		}
	}

	public Matrix4x4 GetView()
	{
		return Matrix4x4.CreateLookAt(
			MathHelper.NormalizeHomogeneous(Position),
			MathHelper.NormalizeHomogeneous(Target),
			Up);
	}

	private Matrix4x4 CalculateProjection()
	{
		return Matrix4x4.CreatePerspectiveFieldOfView(
			FieldOfView,
			AspectRatio,
			NearPlaneDistance,
			FarPlaneDistance);
	}

	private Matrix4x4 _projection;
	public Matrix4x4 GetProjection()
	{
		return _projection;
	}
}
