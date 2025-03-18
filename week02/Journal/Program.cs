using System;

class Program
{
    static void Main()
    {
         List<string> prompts = new List<string>
        {
            "What was the best part of your day?",
            "If I had one thing I could do over today, what would it be?",
            "What made me smile today?",
            "What challenges did I face today?",
            "What am I grateful for today?"
        };
        PromptGenerator promptGenerator = new PromptGenerator(prompts);
        Journal myJournal = new Journal(promptGenerator);
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string userEntry = Console.ReadLine();

                    
                    string date = DateTime.Now.ToShortDateString();
                    Entry newEntry = new Entry(date, prompt, userEntry);
                    myJournal.AddEntry(newEntry);
                    Console.WriteLine("Entry saved!\n");
                    break;

                case "2":
                    
                    myJournal.DisplayAll();
                    break;

                case "3":
                    
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    myJournal.LoadFromFile(loadFile);
                    break;

                case "4":
                    
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    myJournal.SaveToFile(saveFile);
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
