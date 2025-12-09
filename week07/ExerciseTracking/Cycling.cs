using System;

class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        this.speed = speed;
    }

    public override double GetDistance() => (speed * Minutes) / 60.0;
    public override double GetSpeed() => speed;
    public override double GetPace() => Minutes / GetDistance();
}