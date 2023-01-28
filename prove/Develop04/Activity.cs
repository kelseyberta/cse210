using System.Diagnostics;
public class Activity
{
    private string _activityTitle;
    private string _activityDescription;
    private int _activityTime;
    private int _spinnerCounter = 0;
    private List<int> _usedPrompts = new List<int>();

    public Activity(string activityTitle, string activityDescription)
    {
      SetActivityTitle(activityTitle);
      SetActivityDescription(activityDescription);
    }

   public string GetActivityTitle()
   {
      return _activityTitle;
   }
   public void SetActivityTitle(string activityTitle)
    {
      _activityTitle = activityTitle;
    }
   public int GetActivityTime()
   {
      return _activityTime;
   }
   public void SetActivityTime(int activityTime)
    {
      _activityTime = activityTime;
    }
   public string GetActivityDescription()
   {
      return _activityDescription;
   }
   public void SetActivityDescription(string activityDescription)
    {
      _activityDescription = activityDescription;
    }
   public int GetSpinnerCounter()
   {
      return _spinnerCounter;
   }
   public void AddUsedPrompt(int promptIndex)
   {
      _usedPrompts.Add(promptIndex);
   }
   public List<int> GetUsedPrompts()
   {
      return _usedPrompts;
   }
   public void ResetUsedPrompts()
    {
      _usedPrompts.Clear();
    }
   public void DisplayStartMessage()
   {
      string activityTitle = GetActivityTitle();
      string activityDescription = GetActivityDescription();

      Console.Clear();
      Console.Write($"Welcome to the {activityTitle}.\n{activityDescription}\nHow long, in seconds, would you like for your activity? ");
      string userInput = Console.ReadLine();
      int activityTime = int.Parse(userInput);
      SetActivityTime(activityTime);
      Console.WriteLine("\nGet Ready...");
      ShowSpinner(3);

   }
   public void DisplayEndMessage()
   {
      string activityTitle = GetActivityTitle();
      int activityTime = GetActivityTime();

      Console.WriteLine($"\nWell Done!\n\nYou have completed another {activityTime} seconds of {activityTitle}");
      ShowSpinner(5);
   }
   public void Pause(int pauseTime)
   {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      while (stopwatch.ElapsedMilliseconds < pauseTime * 1000)
      {
		  	Console.Write(pauseTime - (stopwatch.ElapsedMilliseconds / 1000));
         Console.SetCursorPosition(Console.CursorLeft - 1 , Console.CursorTop);
			Thread.Sleep(1000);
      }
		Console.Write(" ");
   }
   public void ShowSpinner(int spinnerTime)
   {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();
      int SpinnerCounter = GetSpinnerCounter();

      while (stopwatch.ElapsedMilliseconds / 1000 < spinnerTime)
      {
         SpinnerCounter++;
         switch (SpinnerCounter % 4)
         {
            case 0: Console.Write("/"); break;
            case 1: Console.Write("-"); break;
            case 2: Console.Write("\\"); break;
            case 3: Console.Write("|"); break;
         }
         Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
         Thread.Sleep(200);
      }
      Console.Write(" ");
   }
   
    public string GetPromptFromFile(string filename){

      string[] prompts = System.IO.File.ReadAllLines(filename);
      int length = prompts.Length;

      Random rnd = new Random();
      int i = rnd.Next(length);
      List<int> usedPrompts = GetUsedPrompts();

      if(usedPrompts.Count == length){
         Console.WriteLine("You answered all the prompts!");
         Thread.Sleep(3000);
         ResetUsedPrompts();
      }
      while(usedPrompts.Contains(i))
      {
         i = rnd.Next(length);
      }
      return prompts[i];

    }
}