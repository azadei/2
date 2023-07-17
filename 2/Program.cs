using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        int[] numbers = { -99, 1, 4, -5, 57, -23, 9, 2, -100 };

        
        var query = from num in numbers
                    where num > 0 && num <= 100
                    select num;

       
        Console.WriteLine("The numbers within the range of 1 to 11 are:");
        foreach (int num in query)
        {
            Console.WriteLine(num + " ");
        }
    }
}