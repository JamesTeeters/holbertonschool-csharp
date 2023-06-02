using System;

class VectorMath
{
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1 is double[] && vector2 is double[] &&
            vector1.Length == 3 && vector2.Length == 3)
        {
            double[] crossMatrix = new double[]
            {
                vector1[1]*vector2[2] - vector1[2]*vector2[1],
                vector1[2]*vector2[0] - vector1[0]*vector2[2],
                vector1[0]*vector2[1] - vector1[1]*vector2[0]
            };
            return crossMatrix;
        }
        return new double[]{-1};
    }
}