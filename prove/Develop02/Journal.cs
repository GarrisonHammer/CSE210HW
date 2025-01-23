using System.Net.Mail;

public class Journal
{
    public List<Entry> entryList;

    public void Display()
    {
        foreach (var entry in entryList)
        {
            Console.WriteLine();

        }
    }

    public void addEntry()
    {
        string prompt = Prompt();

        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        var entry = new Entry(dateText,prompt,response);

        //calls the instance of the entry class 
        entryList.Add(entry);

    }

    public string Prompt()
    {
        Random random = new Random ();
        int Promptrandom = random.Next(1,5);

        if (Promptrandom == 1)
        {
            return "If I had one thing I could do over today, what would it be?";
        } 

        if (Promptrandom == 2)
        {
            return "Who was the most interesting person I interacted with today?";
        } 

        if (Promptrandom == 3)
        {
            return "What was the best part of my day?";
        } 

        if (Promptrandom == 4)
        {
            return "How did I see the hand of the Lord in my life today?";
        } 

        if (Promptrandom == 5)
        {
            return "What was the strongest emotion I felt today?";
        } 

        return "Fail";

    }
}
