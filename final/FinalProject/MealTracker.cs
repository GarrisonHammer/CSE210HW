using System;

class MealTracker : TrackerBase
{
    public int MealsLogged { get; private set; }

    public override void LogEntry()
    {
        Console.WriteLine("Meal logged successfully!");
        MealsLogged++;
        LogEntries.Add($"Meal {MealsLogged} logged on {DateTime.Now}");
    }

    public void SetProgress(int value)
    {
        MealsLogged = value;
    }
}
