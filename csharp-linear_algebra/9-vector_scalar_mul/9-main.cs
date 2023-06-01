using System;
using System.Numerics;
using System.Windows;

class Program
{
    public static void Main()
    {
        double[] vector = new double[] {-3.0, 7.0, 9};
        double scalar = 4.0;
        double[] kVector = {};
        
        kVector = VectorMath.Multiply(vector, scalar);
        Console.Write("Resulting vector is: { ");
        for (int i = 0; i < kVector.Length; i++)
        {
            Console.Write($"{kVector[i]} ");
        }
        Console.WriteLine("}");

        double[] numTest = {-2.0, 3, 5, 7 };
        kVector = VectorMath.Multiply(numTest, scalar);
        Console.WriteLine($"It's not a 2D or 3D Vector: \n {{ {kVector[0]} }}");
    }
}