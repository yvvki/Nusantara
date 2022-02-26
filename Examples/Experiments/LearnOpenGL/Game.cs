// <https://github.com/YvvkiRika> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;

using Nusantara;
using Nusantara.Maths;

using Silk.NET.Input;
using Silk.NET.Maths;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;

using SkiaSharp;

using GLBuffer = Nusantara.OpenGL.Buffer;
using GLProgram = Nusantara.OpenGL.Program;
using GLShader = Nusantara.OpenGL.Shader;
using GLSKTexture = Nusantara.OpenGL.Skia.SKTexture;
using GLTexture = Nusantara.OpenGL.Texture;
using GLVertexArray = Nusantara.OpenGL.VertexArray;

namespace LearnOpenGL;

public class Game
{
	private static readonly float[] vertices =
	{
		// Positions          // UVs
		-0.5f, -0.5f, -0.5f,  0.0f, 0.0f,
		 0.5f, -0.5f, -0.5f,  1.0f, 0.0f,
		 0.5f,  0.5f, -0.5f,  1.0f, 1.0f,
		 0.5f,  0.5f, -0.5f,  1.0f, 1.0f,
		-0.5f,  0.5f, -0.5f,  0.0f, 1.0f,
		-0.5f, -0.5f, -0.5f,  0.0f, 0.0f,

		-0.5f, -0.5f,  0.5f,  0.0f, 0.0f,
		 0.5f, -0.5f,  0.5f,  1.0f, 0.0f,
		 0.5f,  0.5f,  0.5f,  1.0f, 1.0f,
		 0.5f,  0.5f,  0.5f,  1.0f, 1.0f,
		-0.5f,  0.5f,  0.5f,  0.0f, 1.0f,
		-0.5f, -0.5f,  0.5f,  0.0f, 0.0f,

		-0.5f,  0.5f,  0.5f,  1.0f, 0.0f,
		-0.5f,  0.5f, -0.5f,  1.0f, 1.0f,
		-0.5f, -0.5f, -0.5f,  0.0f, 1.0f,
		-0.5f, -0.5f, -0.5f,  0.0f, 1.0f,
		-0.5f, -0.5f,  0.5f,  0.0f, 0.0f,
		-0.5f,  0.5f,  0.5f,  1.0f, 0.0f,

		 0.5f,  0.5f,  0.5f,  1.0f, 0.0f,
		 0.5f,  0.5f, -0.5f,  1.0f, 1.0f,
		 0.5f, -0.5f, -0.5f,  0.0f, 1.0f,
		 0.5f, -0.5f, -0.5f,  0.0f, 1.0f,
		 0.5f, -0.5f,  0.5f,  0.0f, 0.0f,
		 0.5f,  0.5f,  0.5f,  1.0f, 0.0f,

		-0.5f, -0.5f, -0.5f,  0.0f, 1.0f,
		 0.5f, -0.5f, -0.5f,  1.0f, 1.0f,
		 0.5f, -0.5f,  0.5f,  1.0f, 0.0f,
		 0.5f, -0.5f,  0.5f,  1.0f, 0.0f,
		-0.5f, -0.5f,  0.5f,  0.0f, 0.0f,
		-0.5f, -0.5f, -0.5f,  0.0f, 1.0f,

		-0.5f,  0.5f, -0.5f,  0.0f, 1.0f,
		 0.5f,  0.5f, -0.5f,  1.0f, 1.0f,
		 0.5f,  0.5f,  0.5f,  1.0f, 0.0f,
		 0.5f,  0.5f,  0.5f,  1.0f, 0.0f,
		-0.5f,  0.5f,  0.5f,  0.0f, 0.0f,
		-0.5f,  0.5f, -0.5f,  0.0f, 1.0f
	};

	private static readonly Vector3[] cubePositions =
	{
		new( 0.0f,  0.0f,  0.0f),
		new( 2.0f,  5.0f, -15.0f),
		new(-1.5f, -2.2f, -2.5f),
		new(-3.8f, -2.0f, -12.3f),
		new( 2.4f, -0.4f, -3.5f),
		new(-1.7f,  3.0f, -7.5f),
		new( 1.3f, -2.0f, -2.5f),
		new( 1.5f,  2.0f, -2.5f),
		new( 1.5f,  0.2f, -1.5f),
		new(-1.3f,  1.0f, -1.5f)
	};

	private WindowOptions options = WindowOptions.Default with
	{
		Size = new(800, 600),
		PreferredDepthBufferBits = 24, // workaround on my end not having depth buffer bit
	};
	private readonly IWindow window;

	private IInputContext input;
	private GL gl;

	private GLVertexArray VAO;
	private GLBuffer VBO;

	private GLTexture container;
	private GLTexture awesomeface;

	private GLProgram shader;

	private Camera camera;
	private EulerQuaternion cameraRotation;

	public Game()
	{
		window = Window.Create(options);

		// Will be assigned at window.Run
		input = null!;
		gl = null!;

		VAO = null!;
		VBO = null!;

		container = null!;
		awesomeface = null!;

		shader = null!;

		camera = null!;

		window.Load += () =>
		{
			// Creating input.
			input = window.CreateInput();

			// Handling input.
			camera = new(
				MathHelper.DegreesToRadians(90), // Defaults to 90 degrees (CS:GO).
				MathHelper.NormalizeHomogenous((Vector2D<float>)window.Size),
				0.1f,
				100.0f)
			{
				Position = new(0.0f, 0.0f, 3.0f, 1)
			};

			foreach (IKeyboard keyboard in input.Keyboards)
			{
				keyboard.KeyDown += OnKeyDown;
			}

			input.Mice[0].Cursor.CursorMode = CursorMode.Raw;
			input.Mice[0].Position = default;

			foreach (IMouse mouse in input.Mice)
			{
				mouse.MouseMove += OnMouseMove;
				mouse.Scroll += OnScroll;
			}

			void OnKeyDown(IKeyboard keyboard, Key key, int times)
			{
				switch (key)
				{
				case Key.Escape:
					window.Close();
					break;
				}
			}

			void OnMouseMove(IMouse mouse, Vector2 position)
			{
				mouse.Position = default;

				// Lower sensitivity due calculating in radians.
				const float sensitivity = 0.002f;
				Vector2 offset = position * sensitivity;

				// Modulo around 360 degrees.
				cameraRotation.Yaw = (cameraRotation.Yaw - offset.X) % MathF.Tau;
				cameraRotation.Pitch = Math.Clamp(
					cameraRotation.Pitch - offset.Y,
					-MathF.PI / 2, // PI == 180 degrees
					MathF.PI / 2);

				camera.Rotation = cameraRotation;
			}

			void OnScroll(IMouse mouse, ScrollWheel wheel)
			{
				//// Minimum and maximum value that can be assigned.
				//camera.FieldOfView = Math.Clamp(
				//	 camera.FieldOfView - MathHelper.DegreesToRadians(wheel.Y),
				//	 float.Epsilon,
				//	 MathHelper.PIMinusEpsilon);

				//// Minecraft style.
				//camera.FieldOfView = Math.Clamp(
				//	 camera.FieldOfView - MathHelper.DegreesToRadians(wheel.Y),
				//	 MathHelper.DegreesToRadians(30),
				//	 MathHelper.DegreesToRadians(110));

				// Team Fortress 2 style.
				camera.FieldOfView = Math.Clamp(
					 camera.FieldOfView - MathHelper.DegreesToRadians(wheel.Y),
					 MathHelper.DegreesToRadians(75),
					 MathHelper.DegreesToRadians(90));
			}

			// Creating GL.
			gl = window.CreateOpenGL();
			window.Center();

			Initialize(gl);
		};

		void Initialize(GL gl)
		{
			// Creating Buffers.
			VBO = GLBuffer.FromData<float>(gl, vertices);

			// Creating VertexArray.
			VAO = GLVertexArray.FromBuffers(gl, null, 0, VBO, 0, sizeof(float) * 5);

			// Handling Attrib.
			VAO.AttribBinding(0, 0);
			VAO.AttribFormat(0, 3, VertexAttribType.Float, false, 0);
			VAO.EnableAttrib(0);

			VAO.AttribBinding(1, 0);
			VAO.AttribFormat(1, 2, VertexAttribType.Float, false, sizeof(float) * 3);
			VAO.EnableAttrib(1);

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

		window.Update += (deltaTime) =>
		{
			float cameraSpeed = 2.5f * (float)deltaTime;

			IKeyboard keyboard = input.Keyboards[0];

			// W is 0 (homogeneous vector) since we adding the values.
			if (keyboard.IsKeyPressed(Key.W))
				camera.Position += new Vector4(camera.Forward * cameraSpeed, 0);
			if (keyboard.IsKeyPressed(Key.S))
				camera.Position -= new Vector4(camera.Forward * cameraSpeed, 0);
			if (keyboard.IsKeyPressed(Key.D))
				camera.Position += new Vector4(camera.Right * cameraSpeed, 0);
			if (keyboard.IsKeyPressed(Key.A))
				camera.Position -= new Vector4(camera.Right * cameraSpeed, 0);
		};

		Transform model = new();

		window.Render += (deltaTime) =>
		{
			gl.Enable(EnableCap.DepthTest);

			// Clearing.
			gl.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);
			gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

			// Uniform handling.
			gl.BindTextureUnit(0, container.Handle);
			gl.BindTextureUnit(1, awesomeface.Handle);

			shader.Uniform1("container", 0);
			shader.Uniform1("awesomeface", 1);

			//model.Rotation = Quaternion.CreateFromAxisAngle(
			//	 Vector3.Normalize(new(0.5f, 1.0f, 0.0f)),
			//	 (float)window.Time * MathHelper.DegreesToRadians(50.0f));
			Matrix4x4 view = camera.GetView();
			Matrix4x4 projection = camera.GetProjection();

			shader.UniformMatrix4("view", false, view);
			shader.UniformMatrix4("projection", false, projection);

			// Drawing.
			gl.UseProgram(shader.Handle);
			gl.BindVertexArray(VAO.Handle);

			for (int i = 0; i < cubePositions.Length; i++)
			{
				model.Translation = new(cubePositions[i], 1);
				float angle = 20.0f * i;
				model.Rotation = Quaternion.CreateFromAxisAngle(
					Vector3.Normalize(new(1.0f, 0.3f, 0.5f)),
					MathHelper.DegreesToRadians(angle));

				shader.UniformMatrix4("model", false, model.GetMatrix());

				gl.DrawArrays(PrimitiveType.Triangles, 0, 36);
			}
		};

		window.Closing += () =>
		{
			shader.Dispose();

			VBO.Dispose();
			VAO.Dispose();
		};
	}

	public void Run()
	{
		window.Run();
	}
}
