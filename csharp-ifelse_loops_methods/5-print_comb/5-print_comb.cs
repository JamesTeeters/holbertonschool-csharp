using System;

class Program
{
    static void Main(string[] args)
    {
	    for (int num = 0 ; num <= 99 ; num++)
	    {
		    if (num == 99)
		    {
		    	Console.WriteLine($"{num:00}");	
		    }
		    else{
	    		Console.Write($"{num:00}, ");
	    	}
    	}
    }
}