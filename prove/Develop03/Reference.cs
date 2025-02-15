// This class represents the reference of the scripture (e.g., "John 3:16")
class Reference
{
    public string Text { get; private set; } // Stores the scripture reference

    // Constructor initializes the reference text
    public Reference(string text)
    {
        Text = text;
    }
}
