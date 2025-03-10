using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        List<int> numbers = new List<int>();
        int number;
        

        do
        {
            Console.Write("Enter a number: ");
            string textvalue =Console.ReadLine();
            number = int.Parse(textvalue);
            if (number != 0)
            {
                numbers.Add(number);
            }
            

        } while (number != 0);
        
        int total = 0;
        for (int i =0; i < numbers.Count; i++)
        {
            total += numbers[i];
        }
        Console.WriteLine($"The sum is {total}");

        int count = numbers.Count;
        double Average = (double)total/count;
        Console.WriteLine($"The Average is {Average}");
        
        int largest = 0;
        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }
        Console.WriteLine($"The largest number is {largest}");
    }
}