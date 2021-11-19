using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorClass
{
    internal class Vector
    {
        private double x;
        private double y;
        private double z;
        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static void ShowVector(Vector vec)
        {
            Console.WriteLine($"x = {vec.x}, y = {vec.y}, z = {vec.z}");
        }
        public static double FindLength(Vector vec)
        {
            return Math.Sqrt(vec.x * vec.x + vec.y * vec.y + vec.z * vec.z);
        }
        public static double FindScalarProduct(Vector vec1, Vector vec2)
        {
            return (vec1.x * vec2.x + vec1.y * vec2.y + vec1.z * vec2.z);
        }
        public static Vector FindCrossProduct(Vector vec1, Vector vec2)
        {
            return new Vector(vec1.y * vec2.z - vec1.z * vec2.y, vec1.z * vec2.x - vec1.x * vec2.z, vec1.x * vec2.y - vec1.y * vec2.x);
        }
        public static double FindAngle(Vector vec1, Vector vec2)
        {
            return Math.Round(Math.Acos(FindScalarProduct(vec1, vec2)/(FindLength(vec1)*FindLength(vec2)))*180/Math.PI, 2);
        }
        public static Vector FindSum(Vector vec1, Vector vec2)
        {
            return new Vector(vec1.x + vec2.x, vec1.y + vec2.y, vec1.z + vec2.z);
        }
        public static Vector FindDifference(Vector vec1, Vector vec2)
        {
            return new Vector(vec1.x - vec2.x, vec1.y - vec2.y, vec1.z - vec2.z);
        }
    }
}
