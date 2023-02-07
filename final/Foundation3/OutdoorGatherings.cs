using System;

public class OutdoorGatherings : Event
{
    private string _weatherForecast;
    

    public OutdoorGatherings(string eventTitle, string eventDescription, string eventDate, string eventTime, Addresses eventAddress, string weatherForecast) : base(eventTitle, eventDescription, eventDate, eventTime, eventAddress)
    {
        base.SetEventTitle(eventTitle);
        base.SetEventDescription(eventDescription);
        base.SetEventDescription(eventDate);
        base.SetEventTime(eventTime);
        base.SetEventAddress(eventAddress);
    }
    public string GetWeatherForecast()
    {
        return _weatherForecast;
    }
    public void SetWeatherForecast(string weatherForecast)
    {
        _weatherForecast = weatherForecast;
    }
    public void DisplayReceptionDetails()
    {
        base.DisplayStandardDetails();
        Console.WriteLine($"The weatherforecast will be {_weatherForecast}");
    }

}