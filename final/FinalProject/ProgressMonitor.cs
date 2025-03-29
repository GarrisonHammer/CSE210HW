using System;

class ProgressMonitor
{
    private UserProfile user;
    private WorkoutTracker workouts;
    private MealTracker meals;
    private WaterTracker water;

    public ProgressMonitor(UserProfile user, WorkoutTracker workouts, MealTracker meals, WaterTracker water)
    {
        this.user = user;
        this.workouts = workouts;
        this.meals = meals;
        this.water = water;
    }

    public void DisplayProgress()
    {
        Console.WriteLine($"=== Progress for {user.Name} ===");
        Console.WriteLine($"Workouts Completed: {workouts.WorkoutsCompleted} (Last: {workouts.LastExerciseType})");
        Console.WriteLine($"Meals Logged: {meals.MealsLogged}, Total Calories: {meals.TotalCalories}");
        Console.WriteLine($"Water Intake: {water.WaterIntake} times, Total Water Consumed: {water.TotalWaterML} mL");
        Console.ReadLine();
    }
}
