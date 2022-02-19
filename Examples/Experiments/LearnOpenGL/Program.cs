// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using Silk.NET.Input;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;

using GLBuffer = Nusantara.OpenGL.Buffer;
using GLVertexArray = Nusantara.OpenGL.VertexArray;
using GLShader = Nusantara.OpenGL.Shader;
using GLProgram = Nusantara.OpenGL.Program;
using GLTexture = Nusantara.OpenGL.Texture;
using SkiaSharp;

float[] vertices =
{
	// positions          // colors           // texture coords
	 0.5f,  0.5f, 0.0f,   1.0f, 0.0f, 0.0f,   1.0f, 1.0f,   // top right
	 0.5f, -0.5f, 0.0f,   0.0f, 1.0f, 0.0f,   1.0f, 0.0f,   // bottom right
	-0.5f, -0.5f, 0.0f,   0.0f, 0.0f, 1.0f,   0.0f, 0.0f,   // bottom left
	-0.5f,  0.5f, 0.0f,   1.0f, 1.0f, 0.0f,   0.0f, 1.0f    // top left 
};
uint[] indices =
{
	0, 1, 3,   // first triangle
	1, 2, 3    // second triangle
};

WindowOptions options = WindowOptions.Default with
{
	Size = new(800, 600)
};
IWindow window = Window.Create(options);

IInputContext input = null!;
GL gl = null!;

GLVertexArray VAO = null!;
GLBuffer VBO = null!;
GLBuffer EBO = null!;

GLTexture container = null!;
GLTexture awesomeface = null!;

GLProgram shader = null!;

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

	// Loading texture data.
	byte[] container_data = File.ReadAllBytes("container.jpg");
	using SKBitmap container_bitmap = SKBitmap.Decode(container_data);

	byte[] awesomeface_data = File.ReadAllBytes("awesomeface.png");
	using SKBitmap awesomeface_bitmap = SKBitmap.Decode(awesomeface_data);

	// Creating Texture.
	container = new(gl, TextureTarget.Texture2D);

	gl.TextureStorage2D(
		container.Handle,
		1,
		SizedInternalFormat.Rgba8,
		(uint)container_bitmap.Width,
		(uint)container_bitmap.Height);
	unsafe
	{
		gl.TextureSubImage2D(
			container.Handle,
			0,
			0,
			0,
			(uint)container_bitmap.Width,
			(uint)container_bitmap.Height,
			PixelFormat.Bgra,
			PixelType.UnsignedByte,
			(void*)container_bitmap.GetPixels());
	}
	gl.GenerateTextureMipmap(container.Handle);

	awesomeface = new(gl, TextureTarget.Texture2D);

	gl.TextureStorage2D(
		awesomeface.Handle,
		1,
		SizedInternalFormat.Rgba8,
		(uint)awesomeface_bitmap.Width,
		(uint)awesomeface_bitmap.Height);
	unsafe
	{
		gl.TextureSubImage2D(
			awesomeface.Handle,
			0,
			0,
			0,
			(uint)awesomeface_bitmap.Width,
			(uint)awesomeface_bitmap.Height,
			PixelFormat.Bgra,
			PixelType.UnsignedByte,
			(void*)awesomeface_bitmap.GetPixels());
	}
	gl.GenerateTextureMipmap(awesomeface.Handle);

	// Compiling Shaders.
	using GLShader vertShader = GLShader.FromFile(gl, ShaderType.VertexShader, "shader.vert");
	using GLShader fragShader = GLShader.FromFile(gl, ShaderType.FragmentShader, "shader.frag");

	// Linking Program.
	shader = GLProgram.FromShaders(gl, vertShader, fragShader);
}

window.Render += dt =>
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

window.Run();
