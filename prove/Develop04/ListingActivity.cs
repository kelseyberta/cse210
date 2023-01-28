using System.Diagnostics;
public class ListingActivity : Activity
{
    private string _prompt;
    private int _itemsListed;

    public ListingActivity(string activityTitle, string activityDescription) : base(activityTitle, activityDescription)
    {
      base.SetActivityTitle(activityTitle);
      base.SetActivityDescription(activityDescription);

    }

   public string GetPrompt()
   {
      return _prompt;
   }
   public void SetPrompt(string prompt)
    {
        _prompt = prompt;
    }
   public int GetItemsListed()
   {
      return _itemsListed;
   }
   public void SetItemsListed(int itemsListed)
    {
        _itemsListed = itemsListed;
    }
       public void AddItemsListed()
    {
        _itemsListed++;
    }
   public void DisplayPrompt()
   {
      string  prompt = base.GetPromptFromFile("prompts.txt"); 
      Console.Write("\n");
      Console.WriteLine("List as many responses you can to the following prompt:");
      Console.WriteLine($" --- {prompt} --- ");
      Console.Write("You may begin in: ");
      base.Pause(7);
      Console.Write("\n");
   }
   public void CountItems(int activityTime)
   {
      Console.Write("> ");
      Console.ReadLine();
      AddItemsListed();
   }
   public void DisplayItemsListed()
   {
      int itemsListed = GetItemsListed();
      Console.WriteLine($"You listed {itemsListed} items!\n");
   }

}