using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

public class Entry
{
    string dateTime;
    string prompt;
    string response;
    string location; 

    public Entry(string dateTime,string prompt,string response, string location)
       
    {
        this.dateTime = dateTime;
        this.prompt = prompt;
        this.response = response;
        this.location = location; 
      
    }

    public Entry(string Import)
    {
        string[] parts = Import.Split("|");

        this.dateTime = parts[0];
        this.location = parts[1];
        this.prompt = parts[2];
        this.response = parts[3];
        
    }

    public string Display()
    {
        return $"{dateTime} {location} {prompt} {response} ";
    }

    public string Export()
    {
        return $"{dateTime}|{location}|{prompt}|{response}";
    }
}


