using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Running(new DateTime(2023, 3, 15), 30, 3.0),
            new Cycling(new DateTime(2023, 3, 16), 45, 15.0),
            new Swimming(new DateTime(2023, 3, 17), 60, 40)
        };

        foreach (Activity act in activities)
        {
            Console.WriteLine(act.GetSummary());
        }
    }
}
