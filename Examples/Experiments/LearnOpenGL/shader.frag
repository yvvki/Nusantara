#version 330 core

uniform vec3 ObjectColor;
uniform vec3 LightColor;

layout (location = 0) out vec4 cColor;

void main()
{
    cColor = vec4(LightColor * ObjectColor, 1.0);
} 
