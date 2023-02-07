using System;

class Program
{
    static void Main(string[] args)
    {
        Addresses a1 = new Addresses("1 Sesame Street", "New York City", "NY");
        Lectures e1 = new Lectures("Lecture", "Speaker will share their thoughts with a life in their profession", "March 1", "3pm", a1, "Mickey Mouse", 30);
        e1.DisplayLectureDetails();

        Addresses a2 = new Addresses("123 Street Street", "New Orleans", "LA");
        Receptions e2 = new Receptions("Reception", "Reception for the wedding", "Feb 21", "6:30pm", a2, "someone@email.com", "123-456-78910");
        e2.DisplayReceptionDetails();


    }
}