using System;
using System.Collections;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double cos = Math.Cos(angle);
        double sin = Math.Sin(angle);
        double[,] rotateMatrix = new double[,]{{cos, sin},{-sin, cos}};

        if (matrix is double[,] && matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            int mRow1 = matrix.GetLength(0);
            int mCol1 = matrix.GetLength(1);
            int mRow2 = rotateMatrix.GetLength(0);
            int mCol2 = rotateMatrix.GetLength(1);

            double[,] matrixMul = new double[mRow1, mCol2];

            for (int col = 0; col < mCol1; col++)
            {
                for (int row = 0; row < mRow1; row++)
                {
                    for (int i = 0; i < mCol2; i++)
                    {
                        matrixMul[row, i] = Math.Round(matrixMul[row, i] + matrix[row, col] * rotateMatrix[col, i], 2);
                    }
                }
            }
            return matrixMul
        }
        else
        {
            return new double[,]{{-1}};
        }
    }
}