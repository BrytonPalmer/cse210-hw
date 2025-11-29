// // this class will be the base for all other derived classes. prompts/duration/menus/finishing message
// using System;
// using System.Threading;
// public class Activity
// {
//     protected string _name = "";
//     protected string _description = "";
//     protected int _duration = 50;

//     public Activity(string aName, string aDescription, int aDuration)
//     {
//         _name = aName;
//         _description = aDescription;
//         _duration = aDuration;
//     }
//     public void DisplayStartingMessage()
//     {
//         Console.WriteLine($"Welcome to the {_name}...");
//         Console.WriteLine(_description);
//         Console.WriteLine($"This will last for {_duration} seconds.");
//         Console.WriteLine("Get Ready!");
//     }

//     public void DisplayEndingMessage()
//     {
//         Console.WriteLine($"Great job with the {_name} activity!");
//         Console.WriteLine("Take a moment to reflect on what you learned.");
//     }

//     public void ShowSpinner(int seconds)
//     {
//         string[] spinner = {"|", "/", "-", "\\", "|", "/", "-", "\\",};
//         DateTime endTime = DateTime.Now.AddSeconds(seconds);
//         int i = 0;

//         while (DateTime.Now < endTime)
//         {
//             Console.Write(spinner[i]);
//             Thread.Sleep(200);
//             Console.Write("\b");
//             i = (i + 1) % spinner.Length;
//         }
//     }

//     public void ShowCountDown(int seconds)
//     {
//         for (int i = seconds; i > 0; i--)
//         {
//             Console.WriteLine(i);
//             Thread.Sleep(1000);
//         }
//         Console.WriteLine("Go!");
//     }
// }
using System;
using System.Threading;

public class Activity
{
    // Encapsulated shared state
    protected string _name;
    protected string _description;
    protected int _duration; // seconds for current run

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0; // set at runtime per activity
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
            Thread.Sleep(150);
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
