using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 street", "South Jordan", "UT", "USA");
        Customer customer1 = new Customer("Bryton Palmer", address1);

        List<Product> products1 = new List<Product>
        {
            new Product("Scripture Journal", 12.99, 2, "SJ2025"),
            new Product("Temple Ornament", 8.50, 1, "TO884")
        };

        Order order1 = new Order(customer1, products1);

        Console.WriteLine(order1.CreateShippingLabel());
        Console.WriteLine(order1.CreatePackingLabel());
        Console.WriteLine($"Total Price: ${order1.GetOrderTotal():F2}");
        Console.WriteLine("\n==============================\n");

        Address address2 = new Address("456 Maple Street", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Elena Rivera", address2);

        List<Product> products2 = new List<Product>
        {
            new Product("CTR Ring", 5.99, 3, "CTR003"),
            new Product("Missionary Planner", 6.75, 2, "MP2025"),
            new Product("Liahona Keychain", 3.25, 1, "LK001")
        };

        Order order2 = new Order(customer2, products2);

        Console.WriteLine(order2.CreateShippingLabel());
        Console.WriteLine(order2.CreatePackingLabel());
        Console.WriteLine($"Total Price: ${order2.GetOrderTotal():F2}");
    
    }
}