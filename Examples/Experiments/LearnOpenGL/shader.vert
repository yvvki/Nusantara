﻿#version 330 core

// In.
layout (location = 0) in vec3 vPosition;
layout (location = 1) in vec3 vNormal;

// Uniform.
uniform mat4 Model;
uniform mat4 ViewProjection;
uniform mat3 Normal;

// Out.
out vec3 fPosition;
out vec3 fNormal;

void main()
{
	// Calculate transformed position.
	vec4 position = Model * vec4(vPosition, 1.0);

	gl_Position = ViewProjection * position;

	fPosition = vec3(position);
	fNormal   = Normal * vNormal;
}
