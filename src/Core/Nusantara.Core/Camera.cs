﻿// <https://github.com/yvvki> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;
using System.Runtime.CompilerServices;

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

	private Transform _transform = new();
	Transform ITransformable.Transform { get => _transform; set => _transform = value; }

	public Vector3 Position { get => _transform.Translation; set => _transform.Translation = value; }
	Vector3 ITransformable.Translation { get => Position; set => Position = value; }
	public Quaternion Rotation { get => _transform.Rotation; set => _transform.Rotation = value; }
	Vector3 ITransformable.Scale { get => _transform.Scale; set => _transform.Scale = value; }

	// Facing down.
	public Vector3 Right => Vector3.Transform(Directions.Right, Rotation);
	public Vector3 Forward => Vector3.Transform(-Directions.Up, Rotation);
	public Vector3 Up => Vector3.Transform(Directions.Forward, Rotation);

	public Vector3 Target => Position + Forward;

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
			Position,
			Target,
			Up);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
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
