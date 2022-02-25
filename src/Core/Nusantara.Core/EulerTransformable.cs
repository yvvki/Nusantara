// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;

namespace Nusantara;

public sealed class EulerTransformable
{
	public ITransformable Transformable { get; }

	public EulerTransformable(ITransformable transformable)
	{
		Transformable = transformable;
	}

	private float _yaw;
	public float Yaw
	{
		get => _yaw;
		set
		{
			_yaw = value;
			UpdateRotation();
		}
	}

	private float _pitch;
	public float Pitch
	{
		get => _pitch;
		set
		{
			_pitch = value;
			UpdateRotation();
		}
	}

	private float _roll;
	public float Roll
	{
		get => _roll;
		set
		{
			_roll = value;
			UpdateRotation();
		}
	}

	private void UpdateRotation()
	{
		Transformable.Rotation = Quaternion.CreateFromYawPitchRoll(Yaw, Pitch, Roll);
	}
}
