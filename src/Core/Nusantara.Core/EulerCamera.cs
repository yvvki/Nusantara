// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;

using Nusantara.Maths;

namespace Nusantara;

public class EulerCamera : ICamera, ITransformable
{
	public EulerCamera(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance)
	{
		_fieldOfView = fieldOfView;
		_aspectRatio = aspectRatio;
		_nearPlaneDistance = nearPlaneDistance;
		_farPlaneDistance = farPlaneDistance;

		_projection = CalculateProjection();
	}

	public Vector4 Position { get; set; }
	Vector4 ITransformable.Translation { get => Position; set => Position = value; }
	public Quaternion Rotation => Quaternion.CreateFromYawPitchRoll(Yaw, Pitch, Roll);
	Quaternion ITransformable.Rotation
	{
		get => Rotation;
		set
		{
			(float yaw, float pitch, float roll) = MathHelper.ToEulerAngles(value);
			Yaw = yaw;
			Pitch = pitch;
			Roll = roll;
		}
	}
	Vector4 ITransformable.Scale { get; set; } // Unused.

	public float Yaw { get; set; }
	public float Pitch { get; set; }
	public float Roll { get; set; }

	public (float Yaw, float Pitch, float Roll) YawPitchRoll { get => (Yaw, Pitch, Roll); set => (Yaw, Pitch, Roll) = value; }


	// Facing down.
	public Vector4 Right => Vector4.Transform(Directions.Right, Rotation);
	public Vector4 Forward => Vector4.Transform(-Directions.Up, Rotation);
	public Vector4 Up => Vector4.Transform(Directions.Forward, Rotation);

	public Vector4 Target => Position + Forward;

	private float _fieldOfView;
	public float FieldOfView
	{
		get => _fieldOfView;
		set
		{
			_fieldOfView = value;
			_projectionNeedCalculating = true;
		}
	}

	private float _aspectRatio;
	public float AspectRatio
	{
		get => _aspectRatio;
		set
		{
			_aspectRatio = value;
			_projectionNeedCalculating = true;
		}
	}

	private float _nearPlaneDistance;
	public float NearPlaneDistance
	{
		get => _nearPlaneDistance;
		set
		{
			_nearPlaneDistance = value;
			_projectionNeedCalculating = true;
		}
	}

	private float _farPlaneDistance;
	public float FarPlaneDistance
	{
		get => _farPlaneDistance;
		set
		{
			_farPlaneDistance = value;
			_projectionNeedCalculating = true;
		}
	}

	protected Matrix4x4 CalculateProjection()
	{
		return Matrix4x4.CreatePerspectiveFieldOfView(
			_fieldOfView,
			_aspectRatio,
			_nearPlaneDistance,
			_farPlaneDistance);
	}

	public Matrix4x4 GetView()
	{
		return Matrix4x4.CreateLookAt(
			MathHelper.NormalizeHomogenous(Position),
			MathHelper.NormalizeHomogenous(Target),
			MathHelper.NormalizeHomogenous(Up));
	}

	private bool _projectionNeedCalculating;
	private Matrix4x4 _projection;

	public Matrix4x4 GetProjection()
	{
		if (_projectionNeedCalculating)
		{
			_projection = CalculateProjection();
			_projectionNeedCalculating = false;
		}

		return _projection;
	}
}
