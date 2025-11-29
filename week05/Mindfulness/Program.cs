// I added a method to save your sessions and it gives you a count of how many you have completed.
using System;

class Program
{
    static int completedActivities = 0;
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Mindfulness Project");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Save Session");
            Console.WriteLine("5. Quit");
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
                    SaveProgress();
                    break;

                case "5":
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
    static void SaveProgress()
    {
        string filePath = "progress.txt";
        File.WriteAllText(filePath, $"Completed activities: {completedActivities}");
        Console.WriteLine($"Progress saved to {filePath}");
    }
}
