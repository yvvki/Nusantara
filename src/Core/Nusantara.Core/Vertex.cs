// <https://github.com/yvvki> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;

namespace Nusantara;

public readonly record struct Vertex(Vector3 Position, Vector3 Normal, Vector2 UV) :
	IEquatable<Vertex>
{
	public readonly Vector3 Position = Position;
	public readonly Vector3 Normal = Normal;
	public readonly Vector2 UV = UV;
};
