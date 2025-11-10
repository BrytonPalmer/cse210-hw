using System;
class Program
{
    static void Main(string[] args)
    {
        bool keepPlaying = true;
        while (keepPlaying)
        {
            Console.WriteLine("HEY YOU THERE! This is the Scripture Memorizer! \n Press enter to begin, type 'quit' to quit.");
            Console.ReadLine();
            Console.Clear();

            List<Scripture> scriptures = new List<Scripture>
            {
                    new Scripture(new Reference("John", 3, 16),
                    "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
                    new Scripture(new Reference("Proverbs", 3, 5, 6),
                    "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
                    new Scripture(new Reference("Helaman", 5, 12),
                    "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall."),
                    new Scripture(new Reference("2 Nephi", 2, 25),
                    "Adam fell that men might be; and men are, that they might have joy.")
                };

            Random random = new Random();
            int index = random.Next(scriptures.Count);
            Scripture selectedScripture = scriptures[index];

            while (true)
            {
                Console.WriteLine($"\n{selectedScripture.GetReference()}\n");
                Console.WriteLine(selectedScripture.GetDisplayText());
                Console.WriteLine("\nPress Enter to hide more words, type 'reveal' to show all words, or 'quit' to exit.");
                string input = Console.ReadLine().ToLower();
                if (input == "quit")
                {
                    break;
                }
                else if (input == "reveal")
                {
                    selectedScripture.RevealAllWords();
                }
                else if (string.IsNullOrWhiteSpace(input))
                {
                    selectedScripture.HideRandomWords();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please press Enter, type 'reveal', or 'quit'.");
                    Console.ReadLine();
                }
                if (selectedScripture.AllWordsHidden())
                {
                    Console.WriteLine("\nAll words are hidden! Resetting scripture.");
                    selectedScripture.ResetWords();
                }
                else
                {
                    Console.Clear();
                }
            }
            Console.WriteLine("Would you like to Go again? (yes/no)");
            string againInput = Console.ReadLine().ToLower();
            if (againInput != "yes")
            {
                keepPlaying = false;
            }
        }
        Console.WriteLine("Thank you for using the Scripture Memorizer. Goodbye!");
    }

}