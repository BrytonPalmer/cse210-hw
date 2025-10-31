using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade Percentage: ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);


        if (grade >= 90)
        {
            Console.WriteLine("Your grade is an A.");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Your grade is a B.");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your grade is a C.");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Your grade is a D.");
        }
        else
        {
            Console.WriteLine("Your grade is an F.");
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congradulations, you PASSED!");
        }
        else
        {
            Console.WriteLine("Sorry, you FAILED. Better luck next time!");
        }

    }
}