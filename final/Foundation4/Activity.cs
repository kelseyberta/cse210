public class Activity
{
    private string _date;
    private int _length;
   //private double _distance;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    //  private float _speed;
    // private float _pace;
    public string GetDate()
    {
        return _date;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public int GetLength()
    {
        return _length;
    }
    public void SetLength(int length)
    {
        _length = length;
    }
    public virtual double GetDistance()
    {
        return GetSpeed() / 60 * GetLength();
    }
   // public void SetDistance(double distance)
   // {
    //_distance = distance;
  // }
    public virtual double GetSpeed()
    {
        return GetDistance() / _length * 60;
    }
   // public void SetSpeed(float speed)
   // {
    //    _speed = speed;
    //}
    public virtual double GetPace()
    {
        return _length / GetDistance();
    }
    //public void SetPace(float pace)
    //{
      //  _pace = pace;
    //}
    public virtual void DisplaySummary()
    {
        return;
    }
}