#version 330 core

in vec2 TexCoords;

out vec4 outputColor;
uniform sampler2D image;

void main(){
	outputColor = texture(image, TexCoords);
	//outputColor = vec4(1.0f); 
}