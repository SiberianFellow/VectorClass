using System;
using System.Collections.Generic;
using System.Linq;

namespace VectorClass 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Vector a = new Vector(1, 1, 0);
                Vector b = new Vector(0, 1, 1);
                Console.WriteLine("Первый вектор: ");
                Vector.ShowVector(a);
                Console.WriteLine("Второй вектор: ");
                Vector.ShowVector(b);
                Console.WriteLine("Length a: " + Vector.FindLength(a));
                Console.WriteLine("Length b: " + Vector.FindLength(b));
                Console.WriteLine("Scalar product: " + Vector.FindScalarProduct(a, b));
                Vector crossProduct = Vector.FindCrossProduct(a, b);
                Console.Write("Cross product: ");
                Vector.ShowVector(crossProduct);
                Console.WriteLine("Angle (measured in degrees) : " + Vector.FindAngle(a, b));
                Vector summaryVector = Vector.FindSum(a, b);
                Console.Write("Summary vector: ");
                Vector.ShowVector(summaryVector);
                Vector differenceVector = Vector.FindDifference(a, b);
                Console.Write("Difference vector: ");
                Vector.ShowVector(differenceVector);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}