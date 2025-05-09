using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;

        while (userChoice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out userChoice))
            {
                Console.Clear();

                switch (userChoice)
                {
                    case 1:
                        BreathingActivity breathing = new BreathingActivity();
                        breathing.Run();
                        break;

                    case 2:
                        ReflectingActivity reflecting = new ReflectingActivity();
                        reflecting.Run();
                        break;

                    case 3:
                        ListingActivity listing = new ListingActivity();
                        listing.Run();
                        break;

                    case 4:
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a number between 1 and 4.");
                        break;
                }

                if (userChoice != 4)
                {
                    Console.WriteLine("\nPress Enter to return to the menu...");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
                Console.ReadLine();
            }
        }
    }
    
}