using System.Net.Mail;
using System.Reflection.Metadata;

public class Journal
{
    public List<Entry> entryList;

    public Journal()
    {
        entryList = new List<Entry>(); //sets up a list of entries
    }
    
    public Journal(string[] importedLines)
    {
        entryList = new List<Entry>();
        foreach(var i in importedLines)
        {
            //adds as many entires as we need to the list
            var Entry = new Entry(i);
            entryList.Add(Entry);
        }
    }


    public void Display()
    {
        foreach (var entry in entryList)
        {
            //displays the entry
            Console.WriteLine(entry.Display());
        }
    }

    public void addEntry()
    {
        string prompt = Prompt();

        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        
        //gets the current time
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        //asks for a location
        Console.WriteLine("Where are you at today?");
        var location = Console.ReadLine();

        //formats the entries
        var entry = new Entry(dateText,prompt,response,location);

        //calls the instance of the entry class 
        entryList.Add(entry);

    }

    public string Prompt()
    {
        //generates a random prompt
        Random random = new Random ();
        int Promptrandom = random.Next(1,5);

        if (Promptrandom == 1)
        {
            return " What was the best part of your day, and what was the most challenging? How did each moment make you feel?";
        } 

        if (Promptrandom == 2)
        {
            return "Did you learn something new today—about yourself, someone else, or the world? How will this insight shape your future actions?";
        } 

        if (Promptrandom == 3)
        {
            return "What emotions did you experience most today? Were there any moments when you felt especially happy, frustrated, or at peace?";
        } 

        if (Promptrandom == 4)
        {
            return "Did you do something kind for someone today, or did someone show kindness to you? How did it impact your mood?";
        } 

        if (Promptrandom == 5)
        {
            return "If you could redo one part of your day, what would you change and why? How can you make tomorrow even better?";
        } 

        return "Fail";
    }

    public string[] Export()
    {
        //exports the lines into a list of strings
        var exportedLines = new List<string>();
        foreach(var entry in entryList)
        {
            exportedLines.Add(entry.Export());
        }

        return exportedLines.ToArray();//adds the lines to an array
        
    }


}
