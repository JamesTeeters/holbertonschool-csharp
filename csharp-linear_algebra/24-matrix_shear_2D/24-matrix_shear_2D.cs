using System;
using System.Collections;

class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        int shearX = 0, shearY = 0;

        if (direction == 'x') { shearY = 1; }
        else if (direction == 'y') { shearX = 1; }
        else { return new double[,]{{-1}}; }

        double[,] shearMatrix = new double[,] { 
            {1, shearX * factor},
            {shearY * factor, 1}
        };
        
        if (matrix is double[,] && matrix.GetLength(1) == 2 && matrix.GetLength(0) == 2)
        {
            int mRow1 = matrix.GetLength(0);
            int mCol1 = matrix.GetLength(1);
            int mRow2 = shearMatrix.GetLength(0);
            int mCol2 = shearMatrix.GetLength(1);

            double[,] matrixMul = new double[mRow1, mCol2];

            for (int col = 0; col < mCol1; col++)
            {
                for (int row = 0; row < mRow1; row++)
                {
                    for (int i = 0; i < mCol2; i++)
                    {
                        matrixMul[row, i] += matrix[row, col] * shearMatrix[col, i];
                    }
                }
            }
            return matrixMul;
        }
        else  { return new double[,]{{-1}}; }
    }
}