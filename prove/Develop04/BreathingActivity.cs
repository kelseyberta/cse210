public class BreathingActivity : Activity
{

    public BreathingActivity(string activityTitle, string activityDescription) : base(activityTitle, activityDescription)
    {
      base.SetActivityTitle(activityTitle);
      base.SetActivityDescription(activityDescription);

    }

   public void Breathe()
   {
      
      Console.Write("Breathe in through your nose ...");
      base.Pause(4);
      Console.Write("\n");
      Console.Write("Breathe out through your mouth ...");
      base.Pause(6);
      Console.Write("\n");
   }
}
