#version 330 core

layout (location = 0) in vec3 vPosition;
layout (location = 1) in vec3 vNormal;

uniform mat4 Model;
uniform mat4 ViewProjection;
uniform mat3 Normal;

out vec3 fPosition;
out vec3 fNormal;

void main()
{
	gl_Position = ViewProjection * Model * vec4(vPosition, 1.0);
	fPosition = vec3(Model * vec4(vPosition, 1.0));
	fNormal = Normal * vNormal;
}
