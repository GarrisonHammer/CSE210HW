using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int score = 0;
    private int level = 1; // Track user level

    public void Start()
    {
        int choice;
        do
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest - Goal Tracker");
            Console.WriteLine($"Current Score: {score} | Level: {level}");
            Console.WriteLine("1. Create a Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: CreateGoal(); break;
                case 2: ListGoals(); break;
                case 3: RecordEvent(); break;
                case 4: SaveGoals(); break;
                case 5: LoadGoals(); break;
            }
        } while (choice != 6);
    }

    private void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("Select the type of goal to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter choice: ");

        int choice = int.Parse(Console.ReadLine());
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter points for completing: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                goals.Add(new SimpleGoal(name, points));
                break;
            case 2:
                goals.Add(new EternalGoal(name, points));
                break;
            case 3:
                Console.Write("Enter times needed to complete: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points for completion: ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, points, target, bonus));
                break;
        }

        Console.WriteLine("Goal created! Press enter to continue...");
        Console.ReadLine();
    }

    private void ListGoals()
    {
        Console.Clear();
        Console.WriteLine("Your Goals:");
        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal.GetStatus());
        }

        Console.WriteLine("\nPress enter to continue...");
        Console.ReadLine();
    }

    private void RecordEvent()
    {
        Console.Clear();
        Console.WriteLine("Select a goal to record progress:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
        }

        Console.Write("Enter number of the goal: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < goals.Count)
        {
            int pointsEarned = goals[index].RecordEvent();
            score += pointsEarned;
            int newLevel = (score / 1000) + 1; // Level up every 1000 points

            Console.WriteLine($"Event Recorded! You earned {pointsEarned} points!");

            // Check if the user has leveled up
            if (newLevel > level)
            {
                level = newLevel;
                Console.WriteLine($"🎉 Congratulations! You leveled up to Level {level}! 🎉");
            }

            Console.WriteLine("Press enter to continue...");
        }
        else
        {
            Console.WriteLine("Invalid selection. Press enter to continue...");
        }

        Console.ReadLine();
    }

    private void SaveGoals()
    {
        Console.Clear();
        Console.Write("Enter file name to save: ");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(score);
            writer.WriteLine(level);
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.ToFileString());
            }
        }

        Console.WriteLine("Goals saved successfully! Press enter to continue...");
        Console.ReadLine();
    }

    private void LoadGoals()
    {
        Console.Clear();
        Console.Write("Enter file name to load: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found! Press enter to continue...");
            Console.ReadLine();
            return;
        }

        goals.Clear();
        using (StreamReader reader = new StreamReader(fileName))
        {
            score = int.Parse(reader.ReadLine());
            level = int.Parse(reader.ReadLine());
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                switch (parts[0])
                {
                    case "Simple":
                        goals.Add(new SimpleGoal(parts[1], int.Parse(parts[2]), bool.Parse(parts[3])));
                        break;
                    case "Eternal":
                        goals.Add(new EternalGoal(parts[1], int.Parse(parts[2])));
                        break;
                    case "Checklist":
                        goals.Add(new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])));
                        break;
                }
            }
        }

        Console.WriteLine("Goals loaded successfully! Press enter to continue...");
        Console.ReadLine();
    }
}
