using System;

class MatrixMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(0) > 3 || matrix1.GetLength(0) < 2 || matrix1 != matrix2)
            return new double[,] {{-1}};
        
        if (matrix2.GetLength(0) > 3 || matrix2.GetLength(0) < 2 || matrix1 != matrix2)
            return new double[,] {{-1}};

        double new_matrix = new double[,];

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; i < matrix2.GetLength(0); i++)
            {
                new_matrix[i,j] = matrix1[i,j] + matrix2[i,j];
            }
        }

        return new_matrix;
    }
}