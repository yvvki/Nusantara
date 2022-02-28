// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;

namespace Nusantara;

public interface ITransformable
{
	Vector4 Translation { get; set; }
	Quaternion Rotation { get; set; }
	Vector4 Scale { get; set; }
}
