using System;

class Program
{
    static void Main(string[] args)
    {
        string Choice = "0";
       Journal journal1 = new Journal();

    do
    {
        Console.WriteLine("Please Select One Of The Following Choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("Which one would you like to do? ");
        Choice = Console.ReadLine();
        int userChoice = int.Parse(Choice);


        switch (userChoice)
        {
            case 1:
            journal1.Write();
            break;

            case 2:
            journal1.Display();
            break;

            case 3:
            journal1.LoadFromFile();
            break;

            case 4:
            journal1.SaveToFile();
            break;

            case 5:
            break;

            default:
            Console.WriteLine("Not an option please try again.");
            break;
        }
        } 
        while (Choice != "5");
        {
            Console.WriteLine("Bye!");
        }
    }
    }
