using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Constructor
    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // Record progress and return points earned
    public override int RecordEvent()
    {
        _amountCompleted++;

        int earned = Points;
        if (_amountCompleted == _target)
        {
            earned += _bonus;
            Console.WriteLine($"Congratulations! You completed '{ShortName}' and earned a bonus of {_bonus} points!");
        }

        return earned;
    }

    // Completion status
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    // Show details with progress
    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {ShortName} ({Description}) -- Completed {_amountCompleted}/{_target} times";
    }

    // Save/load representation
    public override string GetStringRepresentation()
    {
        // Format: ChecklistGoal|Name|Description|Points|Target|Bonus|AmountCompleted
        return $"{this.GetType().Name}|{ShortName}|{Description}|{Points}|{_target}|{_bonus}|{_amountCompleted}";
    }

    // Helper for loading saved progress
    public void SetAmountCompleted(int completed)
    {
        _amountCompleted = completed;
    }
}