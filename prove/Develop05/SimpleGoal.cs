class SimpleGoal : Goal
{
    private bool isComplete;

    public SimpleGoal(string name, int points, bool isComplete = false) : base(name, points)
    {
        this.isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (!isComplete)
        {
            isComplete = true;
            return points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        return $"[{(isComplete ? "X" : " ")}] {name}";
    }

    public override string ToFileString()
    {
        return $"Simple|{name}|{points}|{isComplete}";
    }
}
