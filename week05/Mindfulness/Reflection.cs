// standard Activity starting message w/ description
// after message, select RandomPrompt to reflect on. 
// -Think of a time when you stood up for someone else.
// -Think of a time when you did something really difficult.
// -Think of a time when you helped someone in need.
// -Think of a time when you did something truly selfless.

// with promt, user will reflect on RandomQuestions from List<question>
// -Why was this experience meaningful to you?
// -Have you ever done anything like this before?
// -How did you get started?
// -How did you feel when it was complete?
// -What made this time different than other times when you were not as successful?
// -What is your favorite thing about this experience?
// -What could you learn from this experience that applies to other situations?
// -What did you learn about yourself through this experience?
// -How can you keep this experience in mind in the future?

//  7 second interval between prompts. Spinner to be displayed during interval
//  shows RandomQuestion until selected time has been reached

// finishing message from Activity class
// using System;
// using System.Collections.Generic;
// using System.Threading;
// using System.ComponentModel;
// using System.Runtime.CompilerServices;

// public class Reflection : Activity
// {
//     private List<string> questions;
//     private List<string> prompts;
//     private Random _random = new Random();

//     public Reflection(List<string> questions, List<string> prompts, int duration)
//         :base("Reflecting","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life", duration)
//     {
//         this.prompts = prompts;
//         this.questions = questions;
//     }

//     public void Run()
//     {
//         DisplayStartingMessage();

//         DisplayPrompt();

//         Console.WriteLine("Press enter When you are ready...");
//         Console.ReadLine();

//         DateTime endTime = DateTime.Now.AddSeconds(_duration);

//         while (DateTime.Now < endTime)
//         {
//             string question = GetRandomQuestion();
//             Console.WriteLine($"- {question}");

//             ShowSpinner(7);
//         }

//         DisplayEndingMessage();
//     }

//     public string GetRandomPrompt()
//     {
//         int i = _random.Next(prompts.Count);
//         return prompts[i];
//     }

//     public string GetRandomQuestion()
//     {
//         int i = _random.Next(questions.Count);
//         return questions[i];
//     }

//     public void DisplayPrompt()
//     {
//         string prompt = GetRandomPrompt();
//         Console.WriteLine($"Prompt: {prompt}");   
//     }

// }

using System;
using System.Collections.Generic;

public class Reflection : Activity
{
    private readonly List<string> _prompts = new()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private readonly List<string> _questions = new()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private readonly Random _random = new();

    public Reflection()
        : base(
            "Reflection",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
          )
    { }

    public void Run()
    {
        DisplayStartingMessage();

        // Prompt
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("Press Enter when you are ready to reflect...");
        Console.ReadLine();

        // Questions until duration expires
        DateTime end = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            string question = _questions[_random.Next(_questions.Count)];
            Console.WriteLine($"- {question}");
            ShowSpinner(7);
        }

        DisplayEndingMessage();
    }
}