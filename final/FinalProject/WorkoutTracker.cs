using System;

class WorkoutTracker : TrackerBase
{
    public int WorkoutsCompleted { get; private set; }
    public string LastExerciseType { get; private set; } = "None";

    public override void LogEntry()
    {
        Console.Write("Enter the type of workout: ");
        LastExerciseType = Console.ReadLine();
        WorkoutsCompleted++;
        LogEntries.Add($"Workout {WorkoutsCompleted}: {LastExerciseType} on {DateTime.Now}");
    }

    public void SetProgress(int value, string lastType)
    {
        WorkoutsCompleted = value;
        LastExerciseType = lastType;
    }
}
