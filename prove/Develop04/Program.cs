//Added creativity
//Added the AnimateBreath method in the breathing class
//this is to slow down and speed up the breathing animation

using System;
using System.Diagnostics;

class Program
{
    static void Main()//infinite loop until the user to exit
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Activities");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            //create an instance of the selected activity using a switch statement 
            Base activity = choice switch
            {
                "1" => new Breathing(),
                "2" => new Reflection(),
                "3" => new Listing(),
                "4" => null,//exits program in 4
                _ => null
            };

            if (activity == null) break;//exit if 4 is selected
            activity.Start();//start the selected activity
        }
    }
}
