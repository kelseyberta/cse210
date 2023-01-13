using System;
public class PromptGenerator{
    public string _filename = "promptChoices.txt";
   public List<string> _promptChoices = new List<string>();

   public PromptGenerator()
{

}
public void OptionPrompts()
{
   //pulls the prompts file
   string[] lines = System.IO.File.ReadAllLines(_filename);

   //for each line, add it to the prompts list
   foreach (string line in lines)
   {
         _promptChoices.Add(line);
   }
}
public string RandomPrompt()
{
   //makes a random number depending on the length of the prompts list
   Random rnd = new Random();
   int prompt = rnd.Next(_promptChoices.Count);

   //Returns a random prompt
   return _promptChoices[prompt];
}
}