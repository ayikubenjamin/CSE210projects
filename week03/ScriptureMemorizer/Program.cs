using System;

class Program
{
    static void Main(string[] args)
    {
        Reference scriptureReference = new Reference("John", 3, 16);

       Scripture scripture = new Scripture(scriptureReference, "For God so loved the world that He gave His only begotten Son that whosoever believeth in Him should not perish but have an everlasting life");

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

         while (!scripture.IsCompletelyHidden())
        {
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
                break; 

            scripture.HideRandomWords(2); 

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
        }

    }
    
}