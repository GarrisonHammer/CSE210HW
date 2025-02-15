// This class represents an individual word in the scripture
class Word
{
    public string Text { get; private set; } // Stores the word text
    public bool IsHidden { get; private set; } // Tracks if the word is hidden

    // Constructor initializes the word with its text and sets it as visible
    public Word(string text)
    {
        Text = text;
        IsHidden = false; // Initially, words are visible
    }

    // Hides the word by setting IsHidden to true
    public void Hide()
    {
        IsHidden = true;
    }

    // Returns the word text if visible, otherwise returns blank spaces
    public override string ToString()
    {
        return IsHidden ? "_____" : Text;
    }
}
