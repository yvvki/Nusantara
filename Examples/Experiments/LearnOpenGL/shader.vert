#version 330 core

layout (location = 0) in vec3 vPosition;
layout (location = 1) in vec3 vColor;
layout (location = 2) in vec2 vUV;

out vec4 fColor;
out vec2 fUV;

void main()
{
    gl_Position = vec4(vPosition, 1.0);
    fColor = vec4(vColor, 1.0);
    fUV = vUV;
}
