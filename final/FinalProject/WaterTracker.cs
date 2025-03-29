using System;

class WaterTracker : TrackerBase
{
    public int WaterIntake { get; private set; } // Number of times water intake was logged
    public int TotalWaterML { get; private set; } // Total water consumed in mL

    public override void LogEntry()
    {
        Console.Write("Enter the amount of water (mL) you drank: ");
        int waterAmount = int.Parse(Console.ReadLine());
        TotalWaterML += waterAmount;
        WaterIntake++;
        LogEntries.Add($"Water intake {WaterIntake}: {waterAmount} mL logged on {DateTime.Now}");
    }

    public void SetProgress(int intake, int totalML)
    {
        WaterIntake = intake;
        TotalWaterML = totalML;
    }
}
