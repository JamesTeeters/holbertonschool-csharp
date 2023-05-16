using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int rows = myMatrix.GetLength(0);
	    int columns = myMatrix.GetLength(1);
        int[,] newMatrix = new int[rows, columns];

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < columns; c++)
            {
                newMatrix[r, c] = myMatrix[r, c] * myMatrix[r, c];
            }
        }

        return (newMatrix);
    }
}