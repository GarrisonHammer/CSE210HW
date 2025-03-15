abstract class Goal
{
    protected string name;
    protected int points;

    public Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
    }

    // Abstract methods to be implemented by derived classes
    public abstract int RecordEvent();
    public abstract string GetStatus();
    public abstract string ToFileString();

    // Factory method to create goals from saved file data
    public static Goal FromFileString(string data)
    {
        string[] parts = data.Split('|');
        switch (parts[0])
        {
            case "Simple": return new SimpleGoal(parts[1], int.Parse(parts[2]), bool.Parse(parts[3]));
            case "Eternal": return new EternalGoal(parts[1], int.Parse(parts[2]));
            case "Checklist": return new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
            default: throw new Exception("Unknown goal type.");
        }
    }
}
