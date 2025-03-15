class ChecklistGoal : Goal
{
    private int count;
    private int target;
    private int bonus;

    public ChecklistGoal(string name, int points, int target, int bonus, int count = 0) : base(name, points)
    {
        this.target = target;
        this.bonus = bonus;
        this.count = count;
    }

    public override int RecordEvent()
    {
        count++;
        return count == target ? points + bonus : points;
    }

    public override string GetStatus()
    {
        return $"[{count}/{target}] {name}";
    }

    public override string ToFileString()
    {
        return $"Checklist|{name}|{points}|{target}|{bonus}|{count}";
    }
}
