#version 330 core

layout (location = 0) in vec3 vPosition;
layout (location = 1) in vec2 vUV;

uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;

out vec4 fColor;
out vec2 fUV;

void main()
{
    gl_Position = projection * view * model * vec4(vPosition, 1.0);
    fUV = vUV;
}
