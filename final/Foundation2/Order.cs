using System.IO;

public class Order
{
    public List<Product> _products = new List<Product>();
    public string _customer { get; set; }
    public double _shippingCost { get; set; }

    public double GetOrderTotal()
    {
        double total = 0; 
        foreach (Product product in _products)
        {
            double subtotal = product.GetProductPrice();
            total += subtotal;
        }
        total = Math.Round(total, 2);
        return total;
    }
    public double GetTotalPrice()
    {
        double total = (GetOrderTotal() + _shippingCost);
        total = Math.Round(total, 2);
        return total;
    }
    public void DisplayTotalPrice()
    {
        Console.WriteLine($"Total: ${GetTotalPrice()}");
    }
    public void DisplayPackingLabel()
    {
       Console.WriteLine($"Customer: {_customer}");
       foreach (Product product in _products)
       {
        product.DisplayProduct();
       }
       Console.WriteLine($"Order total: ${GetOrderTotal()}");
       Console.WriteLine($"Shipping cost: ${_shippingCost}");
       Console.WriteLine($"Total: ${GetTotalPrice()}");
    }
    public void DisplayShippingLabel()
    {
        Console.WriteLine($"Ship to: {_customer}");
    }
}