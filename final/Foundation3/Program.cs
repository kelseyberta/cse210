using System;

class Program
{
    static void Main(string[] args)
    {
    
        Addresses a1 = new Addresses("1 Sesame Street", "New York City", "NY");
        string add1 = a1.GetAddress();
        Lectures e1 = new Lectures("Lecture", "Speaker will share their thoughts with a life in their profession", "March 1", "3pm", $"{add1}", "Mickey Mouse", 30);
        e1.DisplayLectureDetails();

        Addresses a2 = new Addresses("123 Street Street", "New Orleans", "LA");
        string add2 = a2.GetAddress();
        Receptions e2 = new Receptions("Reception", "Reception for the wedding", "Feb 21", "6:30pm", $"{add2}", "someone@email.com", "123-456-78910");
        e2.DisplayReceptionDetails();

        Addresses a3 = new Addresses("10 Valley Way", "Gilbert", "AZ");
        string add3 = a3.GetAddress();
        OutdoorGatherings e3 = new OutdoorGatherings("Outdoor Gathering", "Gathering for the anniversary party. Dress appropriately.", "April 10", "2pm", $"{add3}", "Sunny 75 degrees");
        e3.DisplayOutdoorGatheringDetails();


    }
}