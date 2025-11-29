
using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    // Standard starting message: name, description, prompt duration, prepare pause
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to {_name}.");
        Console.WriteLine(_description);
        Console.WriteLine();

        _duration = PromptForDurationSeconds();

        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
        ShowCountDown(3);
        Console.WriteLine();
    }

    // Standard ending message: good job, recap activity name and duration, pause
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done! You did a great job.");
        ShowSpinner(2);
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(3);
        Console.WriteLine();
    }

    // Shared animations
    protected void ShowSpinner(int seconds)
    {
        string[] frames = { "|", "/", "-", "\\" };
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < end)
        {
            Console.Write(frames[i]);
            Thread.Sleep(1000);
            Console.Write("\b");
            i = (i + 1) % frames.Length;
        }
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
        Console.WriteLine();
    }

    // Duration prompt used by all activities (validated)
    private int PromptForDurationSeconds()
    {
        while (true)
        {
            Console.Write("Enter duration in seconds: ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int seconds) && seconds > 0)
                return seconds;

            Console.WriteLine("Please enter a positive integer.");
        }
    }
}
