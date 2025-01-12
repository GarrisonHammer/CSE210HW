using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        //set up the loops
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to end) ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            //adds numbers to the list if not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }

        Console.WriteLine($"The total is: {total}");

        //sets up the variables as floats 
        //finds the average
        float average = ((float)total)/numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //find the max values

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                //compares the current number to the next
                //assigns the number to max if larger
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}