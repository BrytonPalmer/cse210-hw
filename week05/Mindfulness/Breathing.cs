// standard starting message from Activity class w/ description
// description of activity under message
// after starting message: on enter, alternating messages (breathe in.. breathe out..)
// four second intervals between (breathe..) messages, shows interval count-down 
// The program runs for a user specified amount of time/seconds chosen in Program.cs
// when selected time ends, a Finishing message will run from Activity class

// using System;
// using System.Threading;
// public class Breathing : Activity
// {
//     public Breathing(int duration)
//         :base("Breathing", 
//               "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 
//               duration)
//     {  
//     }

//     public void Run()
//     {
//         DisplayStartingMessage();

//         Console.WriteLine("Press Enter to Begin...");
//         Console.ReadLine();

//         DateTime endTime = DateTime.Now.AddSeconds(_duration);
//         bool breatheIn = true;

//         while (DateTime.Now < endTime)
//         {
//             if (breatheIn)
//             {
//                 Console.WriteLine("Breathe in...");
//             }
//             else
//             {
//                 Console.WriteLine("Breathe Out...");
//             }
//             ShowCountDown(5);

//             breatheIn = !breatheIn;
//         }

//         DisplayEndingMessage();
//     }
// }
using System;

public class Breathing : Activity
{
    public Breathing()
        : base(
            "Breathing",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
          )
    { }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime end = DateTime.Now.AddSeconds(_duration);
        bool inhale = true;

        while (DateTime.Now < end)
        {
            Console.WriteLine(inhale ? "Breathe in..." : "Breathe out...");
            ShowCountDown(4);
            inhale = !inhale;
        }

        DisplayEndingMessage();
    }
}