using System.ComponentModel;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;


    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done");
        Console.WriteLine($"You have done {_duration} seconds of {_name}");
    }

    public void ShowSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
    {
        Console.Write(i);
        Thread.Sleep(1000); 
    }
    }
}