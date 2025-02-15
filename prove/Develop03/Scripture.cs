using System;
using System.Collections.Generic;
using System.Linq;

// This class manages the scripture text, reference, and word hiding functionality
class Scripture
{
    public Reference ScriptureReference { get; private set; } // Stores the scripture reference
    private List<Word> Words; // List of words in the scripture
    private Random _random; // Random generator for hiding words

    // Constructor initializes the scripture with reference and text
    public Scripture(Reference reference, string text)
    {
        ScriptureReference = reference;
        Words = text.Split(' ').Select(w => new Word(w)).ToList(); // Convert words into Word objects
        _random = new Random();
    }

    // Displays the scripture, replacing hidden words with underscores
    public void Display()
    {
        Console.WriteLine(ScriptureReference.Text); // Print the scripture reference

        foreach (Word word in Words)
        {
            Console.Write(word + " "); // Print each word (hidden words appear as underscores)
        }

        Console.WriteLine(); // New line for better readability
    }

    // Hides a specified number of random words
    public void HideRandomWords(int count)
    {
        // Get a list of words that are still visible
        var visibleWords = Words.Where(w => !w.IsHidden).ToList();

        // If all words are already hidden, return
        if (visibleWords.Count == 0) return;

        // Make sure we don’t try to hide more words than are available
        count = Math.Min(count, visibleWords.Count);

        for (int i = 0; i < count; i++)
        {
            int index = _random.Next(visibleWords.Count); // Pick a random visible word
            visibleWords[index].Hide(); // Hide the word
            visibleWords.RemoveAt(index); // Remove from list to avoid selecting it again
        }
    }

    // Checks if all words in the scripture are hidden
    public bool AllWordsHidden()
    {
        return Words.All(w => w.IsHidden); // Returns true if all words are hidden
    }
}
