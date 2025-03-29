using System;
using System.IO;

class FileManager
{
    public static void SaveData(UserProfile user, WorkoutTracker workout, MealTracker meal, WaterTracker water)
    {
        string data = $"{user.Name},{user.Age},{user.Weight},{user.Height},{user.FitnessGoal},{workout.WorkoutsCompleted},{workout.LastExerciseType},{meal.MealsLogged},{meal.TotalCalories},{water.WaterIntake},{water.TotalWaterML}";
        File.WriteAllText($"{user.Name}.txt", data);
    }

    public static UserProfile LoadData(string name, out WorkoutTracker workout, out MealTracker meal, out WaterTracker water)
    {
        workout = new WorkoutTracker();
        meal = new MealTracker();
        water = new WaterTracker();

        if (File.Exists($"{name}.txt"))
        {
            string[] data = File.ReadAllText($"{name}.txt").Split(',');
            UserProfile user = new UserProfile(data[0])
            {
                Age = int.Parse(data[1]),
                Weight = double.Parse(data[2]),
                Height = double.Parse(data[3]),
                FitnessGoal = data[4]
            };
            workout.SetProgress(int.Parse(data[5]), data[6]);
            meal.SetProgress(int.Parse(data[7]), int.Parse(data[8]));
            water.SetProgress(int.Parse(data[9]), int.Parse(data[10]));
            return user;
        }

        return null;
    }
}
