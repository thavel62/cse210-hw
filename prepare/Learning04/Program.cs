using System;

class Program
{
    static void Main(string[] args)
    {
        // Create base assingment
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        // Assignments for classes
        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeWorkList());

        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of WW2");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}