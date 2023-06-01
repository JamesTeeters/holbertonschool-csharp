using System;
using System.Collections;

class MatrixMath
{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1 is double[,] && matrix2 is double[,] &&
            matrix2.GetLength(0) == matrix1.GetLength(1))
        {
            int mRow1 = matrix1.GetLength(0);
            int mCol1 = matrix1.GetLength(1);
            int mRow2 = matrix2.GetLength(0);
            int mCol2 = matrix2.GetLength(1);

            double[,] matrixMul = new double[mRow1, mCol2];

            for (int col = 0; col < mCol1; col++)
            {
                for (int row = 0; row < mRow1; row++)
                {
                    for (int i = 0; i < mCol2; i++)
                    {
                        matrixMul[row, i] += matrix1[row, col] * matrix2[col, i];
                    }
                }
            } 
            return matrixMul;
        }
        else 
        {
            return new double[,]{{-1}};
        }
    }
}