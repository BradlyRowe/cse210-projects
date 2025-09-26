using System;

class Program
{
    static void Main(string[] args)
    {
        // First Order - USA Customer
        Address address1 = new Address("123 Maple St", "Roy", "UT", "USA");
        Customer customer1 = new Customer("Bradly Rowe", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("SQL Server Guide", "SQL001", 29.99, 2));
        order1.AddProduct(new Product("Power BI Toolkit", "BI002", 49.99, 1));

        // Second Order - International Customer
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Sophie Tran", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Python Cookbook", "PY003", 39.99, 1));
        order2.AddProduct(new Product("Data Science Poster", "DS004", 19.99, 3));

        // Display Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}");
        Console.WriteLine(new string('-', 40));

        // Display Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}