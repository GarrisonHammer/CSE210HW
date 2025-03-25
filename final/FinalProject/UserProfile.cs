using System;

class UserProfile
{
    public string Name { get; private set; }
    public int Age { get; set; }
    public double Weight { get; set; }
    public double Height { get; set; }
    public string FitnessGoal { get; set; }

    public UserProfile(string name)
    {
        Name = name;
    }

    public void SetUserProfile()
    {
        Console.Write("Enter your age: ");
        
        

        Console.Write("Enter your weight (kg): ");
        Weight = double.Parse(Console.ReadLine());

        Console.Write("Enter your height (cm): ");
        Height = double.Parse(Console.ReadLine());

        Console.Write("Enter your fitness goal: ");
        FitnessGoal = Console.ReadLine();
    }
}
