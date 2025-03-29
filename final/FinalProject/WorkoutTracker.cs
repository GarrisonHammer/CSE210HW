using System;

class WorkoutTracker : TrackerBase
{
    public int WorkoutsCompleted { get; private set; }
    public string LastExerciseType { get; private set; }

    public override void LogEntry()
    {
        Console.Write("Enter the type of workout you completed: ");
        LastExerciseType = Console.ReadLine();
        WorkoutsCompleted++;
        LogEntries.Add($"Workout {WorkoutsCompleted}: {LastExerciseType} logged on {DateTime.Now}");
    }

    public void SetProgress(int value, string lastExercise)
    {
        WorkoutsCompleted = value;
        LastExerciseType = lastExercise;
    }
}
