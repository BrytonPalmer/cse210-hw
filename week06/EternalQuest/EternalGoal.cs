using System;

public class EternalGoal : Goal
{
    // Constructor
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    // Each time you record, you earn points (goal never completes)
    public override int RecordEvent()
    {
        Console.WriteLine($"Event recorded for '{ShortName}'. You earned {Points} points!");
        return Points;
    }

    // Eternal goals are never complete
    public override bool IsComplete()
    {
        return false;
    }

    // Show details string
    public override string GetDetailsString()
    {
        return $"[∞] {ShortName} ({Description}) -- Earns {Points} points each time";
    }

    // Save/load representation
    public override string GetStringRepresentation()
    {
        // Format: EternalGoal|Name|Description|Points
        return $"{this.GetType().Name}|{ShortName}|{Description}|{Points}";
    }
}