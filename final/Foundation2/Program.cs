using System;

class Program
{
    static void Main(string[] args)
    {
        
        Product product1 = new Product("Chicken", "GH57H", 7.4, 5);
        Product product2 = new Product("Lettuce", "SOH98", 2.33, 9);
        Product product3 = new Product("Mangoes", "GP483", 1.2, 1);
        Product product4 = new Product("Canned Corn", "26FH7", .8, 2);
        Product product5 = new Product("Dog food", "8KE36", 6.7, 4);
        Product product6 = new Product("Dog toys", "KQW4Y", 8.8, 5);
        


        Address address1 = new Address("123 Sesame Street", "New York City", "NY", "USA");
        string newAddress1 = address1.GetAddress();
        string newCountry1 = address1.GetCountry();
        Customer customer1 = new Customer("Big Bird", $"{newAddress1}", $"{newCountry1}");

        Address address2 = new Address("34 Super Road", "Venice", "Italy", "Italy");
        string newAddress2 = address2.GetAddress();
        string newCountry2 = address2.GetCountry();
        Customer customer2 = new Customer("Mickey Mouse", $"{newAddress2}", $"{newCountry2}");

        Order order1 = new Order();
        order1._customer = customer1.DisplayCustomerInfo();
        order1._shippingCost = customer1.GetShippingCost();
        order1._products.Add(product1);
        order1._products.Add(product2);

        Order order2 = new Order();
        order2._customer = customer2.DisplayCustomerInfo();
        order2._shippingCost = customer2.GetShippingCost();
        order2._products.Add(product3);
        order2._products.Add(product4);
        order2._products.Add(product5);
        order2._products.Add(product6);

        order1.DisplayTotalPrice();
        Console.WriteLine();
        order1.DisplayShippingLabel();
        Console.WriteLine();
        order1.DisplayPackingLabel();
        Console.WriteLine();

        order2.DisplayTotalPrice();
        Console.WriteLine();
        order2.DisplayShippingLabel();
        Console.WriteLine();
        order2.DisplayPackingLabel();
        Console.WriteLine();

    }
}