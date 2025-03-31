using System;
using System.Collections.Generic;

// Abstract base class for tracking different activities
abstract class TrackerBase
{
    protected List<string> LogEntries = new List<string>();

    public abstract void LogEntry();

    public void DisplayLog()
    {
        Console.WriteLine("=== Log Entries ===");
        foreach (string entry in LogEntries)
        {
            Console.WriteLine(entry);
        }
    }
}
