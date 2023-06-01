using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix1 = { { -6, 1 }, { -8, 7 } };
        double[,] matrix2 = { { 9, -2 }, { -1, 2 } };
        double[,] result;

        result = MatrixMath.Add(matrix1, matrix2);

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                Console.Write(result[i, j]);
                if (j != matrix1.GetLength(1) - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}