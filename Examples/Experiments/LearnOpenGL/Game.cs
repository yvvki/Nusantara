// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using Silk.NET.Input;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;

using SkiaSharp;

using GLBuffer = Nusantara.OpenGL.Buffer;
using GLVertexArray = Nusantara.OpenGL.VertexArray;
using GLShader = Nusantara.OpenGL.Shader;
using GLProgram = Nusantara.OpenGL.Program;
using GLTexture = Nusantara.OpenGL.Texture;
using GLSKTexture = Nusantara.OpenGL.Skia.SKTexture;

namespace LearnOpenGL;

public class Game
{
	static readonly float[] vertices =
	{
		// Positions          // Colors           // UVs
		 0.5f,  0.5f, 0.0f,   1.0f, 0.0f, 0.0f,   1.0f, 1.0f,   // Top right
		 0.5f, -0.5f, 0.0f,   0.0f, 1.0f, 0.0f,   1.0f, 0.0f,   // Bottom right
		-0.5f, -0.5f, 0.0f,   0.0f, 0.0f, 1.0f,   0.0f, 0.0f,   // Bottom left
		-0.5f,  0.5f, 0.0f,   1.0f, 1.0f, 0.0f,   0.0f, 1.0f    // Top left
	};
	static readonly uint[] indices =
	{
		0, 1, 3,   // First triangle
		1, 2, 3    // Second triangle
	};

	WindowOptions options = WindowOptions.Default with
	{
		Size = new(800, 600)
	};
	IWindow window;

	IInputContext input;
	GL gl;

	GLVertexArray VAO;
	GLBuffer VBO;
	GLBuffer EBO;

	GLTexture container;
	GLTexture awesomeface;

	GLProgram shader;

	public Game()
	{
		window = Window.Create(options);

		// Will be assigned at window.Run
		input = null!;
		gl = null!;

		VAO = null!;
		VBO = null!;
		EBO = null!;

		container = null!;
		awesomeface = null!;

		shader = null!;

		window.Load += () =>
		{
			// Creating input.
			input = window.CreateInput();

			// Handling input.
			input.Keyboards[0].KeyDown += (keyboard, key, times) =>
			{
				switch (key)
				{
				case Key.Escape:
					window.Close();
					break;
				}
			};

			// Creating GL.
			gl = window.CreateOpenGL();
			window.Center();

			Initialize(gl);
		};

		void Initialize(GL gl)
		{
			// Creating Buffers.
			VBO = GLBuffer.FromData<float>(gl, vertices);
			EBO = GLBuffer.FromData<uint>(gl, indices);

			// Creating VertexArray.
			VAO = GLVertexArray.FromBuffers(gl, EBO, 0, VBO, 0, sizeof(float) * 8);

			// Handling Attrib.
			VAO.AttribBinding(0, 0);
			VAO.AttribFormat(0, 3, VertexAttribType.Float, false, 0);
			VAO.EnableAttrib(0);

			VAO.AttribBinding(1, 0);
			VAO.AttribFormat(1, 3, VertexAttribType.Float, false, sizeof(float) * 3);
			VAO.EnableAttrib(1);

			VAO.AttribBinding(2, 0);
			VAO.AttribFormat(2, 3, VertexAttribType.Float, false, sizeof(float) * 6);
			VAO.EnableAttrib(2);

			// Creating Texture.
			using (SKBitmap container_bitmap = SKBitmap.Decode("container.jpg"))
			{
				container = GLSKTexture.FromBitmap(gl, container_bitmap);
			}
			using (SKBitmap awesomeface_bitmap = SKBitmap.Decode("awesomeface.png"))
			{
				awesomeface = GLSKTexture.FromBitmap(gl, awesomeface_bitmap);
			}

			// Compiling Shaders.
			using GLShader vertShader = GLShader.FromFile(gl, ShaderType.VertexShader, "shader.vert");
			using GLShader fragShader = GLShader.FromFile(gl, ShaderType.FragmentShader, "shader.frag");

			// Linking Program.
			shader = GLProgram.FromShaders(gl, vertShader, fragShader);
		}

		window.Render += (dt) =>
		{
			// Clearing.
			gl.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);
			gl.Clear(ClearBufferMask.ColorBufferBit);

			// Uniform handling.
			gl.BindTextureUnit(0, container.Handle);
			gl.BindTextureUnit(1, awesomeface.Handle);

			shader.Uniform1("container", 0);
			shader.Uniform1("awesomeface", 1);

			// Drawing.
			gl.UseProgram(shader.Handle);
			gl.BindVertexArray(VAO.Handle);
			unsafe
			{
				gl.DrawElements(PrimitiveType.Triangles, (uint)indices.Length, DrawElementsType.UnsignedInt, null);
			}
		};

		window.Closing += () =>
		{
			shader.Dispose();

			EBO.Dispose();
			VBO.Dispose();
			VAO.Dispose();
		};
	}

	public void Run()
	{
		window.Run();
	}
}
