using System;

class Program
{
    static void Main(string[] args)
    {
        Random RandomNumberGenerator = new Random();
        int magicNumber = RandomNumberGenerator.Next(1, 25);

        Console.WriteLine("What's your guess? ");
        string input = Console.ReadLine();
        int userGuess = int.Parse(input);

        if (userGuess < magicNumber)
        {
            Console.WriteLine("Too low!");
            Console.WriteLine("Try again!");
        }
        else if (userGuess > magicNumber)
        {
            Console.WriteLine("Too high!");
            Console.WriteLine("Try again!");
        }
        else
        {
            Console.WriteLine("Congratulations! You guessed the magic number!");
        }
    }
}