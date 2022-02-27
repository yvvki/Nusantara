#version 330 core

// In.
in vec3 fPosition;
in vec3 fNormal;
in vec2 fUV;

// Material.
struct MATERIAL {
	sampler2D  Diffuse;
	sampler2D Specular;
	float    Shininess;
};
uniform MATERIAL Material;

// Camera.
uniform vec3 CameraPosition;

// Light.
struct LIGHT {
	vec3   Position;
	
	vec3    Ambient;
	vec3    Diffuse;
	vec3   Specular;
};
uniform LIGHT Light;

// Out.
layout (location = 0) out vec4 cColor;

void main()
{
	// Normalize normal.
	vec3        normal    = normalize(fNormal);

	// Calculate directions.
	vec3    viewDirection = normalize(CameraPosition - fPosition);
	vec3   lightDirection = normalize(Light.Position - fPosition);
	vec3 reflectDirection = reflect  (-lightDirection, normal);

	// Calculate results.
	float   diffuseResult =     max(dot(    normal,      lightDirection), 0.0);
	float  specularResult = pow(max(dot(viewDirection, reflectDirection), 0.0), Material.Shininess);

	// Texture.
	vec3 materialDiffuse  = vec3(texture(Material. Diffuse, fUV));
	vec3 materialSpecular = vec3(texture(Material.Specular, fUV));

	// Color.
	vec3         ambient  = Light. Ambient * materialDiffuse;
	vec3         diffuse  = Light. Diffuse * materialDiffuse  *  diffuseResult;
	vec3         specular = Light.Specular * materialSpecular * specularResult;

	// Combine results.
	vec3 result = ambient + diffuse + specular;
	cColor = vec4(result, 1.0);
} 
