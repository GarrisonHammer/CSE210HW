using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        int guess = -1;

        //set up the while loop
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higer");
            }

            else if (magicNumber < guess)
            {
                Console.Write("Lower");
            }

            else 
            {
                Console.Write("Congrats you guessed it!");
            }
        }

    }
}