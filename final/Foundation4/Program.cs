using System;

class Program
{
    static void Main(string[] args)
    {
        Running r1 = new Running("March 1", 30, 2);
        r1.DisplaySummary();

        Cycling c1 = new Cycling ("March 2", 10, 6);
        c1.DisplaySummary();

        Swimming s1 = new Swimming("March 3", 15, 20);
        s1.DisplaySummary();
    }
}