﻿// <https://github.com/yvvki> wrote this file.
// As long as you retain this notice, you can do whatever you want with this stuff.

using System.Numerics;

using Nusantara;
using Nusantara.Maths;
using Nusantara.OpenGL;

using Silk.NET.Input;
using Silk.NET.Maths;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;

using SkiaSharp;

using GLProgram = Nusantara.OpenGL.Program;
using GLShader = Nusantara.OpenGL.Shader;
using GLTexture = Nusantara.OpenGL.Texture;

namespace LearnOpenGL;

public class Game
{
	private static readonly Vertex[] vertices =
	{
		new(new Vector3(-0.5f, -0.5f, -0.5f), new Vector3( 0.0f,  0.0f, -1.0f), new(0.0f, 0.0f)),
		new(new Vector3( 0.5f, -0.5f, -0.5f), new Vector3( 0.0f,  0.0f, -1.0f), new(1.0f, 0.0f)),
		new(new Vector3( 0.5f,  0.5f, -0.5f), new Vector3( 0.0f,  0.0f, -1.0f), new(1.0f, 1.0f)),
		new(new Vector3( 0.5f,  0.5f, -0.5f), new Vector3( 0.0f,  0.0f, -1.0f), new(1.0f, 1.0f)),
		new(new Vector3(-0.5f,  0.5f, -0.5f), new Vector3( 0.0f,  0.0f, -1.0f), new(0.0f, 1.0f)),
		new(new Vector3(-0.5f, -0.5f, -0.5f), new Vector3( 0.0f,  0.0f, -1.0f), new(0.0f, 0.0f)),

		new(new Vector3(-0.5f, -0.5f,  0.5f), new Vector3( 0.0f,  0.0f,  1.0f), new(0.0f, 0.0f)),
		new(new Vector3( 0.5f, -0.5f,  0.5f), new Vector3( 0.0f,  0.0f,  1.0f), new(1.0f, 0.0f)),
		new(new Vector3( 0.5f,  0.5f,  0.5f), new Vector3( 0.0f,  0.0f,  1.0f), new(1.0f, 1.0f)),
		new(new Vector3( 0.5f,  0.5f,  0.5f), new Vector3( 0.0f,  0.0f,  1.0f), new(1.0f, 1.0f)),
		new(new Vector3(-0.5f,  0.5f,  0.5f), new Vector3( 0.0f,  0.0f,  1.0f), new(0.0f, 1.0f)),
		new(new Vector3(-0.5f, -0.5f,  0.5f), new Vector3( 0.0f,  0.0f,  1.0f), new(0.0f, 0.0f)),

		new(new Vector3(-0.5f,  0.5f,  0.5f), new Vector3(-1.0f,  0.0f,  0.0f), new(1.0f, 0.0f)),
		new(new Vector3(-0.5f,  0.5f, -0.5f), new Vector3(-1.0f,  0.0f,  0.0f), new(1.0f, 1.0f)),
		new(new Vector3(-0.5f, -0.5f, -0.5f), new Vector3(-1.0f,  0.0f,  0.0f), new(0.0f, 1.0f)),
		new(new Vector3(-0.5f, -0.5f, -0.5f), new Vector3(-1.0f,  0.0f,  0.0f), new(0.0f, 1.0f)),
		new(new Vector3(-0.5f, -0.5f,  0.5f), new Vector3(-1.0f,  0.0f,  0.0f), new(0.0f, 0.0f)),
		new(new Vector3(-0.5f,  0.5f,  0.5f), new Vector3(-1.0f,  0.0f,  0.0f), new(1.0f, 0.0f)),

		new(new Vector3( 0.5f,  0.5f,  0.5f), new Vector3( 1.0f,  0.0f,  0.0f), new(1.0f, 0.0f)),
		new(new Vector3( 0.5f,  0.5f, -0.5f), new Vector3( 1.0f,  0.0f,  0.0f), new(1.0f, 1.0f)),
		new(new Vector3( 0.5f, -0.5f, -0.5f), new Vector3( 1.0f,  0.0f,  0.0f), new(0.0f, 1.0f)),
		new(new Vector3( 0.5f, -0.5f, -0.5f), new Vector3( 1.0f,  0.0f,  0.0f), new(0.0f, 1.0f)),
		new(new Vector3( 0.5f, -0.5f,  0.5f), new Vector3( 1.0f,  0.0f,  0.0f), new(0.0f, 0.0f)),
		new(new Vector3( 0.5f,  0.5f,  0.5f), new Vector3( 1.0f,  0.0f,  0.0f), new(1.0f, 0.0f)),

		new(new Vector3(-0.5f, -0.5f, -0.5f), new Vector3( 0.0f, -1.0f,  0.0f), new(0.0f, 1.0f)),
		new(new Vector3( 0.5f, -0.5f, -0.5f), new Vector3( 0.0f, -1.0f,  0.0f), new(1.0f, 1.0f)),
		new(new Vector3( 0.5f, -0.5f,  0.5f), new Vector3( 0.0f, -1.0f,  0.0f), new(1.0f, 0.0f)),
		new(new Vector3( 0.5f, -0.5f,  0.5f), new Vector3( 0.0f, -1.0f,  0.0f), new(1.0f, 0.0f)),
		new(new Vector3(-0.5f, -0.5f,  0.5f), new Vector3( 0.0f, -1.0f,  0.0f), new(0.0f, 0.0f)),
		new(new Vector3(-0.5f, -0.5f, -0.5f), new Vector3( 0.0f, -1.0f,  0.0f), new(0.0f, 1.0f)),

		new(new Vector3(-0.5f,  0.5f, -0.5f), new Vector3( 0.0f,  1.0f,  0.0f), new(0.0f, 1.0f)),
		new(new Vector3( 0.5f,  0.5f, -0.5f), new Vector3( 0.0f,  1.0f,  0.0f), new(1.0f, 1.0f)),
		new(new Vector3( 0.5f,  0.5f,  0.5f), new Vector3( 0.0f,  1.0f,  0.0f), new(1.0f, 0.0f)),
		new(new Vector3( 0.5f,  0.5f,  0.5f), new Vector3( 0.0f,  1.0f,  0.0f), new(1.0f, 0.0f)),
		new(new Vector3(-0.5f,  0.5f,  0.5f), new Vector3( 0.0f,  1.0f,  0.0f), new(0.0f, 0.0f)),
		new(new Vector3(-0.5f,  0.5f, -0.5f), new Vector3( 0.0f,  1.0f,  0.0f), new(0.0f, 1.0f))
	};

	private static readonly Vector3[] cubePositions =
	{
		new( 0.0f,  0.0f,  0.0f ),
		new( 2.0f,  5.0f, -15.0f),
		new(-1.5f, -2.2f, -2.5f ),
		new(-3.8f, -2.0f, -12.3f),
		new( 2.4f, -0.4f, -3.5f ),
		new(-1.7f,  3.0f, -7.5f ),
		new( 1.3f, -2.0f, -2.5f ),
		new( 1.5f,  2.0f, -2.5f ),
		new( 1.5f,  0.2f, -1.5f ),
		new(-1.3f,  1.0f, -1.5f )
	};

	private WindowOptions options = WindowOptions.Default with
	{
		Size = new(800, 600),
		PreferredDepthBufferBits = 24, // workaround on my end not having depth buffer bit
	};
	private readonly IWindow window;

	private IInputContext input;
	private GL gl;

	private Mesh mesh;

	private GLTexture container2;
	private GLTexture container2_specular;

	private GLProgram shader;
	private GLProgram lightShader;

	private Camera camera;
	private EulerRotation cameraRotation;

	public Game()
	{
		window = Window.Create(options);

		// Will be assigned at window.Run
		input = null!;
		gl = null!;

		mesh = null!;

		container2 = null!;
		container2_specular = null!;

		shader = null!;
		lightShader = null!;

		camera = null!;

		window.Load += () =>
		{
			// Centering window.
			window.Center();

			// Creating input.
			input = window.CreateInput();

			// Handling input.
			camera = new(
				Scalar.DegreesToRadians(90f), // Defaults to 90 degrees (CS:GO).
				MathHelper.NormalizeHomogeneous((Vector2D<float>)window.Size),
				0.1f,
				100.0f)
			{
				Position = new(0.0f, 0.0f, 3.0f)
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

				camera.Rotation = (Quaternion)cameraRotation;
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
					 camera.FieldOfView - Scalar.DegreesToRadians(wheel.Y),
					 Scalar.DegreesToRadians(75f),
					 Scalar.DegreesToRadians(90f));
			}

			// Creating GL.
			gl = window.CreateOpenGL();
			Initialize(gl);
		};

		void Initialize(GL gl)
		{
			// Creating Mesh.
			mesh = new(gl, vertices, null);

			const string resourcePath = "Resources";

			// Loading Texture.
			using (SKBitmap container2_bitmap = SKBitmap.Decode(Path.Combine(resourcePath, "container2.png")))
			{
				container2 = Nusantara.OpenGL.SkiaSharp.TextureExtensions.CreateFromBitmap(gl, container2_bitmap);
			}
			using (SKBitmap container2_specular_bitmap = SKBitmap.Decode(Path.Combine(resourcePath, "container2_specular.png")))
			{
				container2_specular = Nusantara.OpenGL.SkiaSharp.TextureExtensions.CreateFromBitmap(gl, container2_specular_bitmap);
			}

			// Compiling Shaders.
			using GLShader vertShader = GLShader.CreateFromFile(gl, ShaderType.VertexShader, Path.Combine(resourcePath, "shader.vert"));
			using GLShader fragShader = GLShader.CreateFromFile(gl, ShaderType.FragmentShader, Path.Combine(resourcePath, "shader.frag"));
			using GLShader fragLight = GLShader.CreateFromFile(gl, ShaderType.FragmentShader, Path.Combine(resourcePath, "light.frag"));

			// Linking Program.
			shader = GLProgram.CreateFromShaders(gl, vertShader, fragShader);
			lightShader = GLProgram.CreateFromShaders(gl, vertShader, fragLight);
		}

		window.Update += (deltaTime) =>
		{
			float cameraSpeed = 2.5f * (float)deltaTime;

			IKeyboard keyboard = input.Keyboards[0];

			// W is 0 (homogeneous vector) since we adding the values.
			if (keyboard.IsKeyPressed(Key.W))
				camera.Position += camera.Forward * cameraSpeed;
			if (keyboard.IsKeyPressed(Key.S))
				camera.Position -= camera.Forward * cameraSpeed;
			if (keyboard.IsKeyPressed(Key.D))
				camera.Position += camera.Right * cameraSpeed;
			if (keyboard.IsKeyPressed(Key.A))
				camera.Position -= camera.Right * cameraSpeed;
		};

		Vector3[] LampPositions =
		{
			new Vector3( 0.7f,  0.2f,  2.0f),
			new Vector3( 2.3f, -3.3f, -4.0f),
			new Vector3(-4.0f,  2.0f, -12.0f),
			new Vector3( 0.0f,  0.0f, -3.0f)
		};

		window.Render += (deltaTime) =>
		{
			gl.Enable(EnableCap.DepthTest);

			// Clearing.
			gl.ClearColor(0.1f, 0.1f, 0.1f, 1.0f);
			gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

			Matrix4x4 view = camera.GetView();
			Matrix4x4 projection = camera.GetProjection();

			float time = (float)window.Time;

			// Bind mesh.
			mesh.Bind();

			// Cube:
			// Uniforms.
			gl.BindTextureUnit(0, container2.Handle);
			gl.BindTextureUnit(1, container2_specular.Handle);

			// Material.
			shader.Uniform("Material.Diffuse", 0);
			shader.Uniform("Material.Specular", 1);

			shader.Uniform("Material.Shininess", 32.0f);

			shader.Uniform("ViewProjection", false, view * projection);

			Vector3 cameraPosition = camera.Position;
			shader.Uniform("CameraPosition", cameraPosition);

			// Light constants.
			const float constant = 1.0f;
			const float linear = 0.09f;
			const float quadratic = 0.032f;

			// Sun.
			shader.Uniform("Sun.Direction", -0.2f, -1.0f, -0.3f);

			shader.Uniform("Sun.Ambient", 0.05f, 0.05f, 0.05f);
			shader.Uniform("Sun.Diffuse", 0.4f, 0.4f, 0.4f);
			shader.Uniform("Sun.Specular", 0.5f, 0.5f, 0.5f);

			// Lamps.
			for (int i = 0; i < 4; i++)
			{
				shader.Uniform($"Lamps[{i}].Position", LampPositions[i]);

				shader.Uniform($"Lamps[{i}].Ambient", 0.05f, 0.05f, 0.05f);
				shader.Uniform($"Lamps[{i}].Diffuse", 0.8f, 0.8f, 0.8f);
				shader.Uniform($"Lamps[{i}].Specular", 1.0f, 1.0f, 1.0f);

				shader.Uniform($"Lamps[{i}].Constant", constant);
				shader.Uniform($"Lamps[{i}].Linear", linear);
				shader.Uniform($"Lamps[{i}].Quadratic", quadratic);
			}

			// Torch.
			shader.Uniform("Torch.Position", cameraPosition);
			shader.Uniform("Torch.Direction", camera.Forward);

			shader.Uniform("Torch.Ambient", 0.0f, 0.0f, 0.0f);
			shader.Uniform("Torch.Diffuse", 1.0f, 1.0f, 1.0f);
			shader.Uniform("Torch.Specular", 1.0f, 1.0f, 1.0f);

			shader.Uniform("Torch.Constant", constant);
			shader.Uniform("Torch.Linear", linear);
			shader.Uniform("Torch.Quadratic", quadratic);

			shader.Uniform("Torch.CutOff", MathF.Cos(Scalar.DegreesToRadians(25.0f)));
			shader.Uniform("Torch.OuterCutOff", MathF.Cos(Scalar.DegreesToRadians(35.0f)));

			gl.UseProgram(shader.Handle);
			for (int i = 0; i < cubePositions.Length; i++)
			{
				// Model.
				Transform model = Transform.Identity;
				model.Translation = cubePositions[i];
				float angle = 20.0f * i;
				model.Rotation = Quaternion.CreateFromAxisAngle(
					Vector3.Normalize(new(1.0f, 0.3f, 0.5f)),
					Scalar.DegreesToRadians(angle));

				Matrix4x4 modelMatrix = model.GetMatrix();
				if (Matrix4x4.Invert(modelMatrix, out Matrix4x4 normal) is false) throw new InvalidOperationException();

				shader.Uniform("Model", false, modelMatrix);
				shader.Uniform("Normal", true, new Matrix3X3<float>(normal.ToGeneric()));

				// Drawing.
				gl.DrawArrays(PrimitiveType.Triangles, 0, 36);
			}

			// Light:
			// Uniforms.
			lightShader.Uniform("ViewProjection", false, view * projection);

			gl.UseProgram(lightShader.Handle);
			for (int i = 0; i < LampPositions.Length; i++)
			{
				// Model.
				Transform lightModel = new(
					LampPositions[i],
					Quaternion.Identity,
					new Vector3(0.2f));

				lightShader.Uniform("Model", false, lightModel.GetMatrix());

				// Drawing.
				gl.DrawArrays(PrimitiveType.Triangles, 0, (uint)vertices.Length);
			}
		};

		window.Closing += () =>
		{
			shader.Dispose();
			lightShader.Dispose();

			mesh.Dispose();

			input.Dispose();
		};
	}

	public void Run()
	{
		window.Run();
	}
}
