using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        
        int guess;
        do
        {
            Console.Write("What is your guess? ");
            string guessValue = Console.ReadLine();
            guess = int.Parse(guessValue);
        
            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else if (magicNumber == guess)
            {
                Console.WriteLine("You guessed it");
            }
        } while (magicNumber != guess);


    }
}