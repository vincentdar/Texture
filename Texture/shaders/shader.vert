#version 330 core

layout(location = 0) in vec3 aPosition;
layout (location = 1) in vec2 aTexCoords;

uniform mat4 transform;
uniform mat4 view;
uniform mat4 projection;

out vec2 TexCoords;
void main(){
	gl_Position = vec4(aPosition,1.0) * transform * view * projection;
	TexCoords = aTexCoords;

}

