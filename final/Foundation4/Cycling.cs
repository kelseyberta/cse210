public class Cycling : Activity
{
    private float _speed;
    public Cycling(string date, int length, float speed) : base(date, length)
    {
       _speed = speed;
    }
    public override void DisplaySummary()
    {
        Console.WriteLine($"{GetDate()} Cycling ({GetLength()} mins) - Distance: {GetDistance()} miles, Speed: {_speed} mph, Pace: {GetPace()} min per mile");
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
    public override double GetDistance()
    {
        return _speed / 60 * GetLength();
    }
}