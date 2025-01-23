using System.ComponentModel.DataAnnotations;

public class Entry
{
    string dateTime;
    string prompt;
    string response;

    public Entry(string dateTime,string prompt,string response)
       
    {
        this.dateTime = dateTime;
        this.prompt = prompt;
        this.response = response;

        
    }

    public string Display()
    {
        return $"{dateTime} {prompt} {response}";
    }
}


