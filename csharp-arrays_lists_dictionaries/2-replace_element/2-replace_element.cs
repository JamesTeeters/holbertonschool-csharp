using System;

class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        int[] new_array = array;

        if (index > array.Length -1 || index < 0)
        {
            Console.WriteLine("Index out of range");
            return (array);
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (index == i) 
            {
                new_array[i] = n;
            }    
        }

        return (new_array);
    }
}