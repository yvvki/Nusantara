// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;

namespace Nusantara;

public record struct Vertex(Vector4 Position, Vector4 Normal, Vector2 UV)
{
	public Vertex(Vector3 Position, Vector3 Normal, Vector2 UV)
		: this(
			new Vector4(Position, 1),
			new Vector4(Normal, 1),
			UV)
	{ }
};
