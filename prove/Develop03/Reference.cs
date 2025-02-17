// This class represents the reference of the scripture (e.g., "John 3:16")
class Reference
{
    private string _text; // Private member variable for scripture reference

    // Constructor initializes the reference text
    public Reference(string text)
    {
        _text = text;
    }

    // Public method to return the reference text (Encapsulation: prevents direct access)
    public string GetText()
    {
        return _text;
    }
}
