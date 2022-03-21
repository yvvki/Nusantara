// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;

using Nusantara.Maths;

using ai = Silk.NET.Assimp;

using GL = Silk.NET.OpenGL.GL;

namespace Nusantara.Engine.Assimp;

public class Model
{
	public List<OpenGL.Mesh> Meshes { get; } = new();
	public List<Nusantara.OpenGL.Skia.SKTexture> Textures { get; } = new();

	public static unsafe void FromFile(GL gl, ai::Assimp ai, string filename)
	{
		ai::Scene* scene = ai.ImportFile(filename, (uint)(ai::PostProcessSteps.Triangulate | ai::PostProcessSteps.FlipUVs));

		if (scene is null || (scene->MFlags & (uint)ai::SceneFlags.Incomplete) is not 0 || scene->MRootNode is null)
		{
			throw new InvalidOperationException();
		}

		Model model = new();

		Process();

		void Process()
		{
			ai::Node* node = scene->MRootNode;

			// For each mesh in node.
			for (uint i = 0; i < node->MNumMeshes; i++)
			{
				ai::Mesh* mesh = scene->MMeshes[node->MMeshes[i]];

				model.Meshes.Add(ProcessMesh(mesh));
			}

			// Convert Assimp's mesh to our mesh.
			Mesh ProcessMesh(ai::Mesh* mesh)
			{
				List<Vertex> vertices = new();
				List<uint> indices = new();

				// For each vertex data in mesh.
				for (uint i = 0; i < mesh->MNumVertices; i++)
				{
					Vector3 Position = mesh->MVertices[i];
					Vector3 Normal = mesh->MNormals[i];

					// Only gets the first element of the coordinates.
					Vector3* uv = mesh->MTextureCoords[0];
					Vector2 UV = uv is not null ? MathHelper.NormalizeHomogeneous(uv[i]) : default;

					vertices.Add(new(Position, Normal, UV));
				}

				// For each face in mesh.
				for (uint i = 0; i < mesh->MNumFaces; i++)
				{
					ai::Face face = mesh->MFaces[i];

					// For each indice in the face.
					for (uint j = 0; j < face.MNumIndices; j++)
					{
						indices.Add(face.MIndices[j]);
					}
				}

				return new(gl, vertices.ToArray(), indices.ToArray());
			}

			TextureInfo[] ProcessTexture(ai::Material* mat, ai::TextureType type)
			{
				uint count = ai.GetMaterialTextureCount(mat, type);

				TextureInfo[] textures = new TextureInfo[count];

				for (uint i = 0; i < count; i++)
				{
					ai::AssimpString path;
					//TextureMapping mapping;
					//uint uvindex;
					//float blend;
					//TextureOp op;
					//TextureMapMode mapmode;

					//uint flags = (uint)TextureFlags.TextureFlagsUseAlpha;

					ai.GetMaterialTexture(
						mat,
						type,
						i,
						&path,
						/*&mapping*/ null,
						/*&uvindex*/ null,
						/*&blend*/ null,
						/*&op*/ null,
						/*&mapmode*/ null,
						/*&flags*/ null);

					textures[i] = new(FromAssimp(type), path);
				}

				TextureType FromAssimp(ai::TextureType type)
				{
					return type switch
					{
						ai::TextureType.TextureTypeNone => default,
						ai::TextureType.TextureTypeDiffuse => TextureType.Diffuse,
						ai::TextureType.TextureTypeSpecular => TextureType.Specular,
						ai::TextureType.TextureTypeAmbient => TextureType.Ambient,
						ai::TextureType.TextureTypeEmissive => TextureType.Emissive,
						ai::TextureType.TextureTypeHeight => TextureType.Height,
						ai::TextureType.TextureTypeNormals => TextureType.Normals,
						ai::TextureType.TextureTypeShininess => TextureType.Shininess,
						ai::TextureType.TextureTypeOpacity => TextureType.Opacity,
						ai::TextureType.TextureTypeDisplacement => TextureType.Displacement,
						ai::TextureType.TextureTypeLightmap => TextureType.Lightmap,
						ai::TextureType.TextureTypeReflection => TextureType.Reflection,
						ai::TextureType.TextureTypeBaseColor => TextureType.BaseColor,
						ai::TextureType.TextureTypeNormalCamera => TextureType.NormalCamera,
						ai::TextureType.TextureTypeEmissionColor => TextureType.EmissionColor,
						ai::TextureType.TextureTypeMetalness => TextureType.Metalness,
						ai::TextureType.TextureTypeDiffuseRoughness => TextureType.DiffuseRoughness,
						ai::TextureType.TextureTypeAmbientOcclusion => TextureType.AmbientOcclusion,
						_ => throw new NotSupportedException()
					};
				}

				return textures;
			}
		}
	}
}
