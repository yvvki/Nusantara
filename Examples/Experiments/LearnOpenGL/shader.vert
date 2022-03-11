#version 330 core

// In.
layout (location = 0) in vec4 vPosition;
layout (location = 1) in vec4 vNormal;
layout (location = 2) in vec2 vUV;

// Uniform.
uniform mat4 Model;
uniform mat4 ViewProjection;
uniform mat3 Normal;

// Out.
out vec4 fPosition;
out vec4 fNormal;
out vec2 fUV;

void main()
{
	// Calculate transformed position.
	vec4 position = Model * vPosition;

	gl_Position = ViewProjection * position;

	fPosition = position;
	fNormal   = mat4(Normal) * vNormal;
	fUV       = vUV;
}
