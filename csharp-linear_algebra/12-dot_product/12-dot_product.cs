using System;

class VectorMath
{
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length > 3 || vector2.Length > 3 || vector1.Length != vector2.Length)
            return -1;

        if (vector1.Length < 2 || vector2.Length < 2 || vector1.Length != vector2.Length)
            return -1;

        double result = new double();

        for (int i = 0; i < vector1.Length; i++)
        {
            result += vector1[i] * vector2[i];
        }

        return result;
    }
}