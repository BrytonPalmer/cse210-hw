using System;

abstract class Activity
{
    private DateTime date;
    private int minutes;

    protected Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public DateTime Date => date;
    public int Minutes => minutes;

    public abstract double GetDistance(); // miles
    public abstract double GetSpeed();    // mph
    public abstract double GetPace();     // minutes per mile

    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {GetType().Name} ({Minutes} min) - " +
               $"Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace {GetPace():0.00} min/mile";
    }
}