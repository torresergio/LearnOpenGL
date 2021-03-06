#version 330 core
out vec4 FragColor;

in vec3 Normal;
in vec3 Position;

uniform vec3 cameraPos;
uniform samplerCube skybox;

void main()
{    
    vec3 I = normalize(Position - cameraPos);
    //vec3 R = reflect(I, normalize(Normal));
    vec3 R = refract(I, normalize(Normal), 1/1.52);
    FragColor = vec4(texture(skybox, normalize(R)).rgb, 1.0);
}
