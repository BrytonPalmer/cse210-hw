using System;

class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        this.laps = laps;
    }

    // Distance in miles: laps * 50m per lap / 1000 (km) * 0.62 (km→mile conversion)
    public override double GetDistance() => (laps * 50.0 / 1000.0) * 0.62;
    public override double GetSpeed() => (GetDistance() / Minutes) * 60.0;
    public override double GetPace() => Minutes / GetDistance();
}