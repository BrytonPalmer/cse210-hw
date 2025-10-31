using System;

class Program
{
    static void Main(string[] args)
    {
        Random RandomNumberGenerator = new Random();
        int magicNumber = RandomNumberGenerator.Next(1, 11);

        Console.WriteLine("What's your guess? ");
        string input = Console.ReadLine();
        int userGuess = int.Parse(input);

        do
        {
            while (userGuess < magicNumber)
            {
                Console.WriteLine("Too low! Try again: ");
                input = Console.ReadLine();
                userGuess = int.Parse(input);
            }
            while (userGuess > magicNumber)
            {
                Console.WriteLine("Too high! Try again: ");
                input = Console.ReadLine();
                userGuess = int.Parse(input);
            }
            if (userGuess == magicNumber)
            {
                Console.WriteLine("Congratulations! You guessed the correct number!");
            }
        } while (userGuess != magicNumber);
    }
}