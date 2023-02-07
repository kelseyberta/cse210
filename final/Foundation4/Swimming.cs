public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(string date, int length, int numberOfLaps) : base(date, length)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override void DisplaySummary()
    {
        Console.WriteLine($"{GetDate()} Swimming ({GetLength()} mins) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile");
    }
    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
        return GetDistance() / GetLength() * 60;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}