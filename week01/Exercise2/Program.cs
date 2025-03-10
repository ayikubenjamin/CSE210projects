using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string valueEntered = Console.ReadLine();
        int percentage = int.Parse(valueEntered);
        string letter ="";

        if (percentage >= 90 )
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
             letter = "B";
        }
        else if (percentage >= 70)
        {
             letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else if (percentage < 60)
        {
           letter = "F"; 
        }
        Console.WriteLine($"Your grade is {letter}");

        if (percentage >=70)
        {
            Console.WriteLine("Congratulations, You Passed");
        }
        else
        {
            Console.WriteLine("Didn't make the mark, Work hard next time");
        }
    }
}