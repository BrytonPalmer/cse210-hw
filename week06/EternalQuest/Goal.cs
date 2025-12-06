using System;

public abstract class Goal
{
    // Shared attributes
    private string _shortName;
    private string _description;
    private int _points;

    // Constructor
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Properties (encapsulation)
    public string ShortName { get { return _shortName; } }
    public string Description { get { return _description; } }
    public int Points { get { return _points; } }

    // Virtual/abstract methods to be overridden
    public abstract int RecordEvent();   // Returns points earned
    public abstract bool IsComplete();   // Completion status

    // Default detail string
    public virtual string GetDetailsString()
    {
        return $"{ShortName}: {Description} ({Points} pts)";
    }

    // String representation for saving/loading
    public virtual string GetStringRepresentation()
    {
        // Format: Type|Name|Description|Points
        return $"{this.GetType().Name}|{ShortName}|{Description}|{Points}";
    }
}