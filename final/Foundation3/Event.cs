using System;

public class Event
{
    private string _eventTitle;
    private string _eventDescription;
    private string _eventDate;
    private string _eventTime;
    private Addresses _eventAddress;

    public Event(string eventTitle, string eventDescription, string eventDate, string eventTime, Addresses eventAddress)
    {
        SetEventTitle(eventTitle);
        SetEventDescription(eventDescription);
        SetEventDate(eventDate);
        SetEventTime(eventTime);
        SetEventAddress(eventAddress);
    }

    public Event()
    {
    }


    public string GetEventTitle()
    {
        return _eventTitle;
    }
    public void SetEventTitle(string eventTitle)
    {
        _eventTitle = eventTitle;
    }
    public string GetEventDescription()
    {
        return _eventDescription;
    }
    public void SetEventDescription(string eventDescription)
    {
        _eventDescription = eventDescription;
    }
    public string GetEventDate()
    {
        return _eventDate;
    }
    public void SetEventDate(string eventDate)
    {
        _eventDate = eventDate;
    }
    public string GetEventTime()
    {
        return _eventTime;
    }
    public void SetEventTime(string eventTime)
    {
        _eventTime = eventTime;
    }
   public Addresses GetEventAddress()
   {
    return _eventAddress;
   }
   public void SetEventAddress(Addresses eventAddress)
   {
    _eventAddress = eventAddress;
   }
    public void DisplayStandardDetails()
    {
        string eventTitle = GetEventTitle();
        string eventDescription = GetEventDescription();
        string eventDate = GetEventDate();
        string eventTime = GetEventTime();
        Addresses eventAddress = GetEventAddress();

        Console.WriteLine(" ");
        Console.WriteLine($"Event name: {eventTitle} ");
        Console.WriteLine(" ");
        Console.WriteLine($"Event description: {eventDescription}");
        Console.WriteLine(" ");
        Console.WriteLine($"Date: {eventDate} , Time: {eventTime}, Address: {eventAddress}");
    }
}