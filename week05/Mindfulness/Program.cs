// using System;
// using System.Collections.Generic;
// using System.IO;

// class Program
// {
//     static string filePath = "sessions.txt";

//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello World! This is the Mindfulness Project.");

//         // Load past sessions
//         LoadSessions();

//         Console.WriteLine("\nPlease choose an activity:");
//         Console.WriteLine("1. Breathing");
//         Console.WriteLine("2. Reflection");
//         Console.WriteLine("3. Listing");

//         string choice = Console.ReadLine();

//         switch (choice)
//         {
//             case "1":
//                 RunBreathing();
//                 break;
//             case "2":
//                 RunReflection();
//                 break;
//             case "3":
//                 RunListing();
//                 break;
//             default:
//                 Console.WriteLine("Invalid choice. Exiting program.");
//                 break;
//         }
//     }

//     static void RunBreathing()
//     {
//         Console.WriteLine("Enter duration in seconds for Breathing:");
//         int duration = int.Parse(Console.ReadLine());

//         Breathing breathingActivity = new Breathing(duration);
//         breathingActivity.Run();

//         SaveSession("Breathing", duration);
//     }

//     static void RunReflection()
//     {
//         var prompts = new List<string>
//         {
//             "Think of a time when you stood up for someone else.",
//             "Think of a time when you did something really difficult.",
//             "Think of a time when you helped someone in need.",
//             "Think of a time when you did something truly selfless."
//         };

//         var questions = new List<string>
//         {
//             "Why was this experience meaningful to you?",
//             "Have you ever done anything like this before?",
//             "How did you get started?",
//             "How did you feel when it was complete?",
//             "What made this time different than other times when you were not as successful?",
//             "What is your favorite thing about this experience?",
//             "What could you learn from this experience that applies to other situations?",
//             "What did you learn about yourself through this experience?",
//             "How can you keep this experience in mind in the future?"
//         };

//         Reflection reflectionActivity = new Reflection(questions, prompts);
//         reflectionActivity.Run();

//         SaveSession("Reflection", 50); // default duration
//     }

//     static void RunListing()
//     {
//         var prompts = new List<string>
//         {
//             "Who are people that you appreciate?",
//             "What are personal strengths of yours?",
//             "Who are people that you have helped this week?",
//             "When have you felt the Holy Ghost this month?",
//             "Who are some of your personal heroes?"
//         };

//         Console.WriteLine("Enter duration in seconds for Listing:");
//         int duration = int.Parse(Console.ReadLine());

//         Listing listingActivity = new Listing(prompts, duration);
//         listingActivity.Run();

//         SaveSession("Listing", duration);
//     }

//     static void SaveSession(string activityName, int duration)
//     {
//         string sessionData = $"{DateTime.Now}: {activityName} for {duration} seconds";
//         File.AppendAllText(filePath, sessionData + Environment.NewLine);
//     }

//     static void LoadSessions()
//     {
//         if (File.Exists(filePath))
//         {
//             Console.WriteLine("Previous sessions:");
//             string[] sessions = File.ReadAllLines(filePath);
//             foreach (string session in sessions)
//             {
//                 Console.WriteLine(session);
//             }
//         }
//         else
//         {
//             Console.WriteLine("No previous sessions found.");
//         }
//     }
// }

using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Mindfulness Project");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an activity (1-4): ");

            string? choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    new Breathing().Run();
                    break;

                case "2":
                    new Reflection().Run();
                    break;

                case "3":
                    new Listing().Run();
                    break;

                case "4":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please select 1-4.");
                    break;
            }

            Console.WriteLine("Press Enter to return to the menu...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
