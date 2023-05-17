using System;


class Line
{
    public static void PrintLine(int length)
    {
        if (length > 0)
        {
            Console.Write(new String('_', length));
        }
        Console.WriteLine("");
    }
}