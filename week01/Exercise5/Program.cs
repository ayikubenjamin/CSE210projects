using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favouriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favouriteNumber);
        DisplayResult(name, squaredNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please Enter Your Name: ");
        return Console.ReadLine();
        
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favourite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int favouriteNumber)
    {
        return favouriteNumber * favouriteNumber;
        
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");

    }
    
}