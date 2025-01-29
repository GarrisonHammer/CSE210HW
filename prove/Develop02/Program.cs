using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal newJournal = new Journal();

        //sets up a variable for the user to pick
        int menu = 0;

        //displays the menu until the user enters 5
        while (menu != 5)
        {
            Console.WriteLine($"Select an option.\n1. Add entry\n2. Display \n3. Export \n4. Load from file\n5.Exit");
            menu = int.Parse(Console.ReadLine());

            if (menu == 1)
            {
                newJournal.addEntry(); //calls addEntry 
            }

            if (menu == 2)
            {
                newJournal.Display();//calls Display
            }

            if (menu == 3)
            {
                Save(newJournal.Export());//calls Export
            }

            if (menu == 4)
            {
                var lines = Load();
                newJournal = new Journal(lines); //loads the lines back from a txt file
            }

            if (menu == 5)
            {
                Console.WriteLine("Thank you, have a great day!");
            }
        }
        
    }
   
   static void Save(string[] exportedLines )
   {

        Console.WriteLine($"Enter a file name"); //prompts for user input
        string fileName = Console.ReadLine();
        System.IO.File.WriteAllLines(fileName,exportedLines);//saves exportedLines to filename

   }

   static string[] Load()
   {
    Console.WriteLine($"Enter a file name to load from");
    string fileName = Console.ReadLine();
    var importedLines = System.IO.File.ReadAllLines(fileName);//loads lines from filename
    return importedLines;

   }

}

