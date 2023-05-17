using System;


class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length <= 0)
        {
            Console.WriteLine("\n");
        }
        for (int y = 0; y < length; y++)
        {
            for (int x = 0; x < y; x++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("\\");
        }
        
    }
}