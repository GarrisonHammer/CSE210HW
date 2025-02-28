using System;

class Listing : Base
{
    //list of prompts to encourage positive thinking
    private static readonly string[] Prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public Listing() : base("Listing", "This activity will help you reflect on the good things in your life by listing as many as you can.") { }

    protected override void Run()
    {
        Random rand = new Random();
        Console.WriteLine(Prompts[rand.Next(Prompts.Length)]);//pick a random prompt
        ShowSpinner(5);//pause before the user starts listing items
        
        int count = 0;
        int elapsed = 5;
        while (elapsed < Duration)
        {
            Console.Write("Enter an item: ");
            Console.ReadLine();//user inputs an item
            count++;
            elapsed += 5;//each input takes 5 seconds
        }
        
        Console.WriteLine($"You listed {count} items!");//display the total count
    }
}
