using System;
using System.Numerics;
using System.Windows;

class Program
{
    public static void Main()
    {
        double[] vector1 = new double[] {1.0, 4.0};
        double[] vector2 = new double[] {2.0, -5.0};
        double[] result = new double[vector1.Length];
        
        result = VectorMath.Add(vector1, vector2);
        Console.WriteLine($"vector1 = {vector1[0],[1]} vector2 = {vector2[0],[1]} result = {result[0],[1]}");

        vector1 = new double[]{6, 3.1, -4};
        vector2 = new double[]{17, 0, -7};

        result = VectorMath.Add(vector1, vector2);
        Console.WriteLine($"vector1 = {vector1[0]} vector2 = {vector2[0]} result = {result[0]}");
    }
}