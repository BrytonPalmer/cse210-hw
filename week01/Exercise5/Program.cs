using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("WELCOME TO THE PROGRAM!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();
            int favoriteNumber = int.Parse(input);
            return favoriteNumber;
        }
        static int SquareNumber(int number)
        {
            return number * number;
        }
        static void DisplayResult(string userName, int SquareNumber)
        {
            Console.WriteLine($"{userName}, the square fo your favorite number is {SquareNumber}.");

        }
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNumber);
        DisplayResult(userName, squaredNumber);
    }
}