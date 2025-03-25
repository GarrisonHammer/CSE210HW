using System;

class WorkoutTracker : TrackerBase
{
    public int WorkoutsCompleted { get; private set; }

    public override void LogEntry()
    {
        Console.WriteLine("You completed a workout! Keep it up!");
        WorkoutsCompleted++;
        LogEntries.Add($"Workout {WorkoutsCompleted} logged on {DateTime.Now}");
    }

    public void SetProgress(int value)
    {
        WorkoutsCompleted = value;
    }
}
