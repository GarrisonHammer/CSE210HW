using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    static void Main(string[] args)
    {
        Journal newJournal = new Journal();

        int menu = 0;
        Console.WriteLine($"Select an option.\n1. Add entry.\n2. Display \n3. Export \n4. Load from file\n 5. Exit");

        if (menu == 1)
        {
            newJournal.addEntry();
            
        }

        if (menu == 2)
        {
            newJournal.Display();
        }






    }
   
}

