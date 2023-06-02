using System;
using System.Collections;

class MatrixMath
{
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2 &&
            (matrix[0, 0]*matrix[1, 1] - matrix[0, 1]*matrix[1, 0]) != 0)
        {
            double[,] inverseMatrix = new double[,] {
                {matrix[1, 1], (-1)*matrix[0,1]},
                {(-1)*matrix[1,0], matrix[0, 0]}
            };

            double determinatMatrix = 1/(matrix[0, 0]*matrix[1, 1] - matrix[0, 1]*matrix[1, 0]);

            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    inverseMatrix[row, col] = Math.Round(determinatMatrix*inverseMatrix[row, col], 2);
                }
            }
            return inverseMatrix;
        }
        return new double[,] {{-1}};
    }
}