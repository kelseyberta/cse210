public class Addresses
{
    private string _street;
    private string _city;
    private string _state = "";

public Addresses(string _street, string _city, string _state)
{

}
public string GetStreet()
{
    return _street;
}
public void SetStreet(string street)
{
    _street = street;
}
public string GetCity()
{
    return _city;
}
public void SetCity(string city)
{
    _city = city;
}
public string GetState()
{
    return _state;
}
public void SetState(string state)
{
    _state = state;
}
public void DisplayAddress()
{
    Console.WriteLine($"{_street} {_city}, {_state}");
}

    
}