using System;
using System.Threading;

abstract class Base
{
    protected string Name;
    protected string Description;
    protected int Duration;

    public Base(string name, string description)
    {
        Name = name;
        Description = description;
    }

    //starts activity and displays the message for the activity
    public void Start()
    {
        Console.Clear();//clears console screen
        Console.WriteLine($"Starting {Name} Activity");
        Console.WriteLine(Description);
        //prompt for user duration
        Console.Write("Enter duration in seconds: ");
        if (!int.TryParse(Console.ReadLine(), out Duration) || Duration <= 0)
        {
            Console.WriteLine("Invalid input. Defaulting to 10 seconds.");//if there is an invalid input
            Duration = 10;//10 sec
        }
        Console.WriteLine("Get ready...");
        ShowSpinner(3); //pause for 3 seconds before starting
        Run();//call run
        End();//end with summary message
    }

    protected abstract void Run();

    //used at the end of every activity
    private void End()
    {
        Console.WriteLine($"Good job! You completed the {Name} Activity for {Duration} seconds.");
        ShowSpinner(3); //pause for 3 seconds before going to menu
    }

    //this creates the spinner or counter
    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(". ");
            Thread.Sleep(1000);//wait 1 second
        }
        Console.WriteLine();
    }
}
