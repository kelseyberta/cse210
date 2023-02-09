using System.IO;

public class Product
{
    public string _productName { get; set; }
    private string _productId { get; set; }
    private double _productPrice { get; set; }
    private int _productQuantity { get; set; }

    public Product(string productName, string productId, double productPrice, int productQuantity)
    {
        _productName = productName;
        _productId = productId;
        _productPrice = productPrice;
        _productQuantity = productQuantity;

    }
   

    public double GetProductPrice()
    {
        double subtotal = _productPrice * _productQuantity;
        return subtotal;
    }
    public void DisplayProduct()
    {
        Console.WriteLine($"{_productName}: {_productId} - Total: ${Math.Round(_productPrice * _productQuantity, 2)}");
    }
}