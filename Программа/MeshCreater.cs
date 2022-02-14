using System;
using System.Collections.Generic;
using System.Linq;
using AMath;

namespace Visualizer
{
    public class MeshCreater
    {
        public static Mesh Cone(Vertex basement, double radius, double height, int vertexCount)
        {
            Mesh result = new Mesh();

            result.Verteces.Add(new Vertex(basement.Position.X, basement.Position.Y+ height, basement.Position.Z ));
            result.Verteces.AddRange(CreateRing(new Vector3(basement.Position.X, basement.Position.Y, basement.Position.Z), radius, vertexCount));
            result.Faces.AddRange(Connect(0, result.Verteces.Count - vertexCount, result.Verteces.Count - 1));
            result.Verteces.Add(new Vertex(basement.Position.X, basement.Position.Y, basement.Position.Z));
            result.Faces.AddRange(Connect(result.Verteces.Count - 1, result.Verteces.Count - vertexCount - 1, result.Verteces.Count - 2));
            return result;
        }
        public static Mesh Box(Vertex basement, double length, double width, double height)
        {

            length = length / 5;
            width = width / 5;
            height = height / 5;

            Mesh result = new Mesh();
            
            result.Verteces.Add(new Vertex(basement.Position.X + width / 2, basement.Position.Y, basement.Position.Z + length / 2));
            result.Verteces.Add(new Vertex(basement.Position.X - width / 2, basement.Position.Y, basement.Position.Z + length / 2));
            result.Verteces.Add(new Vertex(basement.Position.X + width / 2, basement.Position.Y, basement.Position.Z - length / 2));
            result.Verteces.Add(new Vertex(basement.Position.X - width / 2, basement.Position.Y, basement.Position.Z - length / 2));
            result.Verteces.Add(new Vertex(basement.Position.X + width / 2, basement.Position.Y + height, basement.Position.Z + length / 2));
            result.Verteces.Add(new Vertex(basement.Position.X - width / 2, basement.Position.Y + height, basement.Position.Z + length / 2));
            result.Verteces.Add(new Vertex(basement.Position.X + width / 2, basement.Position.Y + height, basement.Position.Z - length / 2));
            result.Verteces.Add(new Vertex(basement.Position.X - width / 2, basement.Position.Y + height, basement.Position.Z - length / 2));
            
            result.Faces.Add(new Face(0, 1, 2));
            result.Faces.Add(new Face(1, 2, 3));
            result.Faces.Add(new Face(0, 2, 4));
            result.Faces.Add(new Face(2, 4, 6));
            result.Faces.Add(new Face(0, 1, 5));
            result.Faces.Add(new Face(0, 4, 5));
            result.Faces.Add(new Face(1, 3, 7));
            result.Faces.Add(new Face(1, 5, 7));
            result.Faces.Add(new Face(2, 3, 7));
            result.Faces.Add(new Face(2, 6, 7));
            result.Faces.Add(new Face(4, 5, 6));
            result.Faces.Add(new Face(5, 6, 7));

            return result;
        }
        public static Mesh Pyramid(Vertex basement, double length, double width, double height)
        {

            length = length / 5;
            width = width / 5;
            height = height / 5;

            Mesh result = new Mesh();

            result.Verteces.Add(new Vertex(basement.Position.X + width / 2, basement.Position.Y, basement.Position.Z + length / 2));
            result.Verteces.Add(new Vertex(basement.Position.X - width / 2, basement.Position.Y, basement.Position.Z + length / 2));
            result.Verteces.Add(new Vertex(basement.Position.X + width / 2, basement.Position.Y, basement.Position.Z - length / 2));
            result.Verteces.Add(new Vertex(basement.Position.X - width / 2, basement.Position.Y, basement.Position.Z - length / 2));
            result.Verteces.Add(new Vertex(basement.Position.X, basement.Position.Y+height, basement.Position.Z));
            
            result.Faces.Add(new Face(0, 1, 2));
            result.Faces.Add(new Face(1, 2, 3));
            result.Faces.Add(new Face(0, 2, 4));
            result.Faces.Add(new Face(2, 3, 4));
            result.Faces.Add(new Face(1, 3, 4));
            result.Faces.Add(new Face(0, 1, 4));

            return result;
        }
        public static Mesh Frustum(Vertex basement, double length, double width, double small_height, double height)
        {
            basement.Position.X = basement.Position.X / 5;
            basement.Position.Y = basement.Position.Y / 5;
            basement.Position.Z = basement.Position.Z / 5;

            length = length / 5;
            width = width / 5;
            height = height / 5;
            small_height = small_height / 5;

            Mesh result = new Mesh();
            double widht1 = (height - small_height) * (width / 2) / height;
            double length1 = ((height - small_height) / height) * Math.Sqrt((width / 2) * (width / 2) + (length / 2) * (length / 2));
            double length2 = Math.Sqrt(length1*length1 -  widht1*widht1);
            result.Verteces.Add(new Vertex(basement.Position.X + width / 2, basement.Position.Y, basement.Position.Z + length / 2));
            result.Verteces.Add(new Vertex(basement.Position.X - width / 2, basement.Position.Y, basement.Position.Z + length / 2));
            result.Verteces.Add(new Vertex(basement.Position.X + width / 2, basement.Position.Y, basement.Position.Z - length / 2));
            result.Verteces.Add(new Vertex(basement.Position.X - width / 2, basement.Position.Y, basement.Position.Z - length / 2));
            result.Verteces.Add(new Vertex(basement.Position.X + ((height - small_height) * (width / 2) / height), basement.Position.Y + small_height, basement.Position.Z + length2));
            result.Verteces.Add(new Vertex(basement.Position.X - ((height - small_height) * (width / 2) / height), basement.Position.Y + small_height, basement.Position.Z + length2));
            result.Verteces.Add(new Vertex(basement.Position.X + ((height - small_height) * (width / 2) / height), basement.Position.Y + small_height, basement.Position.Z - length2));
            result.Verteces.Add(new Vertex(basement.Position.X - ((height - small_height) * (width / 2) / height), basement.Position.Y + small_height, basement.Position.Z - length2));

            result.Faces.Add(new Face(0, 1, 2));
            result.Faces.Add(new Face(1, 2, 3));
            result.Faces.Add(new Face(0, 2, 4));
            result.Faces.Add(new Face(2, 4, 6));
            result.Faces.Add(new Face(0, 1, 5));
            result.Faces.Add(new Face(0, 4, 5));
            result.Faces.Add(new Face(1, 3, 7));
            result.Faces.Add(new Face(1, 5, 7));
            result.Faces.Add(new Face(2, 3, 7));
            result.Faces.Add(new Face(2, 6, 7));
            result.Faces.Add(new Face(4, 5, 6));
            result.Faces.Add(new Face(5, 6, 7));

            return result;
        }
        public static Mesh HalfSphere(Vertex basement, double radius, int segments, int rings)
        {
            Mesh result = new Mesh();

            radius /= 5;

            double step = 1.0 / rings;
            result.Verteces.AddRange(CreateRing(new Vector3(basement.Position.X, basement.Position.Y + radius * (1 - step), basement.Position.Z), Math.Sqrt(radius * radius - radius * (1 - step) * radius * (1 - step)), segments));
            result.Faces.AddRange(Connect(0, result.Verteces.Count - segments, result.Verteces.Count - 1));

            for (int i = 0; i <= rings; i++)
            {
                result.Verteces.AddRange(CreateRing(new Vector3(basement.Position.X, basement.Position.Y + radius * (1 - step * i), basement.Position.Z), Math.Sqrt(radius * radius - radius * (1 - step * i) * radius * (1 - step * i)), segments));
                result.Faces.AddRange(Connect(result.Verteces.Count - segments * 2, result.Verteces.Count - segments - 1, result.Verteces.Count - segments, result.Verteces.Count - 1));
            }

            result.Verteces.Add(new Vertex(basement.Position.X, basement.Position.Y, basement.Position.Z));
            result.Faces.AddRange(Connect(result.Verteces.Count - 1, result.Verteces.Count - segments - 1, result.Verteces.Count - 2));
            
            return result;
        }
        public static Mesh Torus(Vertex basement, double radius, double radiusCicle, int segments, int vertexCount)
        {
            Mesh result = new Mesh();
            radius /= 5;
            radiusCicle /= 5;

            double angle = Math.PI * 2 / vertexCount;
            List<Vector3> res = new List<Vector3>();
            for (int i = 0; i < vertexCount; i++)
            {
                result.Verteces.AddRange(CreateRing(new Vector3(basement.Position.X, basement.Position.Y + (radiusCicle) * Math.Sin(angle*i), basement.Position.Z), radius+radiusCicle*(1+Math.Cos(angle*i)), segments));
            }
            for(int i=0; i < segments-1; i++)
            {
                result.Faces.AddRange(Connect(i,  segments-1, i + 1, segments-1, segments));
            }
            result.Faces.AddRange(Connect(0, segments-1, segments-1, segments-1, segments));
            return result;
        }
        public static Mesh FrustumUp(Vertex basement, double height, double smallRadius, double bigRadius, int vertexCount)
        {
            Mesh result = new Mesh();

            height = height / 5;
            smallRadius = smallRadius / 5;
            bigRadius = bigRadius / 5;

            result.Verteces.Add(new Vertex(basement.Position.X, basement.Position.Y + height, basement.Position.Z));
            result.Verteces.AddRange(CreateRing(new Vector3(basement.Position.X, basement.Position.Y+height, basement.Position.Z), smallRadius, vertexCount));
            result.Faces.AddRange(Connect(0, result.Verteces.Count - vertexCount, result.Verteces.Count - 1));
            result.Verteces.Add(new Vertex(basement.Position.X, basement.Position.Y, basement.Position.Z));
            result.Verteces.AddRange(CreateRing(new Vector3(basement.Position.X, basement.Position.Y, basement.Position.Z), bigRadius, vertexCount));
            result.Faces.AddRange(Connect(result.Verteces.Count - vertexCount-1, result.Verteces.Count - vertexCount, result.Verteces.Count - 1));
            result.Faces.AddRange(Connect(1, vertexCount, result.Verteces.Count - vertexCount, result.Verteces.Count - 1));
            return result;
        }
        private static List<Face> Connect(int v1, int elStart, int elEnd)
        {
            List<Face> faces = new List<Face>();

            for (int i = elStart; i < elEnd; i++)
            {
                faces.Add(new Face(v1, i, i + 1));
            }

            faces.Add(new Face(v1, elEnd, elStart));

            return faces;
        }
        private static List<Face> Connect(int el1Start, int el1End, int el2Start, int el2End)
        {
            List<Face> faces = new List<Face>();

            for (int i = 0; i < el1End - el1Start - 1; i++)
            {
                faces.Add(new Face(el1Start + i, el2Start + i, el2Start + i + 1));
                faces.Add(new Face(el1Start + i, el1Start + i + 1, el2Start + i + 1));
            }

            faces.Add(new Face(el1End - 1, el2End - 1, el2End));
            faces.Add(new Face(el1End - 1, el1End, el2End));
            faces.Add(new Face(el1End, el2End, el2Start));
            faces.Add(new Face(el1End, el1Start, el2Start));

            return faces;
        }
        private static List<Vertex> CreateRing(Vector3 center, double radius, int vertexCount)
        {
            List<Vertex> list = new List<Vertex>();

            double angle = Math.PI * 2 / vertexCount;

            for (int i = 0; i < vertexCount; i++)
            {
                list.Add(new Vertex(center.X + radius * Math.Cos(Math.PI - angle * i), center.Y , center.Z + radius *
                    Math.Sin(Math.PI - angle * i)));
            }

            return list;
        }
        private static List<Face> Connect(int el1Start, int el1End, int el2Start, int el2End,int segment)
        {
            List<Face> faces = new List<Face>();

            for (int i = 0; i < segment-1; i++)
            {
                faces.Add(new Face(el1Start + i*segment, el2Start + i*segment, el2Start + (i+1)*segment));
                faces.Add(new Face(el1Start + i*segment, el1Start + (i+1)*segment, el2Start + (i+1)*segment));
            }

            faces.Add(new Face(el1End*segment+el1Start, el2End*segment+el2Start, el2Start));
            faces.Add(new Face(el1End*segment+el1Start, el1Start, el2Start));

            return faces;
        }
    }
}
