using System;

class Reflection : Base
{
    //list of prompts to get the user thinking
    private static readonly string[] Prompts =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    //list of questions for deep reflection
    private static readonly string[] Questions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };


    public Reflection() : base("Reflection", "This activity will help you reflect on times when you have shown strength and resilience.") { }

    protected override void Run()
    {
        Random rand = new Random();
        Console.WriteLine(Prompts[rand.Next(Prompts.Length)]);//picks a random prompt
        ShowSpinner(5);//pause for 5 second before asking questions

        int elapsed = 5;
        while (elapsed < Duration)
        {
            Console.WriteLine(Questions[rand.Next(Questions.Length)]);//pick a random question
            ShowSpinner(5);//pause for 5 seconds
            elapsed += 5;
        }
    }
}
