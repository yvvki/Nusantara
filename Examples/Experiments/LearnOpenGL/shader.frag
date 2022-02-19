#version 330 core

in vec4 fColor;

layout (location = 0) out vec4 cColor;

void main()
{
    cColor = fColor;
} 
