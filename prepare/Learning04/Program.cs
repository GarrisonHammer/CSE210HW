using System;

class Program
{
    static void Main(string[] args)
    {
        //create a base assignment object
        Assignment a1 = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        //now create the derived class assignments
        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History","The Cuases of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    
    }
}