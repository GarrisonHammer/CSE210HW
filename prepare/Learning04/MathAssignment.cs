public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    //math assignemt has 4 parameters and 2 are from the base assignment
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        //here we set the math assignment specific variables
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }

}

