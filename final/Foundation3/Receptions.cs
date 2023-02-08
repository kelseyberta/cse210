using System;

public class Receptions : Event
{
 private string _rsvpEmail;
 private string _rsvpPhone;

public Receptions(string eventTitle, string eventDescription, string eventDate, string eventTime, Addresses eventAddress, string rsvpEmail, string rsvpPhone) : base(eventTitle, eventDescription, eventDate, eventTime, eventAddress)
    {
        base.SetEventTitle(eventTitle);
        base.SetEventDescription(eventDescription);
        base.SetEventDate(eventDate);
        base.SetEventTime(eventTime);
        base.SetEventAddress(eventAddress);
        SetRsvpEmail(rsvpEmail);
        SetRsvpPhone(rsvpPhone);
    }
    public string GetRsvpEmail()
    {
        return _rsvpEmail;
    }
    public void SetRsvpEmail(string rsvpEmail)
    {
        _rsvpEmail = rsvpEmail;
    }
    public string GetRsvpPhone()
    {
        return _rsvpPhone;
    }
    public void SetRsvpPhone(string rsvpPhone)
    {
        _rsvpPhone = rsvpPhone;
    }
 public void DisplayReceptionDetails()
    {
        base.DisplayStandardDetails();
        Console.WriteLine($"Please RSVP to email: {GetRsvpEmail()} phone: {GetRsvpPhone()}");
    }

}