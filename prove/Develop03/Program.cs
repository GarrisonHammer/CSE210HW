//to add creativity I add a section that allows the user to
//choose how many words they hide per iteration of the program 

using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a scripture reference
        Console.WriteLine("Enter the scripture reference (e.g., John 3:16):");
        string referenceInput = Console.ReadLine()?.Trim();

        // Prompt the user to enter the scripture text
        Console.WriteLine("Enter the scripture text:");
        string textInput = Console.ReadLine()?.Trim();

        // Create a Reference object to store the scripture reference
        Reference scriptureReference = new Reference(referenceInput);

        // Create a Scripture object to store words and manage hiding functionality
        Scripture scripture = new Scripture(scriptureReference, textInput);

        // Ask the user how many words they want to hide per round
        Console.WriteLine("How many words would you like to hide each round?");
        int wordsToHide = int.TryParse(Console.ReadLine(), out int num) ? num : 2; // Default to 2 if invalid input

        // Main loop - continues until all words are hidden or the user quits
        while (!scripture.AllWordsHidden())
        {
            Console.Clear(); // Clear the console screen for better visibility
            scripture.Display(); // Display the scripture with hidden words

            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "quit")
            {
                Console.WriteLine("Thank you for using the Scripture Memorizer.");
                return; // Exit the program
            }

            scripture.HideRandomWords(wordsToHide); // Hide the specified number of words
        }

        // Once all words are hidden, display the final message
        Console.Clear();
        Console.WriteLine("All words are hidden. You've memorized it!");
        Console.WriteLine("Thank you for using the Scripture Memorizer.");
    }
}
