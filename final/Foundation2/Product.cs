using System.IO;

public class Product
{
    public string _productName = "";
    private int _productId;
    private float _productPrice;
    private int _productQuantity;


    public string GetProductName()
    {
        return _productName;
    }
    public void SetProductName(string productName)
    {
        _productName = productName;
    }

    public float GetProductPrice()
    {
        _productPrice = _productPrice * _productQuantity;
        return _productPrice;
    }
    public void DisplayProductName()
    {
        Console.WriteLine($"{_productName}: {_productId}");
    }
}