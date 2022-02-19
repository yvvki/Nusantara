// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using Silk.NET.Input;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;

using GLBuffer = Nusantara.OpenGL.Buffer;
using GLProgram = Nusantara.OpenGL.Program;
using GLShader = Nusantara.OpenGL.Shader;
using GLVertexArray = Nusantara.OpenGL.VertexArray;

float[] vertices =
{
	 0.5f,  0.5f, 0.0f,  // top right
	 0.5f, -0.5f, 0.0f,  // bottom right
	-0.5f, -0.5f, 0.0f,  // bottom left
	-0.5f,  0.5f, 0.0f   // top left 
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

GLProgram shader = null!;

window.Load += () =>
{
	input = window.CreateInput();

	input.Keyboards[0].KeyDown += (keyboard, key, times) =>
	{
		switch (key)
		{
		case Key.Escape:
			window.Close();
			break;
		}
	};

	gl = window.CreateOpenGL();
	window.Center();

	Init();
};

void Init()
{
	// Creating Buffers
	VBO = GLBuffer.FromData<float>(gl, vertices);
	EBO = GLBuffer.FromData<uint>(gl, indices);

	// Creating VertexArray.
	VAO = GLVertexArray.FromBuffers(gl, EBO, 0, VBO, 0, sizeof(float) * 3);

	// Handling Attrib.
	VAO.AttribBinding(0, 0);
	VAO.AttribFormat(0, 3, VertexAttribType.Float, false, 0);
	VAO.EnableAttrib(0);

	// Compiling Shaders.
	using GLShader vertShader = GLShader.FromFile(gl, ShaderType.VertexShader, "shader.vert");
	using GLShader fragShader = GLShader.FromFile(gl, ShaderType.FragmentShader, "shader.frag");

	// Linking Program.
	shader = GLProgram.FromShaders(gl, vertShader, fragShader);
}

window.Render += dt =>
{
	gl.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);
	gl.Clear(ClearBufferMask.ColorBufferBit);

	gl.UseProgram(shader.Handle);
	gl.BindVertexArray(VAO.Handle);
	unsafe { gl.DrawElements(PrimitiveType.Triangles, 6, DrawElementsType.UnsignedInt, null); }
};

window.Run();
