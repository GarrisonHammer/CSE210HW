public class WritingAssignment : Assignment
{
    private string _title;
    //writing assignment needs 3 paramaters, 2 from the base
public WritingAssignment(string studentName, string topic, string title)
    : base(studentName, topic)

    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        //we need the getter her becasue _student name is provate
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}