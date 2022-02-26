#version 330 core

in vec3 fPosition;
in vec3 fNormal;

uniform vec3 ObjectColor;
uniform vec3 LightColor;
uniform vec3 LightPosition;
uniform vec3 CameraPosition;

layout (location = 0) out vec4 cColor;

float ambientStrength = 0.1;
float specularStrength = 0.5;

void main()
{
	vec3 ambient = ambientStrength * LightColor;

	vec3 normal = normalize(fNormal);
	vec3 lightDirection = normalize(LightPosition - fPosition);

	float diffuseResult = max(dot(normal, lightDirection), 0.0);
	vec3 diffuse = diffuseResult * LightColor;

	vec3 viewDirection = normalize(CameraPosition - fPosition);
	vec3 reflectDirection = reflect(-lightDirection, normal);

	float specularResult = pow(max(dot(viewDirection, reflectDirection), 0.0), 32);
	vec3 specular = specularStrength * specularResult * LightColor;

	vec3 result = (ambient + diffuse + specular) * ObjectColor;
	cColor = vec4(result, 1.0);
} 
