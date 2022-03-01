#version 330 core

// In.
in vec3 fPosition;
in vec3 fNormal;
in vec2 fUV;

// Material.
struct MATERIAL {
	sampler2D Diffuse;
	sampler2D Specular;
	float     Shininess;
};
uniform MATERIAL Material;

// Camera.
uniform vec3 CameraPosition;

// Light types.
struct   DIRECTIONAL_LIGHT {
	vec3 Direction;

	vec3 Ambient;
	vec3 Diffuse;
	vec3 Specular;
};
vec3 calculate(in DIRECTIONAL_LIGHT light);

struct   POINT_LIGHT {
	vec3 Position;

	vec3 Ambient;
	vec3 Diffuse;
	vec3 Specular;

	float Constant;
	float Linear;
	float Quadratic;
};
vec3 calculate(in POINT_LIGHT light);

struct   SPOT_LIGHT {
	vec3 Position;
	vec3 Direction;

	vec3 Ambient;
	vec3 Diffuse;
	vec3 Specular;

	float Constant;
	float Linear;
	float Quadratic;

	float CutOff;
	float OuterCutOff;
};
vec3 calculate(in SPOT_LIGHT light);

// Light uniforms.
uniform  SPOT_LIGHT Light;

// Out.
layout (location = 0) out vec4 cColor;

void main()
{
	vec3 result = calculate(Light);
	cColor = vec4(result, 1.0);
}

// Method implementations.
vec3 calculate(in DIRECTIONAL_LIGHT light)
{
	// Normalize normal.
	vec3 normal           = normalize(fNormal);

	// Calculate directions.
	vec3    viewDirection = normalize(CameraPosition - fPosition);
	vec3   lightDirection = normalize(-light.Direction);
	vec3 reflectDirection = reflect  (-lightDirection, normal);

	// Calculate results.
	float   diffuseResult =     max(dot(normal,          lightDirection), 0.0);
	float  specularResult = pow(max(dot(viewDirection, reflectDirection), 0.0), Material.Shininess);

	// Texture.
	vec3 materialDiffuse  = vec3(texture(Material.Diffuse,  fUV));
	vec3 materialSpecular = vec3(texture(Material.Specular, fUV));

	// Color.
	vec3         ambient  = light.Ambient                   * materialDiffuse;
	vec3         diffuse  = light.Diffuse  * diffuseResult  * materialDiffuse;
	vec3         specular = light.Specular * specularResult * materialSpecular;

	// Combine results.
	vec3   result = ambient + diffuse + specular;
	return result;
}

vec3 calculate(in POINT_LIGHT light)
{
	// Normalize normal.
	vec3 normal           = normalize(fNormal);

	// Calculate directions.
	vec3    viewDirection = normalize(CameraPosition - fPosition);
	vec3   lightDirection = normalize(light.Position - fPosition);
	vec3 reflectDirection = reflect  (-lightDirection, normal);

	// Calculate results.
	float   diffuseResult =     max(dot(normal,          lightDirection), 0.0);
	float  specularResult = pow(max(dot(viewDirection, reflectDirection), 0.0), Material.Shininess);

	// Texture.
	vec3 materialDiffuse  = vec3(texture(Material.Diffuse,  fUV));
	vec3 materialSpecular = vec3(texture(Material.Specular, fUV));

	// Attenuation.
	float distance        = length   (light.Position - fPosition);
	float attenuation     = 1.0 / (light.Constant + (light.Linear * distance) + (light.Quadratic * distance * distance));

	// Color.
	vec3         ambient  = light.Ambient                   * materialDiffuse  * attenuation;
	vec3         diffuse  = light.Diffuse  * diffuseResult  * materialDiffuse  * attenuation;
	vec3         specular = light.Specular * specularResult * materialSpecular * attenuation;

	// Combine results.
	vec3   result = ambient + diffuse + specular;
	return result;
}

vec3 calculate(in SPOT_LIGHT light)
{
	// Normalize normal.
	vec3 normal           = normalize(fNormal);

	// Calculate directions.
	vec3    viewDirection = normalize(CameraPosition - fPosition);
	vec3   lightDirection = normalize(light.Position - fPosition);
	vec3 reflectDirection = reflect  (-lightDirection, normal);

	// Calculate results.
	float   diffuseResult =     max(dot(normal,          lightDirection), 0.0);
	float  specularResult = pow(max(dot(viewDirection, reflectDirection), 0.0), Material.Shininess);

	// Texture.
	vec3 materialDiffuse  = vec3(texture(Material.Diffuse,  fUV));
	vec3 materialSpecular = vec3(texture(Material.Specular, fUV));

	// Attenuation.
	float distance        = length   (light.Position - fPosition);
	float attenuation     = 1.0 / (light.Constant + (light.Linear * distance) + (light.Quadratic * distance * distance));

	// Intensity.
	float theta           = dot(lightDirection, normalize(-light.Direction));
	float epsilon         = light.CutOff - light.OuterCutOff;
	float intensity       = clamp((theta - light.OuterCutOff) / epsilon, 0.0, 1.0);

	// Color.
	vec3         ambient  = light.Ambient                   * materialDiffuse  * attenuation;
	vec3         diffuse  = light.Diffuse  * diffuseResult  * materialDiffuse  * attenuation * intensity;
	vec3         specular = light.Specular * specularResult * materialSpecular * attenuation * intensity;

	// Combine results.
	vec3   result = ambient + diffuse + specular;
	return result;
}
