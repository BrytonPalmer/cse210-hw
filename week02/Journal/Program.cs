//I added the search function by date and keyword, undo last entry, and delete entry features. options 5, 6, 7, and 8 in the menu.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Undo last entry");
            Console.WriteLine("6. Delete entry by number");
            Console.WriteLine("7. Search entries by keyword");
            Console.WriteLine("8. Search entries by date (yyyy-MM-dd)");
            Console.WriteLine("9. Quit");

            Console.Write("Enter your choice (1-9): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string entryText = Console.ReadLine();
                    Entry newEntry = new Entry(prompt, entryText);
                    journal.AddEntry(newEntry);
                    Console.WriteLine("Entry added.");
                    break;

                case "2":
                    Console.WriteLine("\nJournal Entries:");
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("\nEnter filename to save to: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("\nEnter filename to load from: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "5":
                    journal.UndoLastEntry();
                    break;

                case "6":
                    Console.Write("Enter entry number to delete (starting from 1): ");
                    if (int.TryParse(Console.ReadLine(), out int indexToDelete))
                    {
                        journal.DeleteEntry(indexToDelete - 1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    break;
                case "7":
                    Console.Write("\nEnter keyword to search: ");
                    string keyword = Console.ReadLine();
                    journal.SearchByKeyword(keyword);
                    break;

                case "8":
                    Console.Write("\nEnter date to search (yyyy-MM-dd): ");
                    string date = Console.ReadLine();
                    journal.SearchByDate(date);
                    break;

                case "9":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 9.");
                    break;
            }
        }
    }
}
