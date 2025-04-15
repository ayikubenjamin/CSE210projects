public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity helps you relax by guiding you through slow breathing";
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(_description);
        Console.WriteLine("How long in seconds would you like to take this session");
        string valueEntered = Console.ReadLine();
        _duration = int.Parse(valueEntered);
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while(DateTime.Now < endTime)
        {
            Console.WriteLine("Breath in...");
            ShowCountDown(3);
            Console.WriteLine($"Breathe out...");
            ShowCountDown(3);
        }
        DisplayEndingMessage();
    }
    
}