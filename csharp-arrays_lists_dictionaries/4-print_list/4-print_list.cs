using System;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        List<int> new_list = new List<int>();
        if (size == 0)
            Console.WriteLine("");
        
        else
        {
            for (int i = 0; i < size; i++)
            {
                new_list.Add(i);
                Console.Write(new_list[i]);
                if (i < size - 1)
                    Console.Write(" ");
            }
            Console.WriteLine("");
        }
        return (new_list);
    }
}