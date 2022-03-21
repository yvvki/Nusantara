// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

namespace Nusantara.Engine.Assimp;

public enum TextureType
{
	Diffuse = 1,
	Specular,
	Ambient,
	Emissive,
	Height,
	Normals,
	Shininess,
	Opacity,
	Displacement,
	Lightmap,
	Reflection,
	BaseColor,
	NormalCamera,
	EmissionColor,
	Metalness,
	DiffuseRoughness,
	AmbientOcclusion
}

public record TextureInfo(TextureType Type, string Path);
