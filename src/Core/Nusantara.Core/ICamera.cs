// <https://github.com/yvvki> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;

namespace Nusantara;

public interface ICamera
{
	Matrix4x4 GetView();

	Matrix4x4 GetProjection();
}
