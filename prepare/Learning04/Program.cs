using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Jospeh", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Jospeh", "Multiplication", "8.0", "7-10");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Jospeh","History", "Great Pyramids");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}