// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;
using System.Runtime.CompilerServices;

namespace Nusantara;

public interface ICamera
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	Matrix4x4 GetView();

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	Matrix4x4 GetProjection();
}
