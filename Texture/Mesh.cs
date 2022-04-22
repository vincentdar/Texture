using LearnOpenTK.Common;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using OpenTK.Graphics.OpenGL4;

namespace GrafkomUAS
{
    class Mesh
    {
        //List<Vector3> vertices = new List<Vector3>();
        //List<Vector3> texVertices = new List<Vector3>();
        //List<uint> indices = new List<uint>();
        private readonly float[] vertices =
        {
            // Positions          Normals              Texture coords
            -0.5f, -0.5f, -0.5f,  /*0.0f,  0.0f, -1.0f,*/  0.0f, 0.0f,
             0.5f, -0.5f, -0.5f,  /*0.0f,  0.0f, -1.0f,*/  1.0f, 0.0f,
             0.5f,  0.5f, -0.5f,  /*0.0f,  0.0f, -1.0f,*/  1.0f, 1.0f,
             0.5f,  0.5f, -0.5f,  /*0.0f,  0.0f, -1.0f,*/  1.0f, 1.0f,
            -0.5f,  0.5f, -0.5f,  /*0.0f,  0.0f, -1.0f,*/  0.0f, 1.0f,
            -0.5f, -0.5f, -0.5f,  /*0.0f,  0.0f, -1.0f,*/  0.0f, 0.0f,

            -0.5f, -0.5f,  0.5f,  /*0.0f,  0.0f,  1.0f,*/  0.0f, 0.0f,
             0.5f, -0.5f,  0.5f,  /*0.0f,  0.0f,  1.0f,*/  1.0f, 0.0f,
             0.5f,  0.5f,  0.5f,  /*0.0f,  0.0f,  1.0f,*/  1.0f, 1.0f,
             0.5f,  0.5f,  0.5f,  /*0.0f,  0.0f,  1.0f,*/  1.0f, 1.0f,
            -0.5f,  0.5f,  0.5f,  /*0.0f,  0.0f,  1.0f,*/  0.0f, 1.0f,
            -0.5f, -0.5f,  0.5f,  /*0.0f,  0.0f,  1.0f,*/  0.0f, 0.0f,

            -0.5f,  0.5f,  0.5f, /*-1.0f,  0.0f,  0.0f,*/  1.0f, 0.0f,
            -0.5f,  0.5f, -0.5f, /*-1.0f,  0.0f,  0.0f,*/  1.0f, 1.0f,
            -0.5f, -0.5f, -0.5f, /*-1.0f,  0.0f,  0.0f,*/  0.0f, 1.0f,
            -0.5f, -0.5f, -0.5f, /*-1.0f,  0.0f,  0.0f,*/  0.0f, 1.0f,
            -0.5f, -0.5f,  0.5f, /*-1.0f,  0.0f,  0.0f,*/  0.0f, 0.0f,
            -0.5f,  0.5f,  0.5f, /*-1.0f,  0.0f,  0.0f,*/  1.0f, 0.0f,

             0.5f,  0.5f,  0.5f,  /*1.0f,  0.0f,  0.0f,*/  1.0f, 0.0f,
             0.5f,  0.5f, -0.5f,  /*1.0f,  0.0f,  0.0f,*/  1.0f, 1.0f,
             0.5f, -0.5f, -0.5f,  /*1.0f,  0.0f,  0.0f,*/  0.0f, 1.0f,
             0.5f, -0.5f, -0.5f,  /*1.0f,  0.0f,  0.0f,*/  0.0f, 1.0f,
             0.5f, -0.5f,  0.5f,  /*1.0f,  0.0f,  0.0f,*/  0.0f, 0.0f,
             0.5f,  0.5f,  0.5f,  /*1.0f,  0.0f,  0.0f,*/  1.0f, 0.0f,

            -0.5f, -0.5f, -0.5f,  /*0.0f, -1.0f,  0.0f,*/  0.0f, 1.0f,
             0.5f, -0.5f, -0.5f,  /*0.0f, -1.0f,  0.0f,*/  1.0f, 1.0f,
             0.5f, -0.5f,  0.5f,  /*0.0f, -1.0f,  0.0f,*/  1.0f, 0.0f,
             0.5f, -0.5f,  0.5f,  /*0.0f, -1.0f,  0.0f,*/  1.0f, 0.0f,
            -0.5f, -0.5f,  0.5f,  /*0.0f, -1.0f,  0.0f,*/  0.0f, 0.0f,
            -0.5f, -0.5f, -0.5f,  /*0.0f, -1.0f,  0.0f,*/  0.0f, 1.0f,

            -0.5f,  0.5f, -0.5f,  /*0.0f,  1.0f,  0.0f,*/  0.0f, 1.0f,
             0.5f,  0.5f, -0.5f,  /*0.0f,  1.0f,  0.0f,*/  1.0f, 1.0f,
             0.5f,  0.5f,  0.5f,  /*0.0f,  1.0f,  0.0f,*/  1.0f, 0.0f,
             0.5f,  0.5f,  0.5f,  /*0.0f,  1.0f,  0.0f,*/  1.0f, 0.0f,
            -0.5f,  0.5f,  0.5f,  /*0.0f,  1.0f,  0.0f,*/  0.0f, 0.0f,
            -0.5f,  0.5f, -0.5f,  /*0.0f,  1.0f,  0.0f,*/  0.0f, 1.0f
        };
        int _vao;
        int _vbo;
        int _ebo;

        Matrix4 transform;
        Matrix4 view;
        Matrix4 projection;

        Texture textureMap;
  

        Shader _shader;
        public Mesh(string vertPath, string fragPath)
        {
            _shader = new Shader(vertPath, fragPath);
        }

        public void setupObject()
        {
            transform = Matrix4.Identity;

            // Vertices
            //Inisialiasi VBO
            _vbo = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, _vbo);
            GL.BufferData(BufferTarget.ArrayBuffer, vertices.Length * Vector3.SizeInBytes,
                vertices.ToArray(), BufferUsageHint.StaticDraw);

            //Inisialisasi VAO
            _vao = GL.GenVertexArray();
            GL.BindVertexArray(_vao);
            var vertexLocation = _shader.GetAttribLocation("aPosition");
            GL.EnableVertexAttribArray(vertexLocation);
            GL.VertexAttribPointer(vertexLocation, 3, VertexAttribPointerType.Float, 
                false, 5 * sizeof(float), 0);

            //Inisialisasi EBO
            //_ebo = GL.GenBuffer();
            //GL.BindBuffer(BufferTarget.ElementArrayBuffer, _ebo);
            //GL.BufferData(BufferTarget.ElementArrayBuffer, indices.Count * sizeof(uint),
            //    indices.ToArray(), BufferUsageHint.StaticDraw);

            // Inisialiasi Texture
            //GL.BufferData(BufferTarget.ArrayBuffer, texVertices.Count * Vector3.SizeInBytes,
            //    texVertices.ToArray(), BufferUsageHint.StaticDraw);

            GL.BufferData(BufferTarget.ArrayBuffer, vertices.Length * Vector3.SizeInBytes,
                vertices, BufferUsageHint.StaticDraw);

            var texCoordLocation = _shader.GetAttribLocation("aTexCoords");
            GL.EnableVertexAttribArray(texCoordLocation);
            GL.VertexAttribPointer(texCoordLocation, 2, VertexAttribPointerType.Float,
                false, 5 * sizeof(float), 3 * sizeof(float));

            textureMap = Texture.LoadFromFile("C:/Users/vince/source/repos/Texture/Texture/resources/container.png");
            
        }

        public void render(Camera _camera)
        {
            GL.BindVertexArray(_vao);

            _shader.Use();
            _shader.SetMatrix4("transform", transform);
            _shader.SetMatrix4("view", _camera.GetViewMatrix());
            _shader.SetMatrix4("projection", _camera.GetProjectionMatrix());

            textureMap.Use(TextureUnit.Texture0);
            //_shader.SetInt("image", 0);

            //GL.DrawElements(BeginMode.Triangles, indices.Count / 3, DrawElementsType.UnsignedInt, 0);
            GL.DrawArrays(PrimitiveType.Triangles, 0, vertices.Length);
        }

        public void CreateTexturedCube()
        {
            //vertices.Add(new Vector3(-0.5f, 0.5f, 0.5f));
            //vertices.Add(new Vector3(0.5f, 0.5f, 0.5f));
            //vertices.Add(new Vector3(-0.5f, -0.5f, 0.5f));
            //vertices.Add(new Vector3(0.5f, -0.5f, 0.5f));
            //vertices.Add(new Vector3(-0.5f, 0.5f, -0.5f));
            //vertices.Add(new Vector3(0.5f, 0.5f, -0.5f));
            //vertices.Add(new Vector3(-0.5f, -0.5f, -0.5f));
            //vertices.Add(new Vector3(0.5f, -0.5f, -0.5f));

            //texVertices.Add(new Vector3(0.0f, 1.0f, 0.0f));
            //texVertices.Add(new Vector3(1.0f, 1.0f, 0.0f));
            //texVertices.Add(new Vector3(0.0f, 0.0f, 0.0f));
            //texVertices.Add(new Vector3(1.0f, 0.0f, 0.0f));
            //texVertices.Add(new Vector3(0.0f, 1.0f, 0.0f));
            //texVertices.Add(new Vector3(1.0f, 1.0f, 0.0f));
            //texVertices.Add(new Vector3(0.0f, 0.0f, 0.0f));
            //texVertices.Add(new Vector3(1.0f, 0.0f, 0.0f));

            ////Depan
            //indices.Add(0); indices.Add(1); indices.Add(2);
            //indices.Add(1); indices.Add(2); indices.Add(3);

            ////Kanan
            //indices.Add(1); indices.Add(5); indices.Add(7);
            //indices.Add(1); indices.Add(3); indices.Add(7);

            ////Kiri
            //indices.Add(0); indices.Add(4); indices.Add(6);
            //indices.Add(0); indices.Add(2); indices.Add(6);

            ////Belakang
            //indices.Add(4); indices.Add(5); indices.Add(6);
            //indices.Add(5); indices.Add(6); indices.Add(7);

            ////Atas
            //indices.Add(0); indices.Add(4); indices.Add(5);
            //indices.Add(0); indices.Add(1); indices.Add(5);

            ////Bawah
            //indices.Add(2); indices.Add(6); indices.Add(7);
            //indices.Add(2); indices.Add(3); indices.Add(7);
        }

        public void setTextureMap(string filepath)
        {
            textureMap = Texture.LoadFromFile(filepath);
        }


    }
}
