using System;

public class Entry{
    public string _prompt = "";
    public string _response="";
    public string _date =  "";

    public Entry()
{

}
    public void DisplayEntry()
    {
        Console.WriteLine($"date: {_date} - prompt: {_prompt} / text: {_response}");
       
    }
}