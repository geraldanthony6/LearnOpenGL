#version 330 core
	out vec4 FragColor;
	in vec3 ourColor;
	in vec4 pos;
	void main()
	{
	 FragColor = pos;
	}