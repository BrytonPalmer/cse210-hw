// Activity class starting message w/description
// select random promt to list-off too.
// -Who are people that you appreciate?
// -What are personal strengths of yours?
// -Who are people that you have helped this week?
// -When have you felt the Holy Ghost this month?
// -Who are some of your personal heroes?

// after prompt display, countdown to begin, then prompt to start listing items
// user lists until the user selected time runs out
// program displays number of listed items by user
// finishing message by Activity class

using System;
using System.Collections.Generic;

public class Listing : Activity
{
    private readonly List<string> _prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private readonly Random _random = new();

    public Listing()
        : base(
            "Listing what's Meaningful",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
          )
    { }

    public void Run()
    {
        DisplayStartingMessage();

        // Show random prompt
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("Get ready to start listing...");
        ShowCountDown(5);

        // Collect user entries until duration expires
        List<string> items = new();
        DateTime end = DateTime.Now.AddSeconds(_duration);
        Console.WriteLine("Start listing items (press Enter after each one):");

        while (DateTime.Now < end)
        {
            string? input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input.Trim());
            }
        }

        Console.WriteLine($"You listed {items.Count} items!");
        DisplayEndingMessage();
    }
}