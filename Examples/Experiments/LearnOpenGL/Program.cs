using System.Diagnostics;

using Silk.NET.OpenGL;
using Silk.NET.Windowing;

using GLVertexArray = Nusantara.OpenGL.VertexArray;
using GLBuffer = Nusantara.OpenGL.Buffer;
using GLShader = Nusantara.OpenGL.Shader;
using GLProgram = Nusantara.OpenGL.Program;
using Silk.NET.Input;

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
	// Creating VertexArray and Buffers
	VAO = new(gl);
	VBO = new(gl);
	EBO = new(gl);

	// Setting Buffers storage.
	gl.NamedBufferStorage<float>(VBO.Handle, vertices, default(BufferStorageMask));
	gl.NamedBufferStorage<uint>(EBO.Handle, indices, default(BufferStorageMask));

	// Setting and binding VertexArray Buffers.
	gl.VertexArrayVertexBuffer(VAO.Handle, 0, VBO.Handle, 0, sizeof(float) * 3);
	gl.VertexArrayElementBuffer(VAO.Handle, EBO.Handle);

	gl.VertexArrayAttribBinding(VAO.Handle, 0, 0);
	gl.VertexArrayAttribFormat(VAO.Handle, 0, 3, VertexAttribType.Float, false, 0);
	gl.EnableVertexArrayAttrib(VAO.Handle, 0);

	// Compiling Shaders.
	using GLShader vertShader = new(gl, ShaderType.VertexShader);
	using GLShader fragShader = new(gl, ShaderType.FragmentShader);

	string vertSource = File.ReadAllText("shader.vert");
	gl.ShaderSource(vertShader.Handle, vertSource);
	gl.CompileShader(vertShader.Handle);

	vertShader.Get(ShaderParameterName.CompileStatus, out int vertResult);
	if (vertResult is 0)
	{
		throw new InvalidOperationException(gl.GetShaderInfoLog(vertShader.Handle));
	}

	string fragSource = File.ReadAllText("shader.frag");
	gl.ShaderSource(fragShader.Handle, fragSource);
	gl.CompileShader(fragShader.Handle);

	fragShader.Get(ShaderParameterName.CompileStatus, out int fragResult);
	if (fragResult is 0)
	{
		throw new InvalidOperationException(gl.GetShaderInfoLog(fragShader.Handle));
	}

	// Linking Program.
	shader = new(gl);
	gl.AttachShader(shader.Handle, vertShader.Handle);
	gl.AttachShader(shader.Handle, fragShader.Handle);
	gl.LinkProgram(shader.Handle);
	gl.DetachShader(shader.Handle, vertShader.Handle);
	gl.DetachShader(shader.Handle, fragShader.Handle);

	shader.Get(ProgramPropertyARB.LinkStatus, out int programResult);
	if (programResult is 0)
	{
		throw new InvalidOperationException(gl.GetProgramInfoLog(shader.Handle));
	}
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
