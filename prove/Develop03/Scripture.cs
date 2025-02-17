using System;
using System.Collections.Generic;
using System.Linq;

// This class manages the scripture text, reference, and word hiding functionality
class Scripture
{
    private Reference _scriptureReference; // Private member variable for scripture reference
    private List<Word> _words; // Private list of words in the scripture
    private Random _random; // Private random generator for hiding words

    // Constructor initializes the scripture with reference and text
    public Scripture(Reference reference, string text)
    {
        _scriptureReference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList(); // Convert words into Word objects
        _random = new Random();
    }

    // Displays the scripture, replacing hidden words with underscores
    public void Display()
    {
        Console.WriteLine(_scriptureReference.GetText()); // Print the scripture reference

        foreach (Word word in _words)
        {
            Console.Write(word + " "); // Print each word (hidden words appear as underscores)
        }

        Console.WriteLine(); // New line for better readability
    }

    // Public method to hide a specified number of random words
    public void HideRandomWords(int count)
    {
        // Get a list of words that are still visible
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

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

    // Public method to check if all words in the scripture are hidden
    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden()); // Returns true if all words are hidden
    }
}
