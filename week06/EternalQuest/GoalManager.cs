using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager() { }

    // Display current score
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYour current score: {_score} points");
    }

    // List goal names (for selection)
    public void ListGoalNames()
    {
        Console.WriteLine("\nGoals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
        }
    }

    // List goal details (with completion status)
    public void ListGoalDetails()
    {
        Console.WriteLine("\nGoal Details:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    // Create a new goal
    public void CreateGoal()
    {
        Console.WriteLine("\nSelect goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter short name: ");
        string name = Console.ReadLine();

        Console.Write("Enter description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    // Record an event (mark goal progress)
    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("\nSelect goal number to record: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            int earned = _goals[index].RecordEvent();
            _score += earned;
            Console.WriteLine($"You earned {earned} points!");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    // Save goals and score to file
    public void SaveGoals()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                writer.WriteLine(g.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    // Load goals and score from file
    public void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            _goals.Clear();
            string[] lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                if (type == "SimpleGoal")
                {
                    bool complete = bool.Parse(parts[4]);
                    SimpleGoal sg = new SimpleGoal(name, description, points);
                    if (complete) sg.RecordEvent(); // mark complete
                    _goals.Add(sg);
                }
                else if (type == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(name, description, points));
                }
                else if (type == "ChecklistGoal")
                {
                    int target = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);
                    int completed = int.Parse(parts[6]);
                    ChecklistGoal cg = new ChecklistGoal(name, description, points, target, bonus);
                    cg.SetAmountCompleted(completed);
                    _goals.Add(cg);
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
    // Leveling system: every 1000 points = new level
public void CheckLevelUp()
{
    int level = _score / 1000;
    Console.WriteLine($"You are now Level {level}!");
    AwardBadge(level);
}

// Fun badges for milestones
private void AwardBadge(int level)
{
    if (level == 1) Console.WriteLine("🏅 Badge Earned: Beginner Adventurer!");
    else if (level == 5) Console.WriteLine("🎖 Badge Earned: Scripture Scholar!");
    else if (level == 10) Console.WriteLine("🌟 Badge Earned: Eternal Champion!");
}

}
