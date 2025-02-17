// This class represents an individual word in the scripture
class Word
{
    private string _text; // Private member variable for word text
    private bool _isHidden; // Private flag to track if the word is hidden

    // Constructor initializes the word with its text and sets it as visible
    public Word(string text)
    {
        _text = text;
        _isHidden = false; // Words start as visible
    }

    // Public method to hide the word (Encapsulation: controls modification)
    public void Hide()
    {
        _isHidden = true;
    }

    // Public method to check if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Returns the word text if visible, otherwise returns blank spaces
    public override string ToString()
    {
        return _isHidden ? "_____" : _text;
    }
}
