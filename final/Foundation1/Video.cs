using System.IO;

public class Video
{
    public string _title = "";
    public string _author = "";
    public int _length;
    public List<Comment> _comments = new List<Comment> (); 

    public Video()
    {

    }
    public void DisplayVideoInfo()
    {   
        Console.WriteLine(" ");
        Console.WriteLine($"Video Title: {_title} by {_author}, {_length} seconds, {_comments.Count()} comments.");
        Console.WriteLine(" ");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}