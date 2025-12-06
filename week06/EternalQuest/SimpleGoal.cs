using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    // Constructor
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    // Record event: mark complete if not already done
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Goal '{ShortName}' completed! You earned {Points} points!");
            return Points;
        }
        else
        {
            Console.WriteLine($"Goal '{ShortName}' is already complete. No points awarded.");
            return 0;
        }
    }

    // Completion status
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Show details string
    public override string GetDetailsString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {ShortName} ({Description}) -- Worth {Points} points";
    }

    // Save/load representation
    public override string GetStringRepresentation()
    {
        // Format: SimpleGoal|Name|Description|Points|IsComplete
        return $"{this.GetType().Name}|{ShortName}|{Description}|{Points}|{_isComplete}";
    }

    // Helper for loading saved state
    public void SetComplete(bool complete)
    {
        _isComplete = complete;
    }
}