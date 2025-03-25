using System;

class WaterTracker : TrackerBase
{
    public int WaterIntake { get; private set; }

    public override void LogEntry()
    {
        Console.WriteLine("Water intake logged! Stay hydrated!");
        WaterIntake++;
        LogEntries.Add($"Water intake {WaterIntake} logged on {DateTime.Now}");
    }

    public void SetProgress(int value)
    {
        WaterIntake = value;
    }
}
