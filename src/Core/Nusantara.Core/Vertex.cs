using System.Numerics;

namespace Nusantara.Core;

public record struct Vertex(Vector4 Position, Vector4 Normal, Vector2 UV)
{
	public Vertex(Vector3 Position, Vector3 Normal, Vector2 UV)
		: this(
			new Vector4(Position, 1),
			new Vector4(Normal, 1),
			UV)
	{ }
};
