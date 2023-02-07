public class Running : Activity
{
    private float _distance;
    

    public Running(string date, int length, float distance) : base(date, length)
    {
       _distance = distance;
    }
    public override void DisplaySummary()
    {
        Console.WriteLine($"{GetDate()} Running ({GetLength()} mins) - Distance: {_distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile");
    }
    public override double GetSpeed()
    {
        return _distance / GetLength() * 60;
    }
    public override double GetPace()
    {
        return GetLength() / _distance;
    }
}