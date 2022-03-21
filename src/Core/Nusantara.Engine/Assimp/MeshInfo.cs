// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;

namespace Nusantara.Engine.Assimp;

public record MeshInfo(Vertex[] Vertices, uint[] Indices, Vector2[] UVs);
