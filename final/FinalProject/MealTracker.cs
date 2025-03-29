using System;

class MealTracker : TrackerBase
{
    public int MealsLogged { get; private set; }
    public int TotalCalories { get; private set; }

    public override void LogEntry()
    {
        Console.Write("Enter the number of calories for this meal: ");
        int calories = int.Parse(Console.ReadLine());
        TotalCalories += calories;
        MealsLogged++;
        LogEntries.Add($"Meal {MealsLogged}: {calories} calories logged on {DateTime.Now}");
    }

    public void SetProgress(int meals, int totalCalories)
    {
        MealsLogged = meals;
        TotalCalories = totalCalories;
    }
}
