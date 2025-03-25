using System;

class Program
{
    static void Main()
    {
        UserProfile user = null;
        WorkoutTracker workoutTracker = new WorkoutTracker();
        MealTracker mealTracker = new MealTracker();
        WaterTracker waterTracker = new WaterTracker();
        ProgressMonitor progressMonitor = null;

        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("===== Health & Fitness Tracker =====");
            Console.WriteLine("1. Create New User Profile");
            Console.WriteLine("2. Load User Profile");
            Console.WriteLine("3. Log a Workout");
            Console.WriteLine("4. Log a Meal");
            Console.WriteLine("5. Log Water Intake");
            Console.WriteLine("6. View Progress");
            Console.WriteLine("7. Save & Exit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Enter your name: ");
                    string userName = Console.ReadLine();
                    user = new UserProfile(userName);
                    user.SetUserProfile();
                    progressMonitor = new ProgressMonitor(user, workoutTracker, mealTracker, waterTracker);
                    break;

                case "2":
                    Console.Write("Enter your name to load your profile: ");
                    string loadName = Console.ReadLine();
                    user = FileManager.LoadData(loadName, out workoutTracker, out mealTracker, out waterTracker);
                    if (user != null)
                    {
                        Console.WriteLine("Profile loaded successfully!");
                        progressMonitor = new ProgressMonitor(user, workoutTracker, mealTracker, waterTracker);
                    }
                    else
                    {
                        Console.WriteLine("No profile found. Try creating a new one.");
                    }
                    Console.ReadLine();
                    break;

                case "3":
                    if (user != null) workoutTracker.LogEntry();
                    else Console.WriteLine("Please load or create a user profile first.");
                    Console.ReadLine();
                    break;

                case "4":
                    if (user != null) mealTracker.LogEntry();
                    else Console.WriteLine("Please load or create a user profile first.");
                    Console.ReadLine();
                    break;

                case "5":
                    if (user != null) waterTracker.LogEntry();
                    else Console.WriteLine("Please load or create a user profile first.");
                    Console.ReadLine();
                    break;

                case "6":
                    if (progressMonitor != null) progressMonitor.DisplayProgress();
                    else Console.WriteLine("Please load or create a user profile first.");
                    Console.ReadLine();
                    break;

                case "7":
                    if (user != null)
                    {
                        FileManager.SaveData(user, workoutTracker, mealTracker, waterTracker);
                        Console.WriteLine("Data saved successfully.");
                    }
                    Console.WriteLine("Exiting program...");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option, try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
