using System.IO;

public class Comment
{
    public string _username = "";
    public string _text = "";

    public void DisplayComment()
    {
        Console.WriteLine($"{_username}: {_text}");
    }
}