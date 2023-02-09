using System;

public class Lectures : Event
{
    private string _speakerName;
    private int _capacity;

    

    public Lectures(string eventTitle, string eventDescription, string eventDate, string eventTime, string eventAddress, string speakerName, int capacity) : base(eventTitle, eventDescription, eventDate, eventTime, eventAddress)
    {
        base.SetEventTitle(eventTitle);
        base.SetEventDescription(eventDescription);
        base.SetEventDate(eventDate);
        base.SetEventTime(eventTime);
        base.SetEventAddress(eventAddress);
        SetSpeaker(speakerName);
        SetCapacity(capacity);
    }

   

    public string GetSpeaker()
    {
        return _speakerName;
    }
    public void SetSpeaker(string speakerName)
    {
        _speakerName = speakerName;
    }
    public int GetCapacity()
    {
        return _capacity;
    }
    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }

    public void DisplayLectureDetails()
    {
        base.DisplayStandardDetails();
        Console.WriteLine($"Speaker: {_speakerName} Capacity Limit: {_capacity} people");
    }
}