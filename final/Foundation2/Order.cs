using System.IO;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private string _packingLabel = "";
    private string _shippingLabel = "";
    private float _orderTotal;
    private const int _shippingCost = 0;

    public Order()
    {

    }
    public float GetOrderTotal()
    {
        _orderTotal = 
        foreach (Product product in _products)
        {
            product.GetProductPrice();
    
        }
    }
    public void DisplayPackingLabel()
    {
       foreach (Product product in _products)
       {
        product.DisplayProductName();
       }
    }
    public void DisplayShippingLabel()
    {
        Customer.DisplayCustomerInfo();
    }
}