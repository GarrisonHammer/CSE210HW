using System;
using System.IO;

class FileManager
{
    private static string GetFilePath(string userName) => $"{userName}_profile.txt";

    public static void SaveData(UserProfile user, WorkoutTracker workouts, MealTracker meals, WaterTracker water)
    {
        string filePath = GetFilePath(user.Name);

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(user.Name);
            writer.WriteLine(user.Age);
            writer.WriteLine(user.Weight);
            writer.WriteLine(user.Height);
            writer.WriteLine(user.FitnessGoal);
            writer.WriteLine(workouts.WorkoutsCompleted);
            writer.WriteLine(meals.MealsLogged);
            writer.WriteLine(water.WaterIntake);
        }
    }

    public static UserProfile LoadData(string name, out WorkoutTracker workouts, out MealTracker meals, out WaterTracker water)
    {
        string filePath = GetFilePath(name);

        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string userName = reader.ReadLine();
                int age = int.Parse(reader.ReadLine());
                double weight = double.Parse(reader.ReadLine());
                double height = double.Parse(reader.ReadLine());
                string fitnessGoal = reader.ReadLine();
                int workoutsCompleted = int.Parse(reader.ReadLine());
                int mealsLogged = int.Parse(reader.ReadLine());
                int waterIntake = int.Parse(reader.ReadLine());

                UserProfile user = new UserProfile(userName)
                {
                    Age = age,
                    Weight = weight,
                    Height = height,
                    FitnessGoal = fitnessGoal
                };

                workouts = new WorkoutTracker();
                workouts.SetProgress(workoutsCompleted);

                meals = new MealTracker();
                meals.SetProgress(mealsLogged);

                water = new WaterTracker();
                water.SetProgress(waterIntake);

                Console.WriteLine($"Welcome back, {user.Name}! Your progress has been loaded.");
                return user;
            }
        }

        workouts = null;
        meals = null;
        water = null;
        return null;
    }
}
