#version 330 core

in vec4 fColor;
in vec2 fUV;

uniform sampler2D container;
uniform sampler2D awesomeface;

layout (location = 0) out vec4 cColor;

void main()
{
    cColor = mix(texture(container, fUV), texture(awesomeface, fUV), 0.2);
} 
