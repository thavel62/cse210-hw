using System;

class Program
{
    static void Main(string[] args)
    {
                // Create some products
        Product product1 = new Product("Laptop", "A123", 999.99m, 1);
        Product product2 = new Product("Mouse", "B456", 25.50m, 2);
        Product product3 = new Product("Keyboard", "C789", 45.75m, 1);
        Product product4 = new Product("Monitor", "D012", 150.00m, 2);

        // Create some addresses
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Maple Ave", "Othertown", "ON", "Canada");

        // Create some customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create some orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product4);

        // Display order details
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    public static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.GetTotalCost():F2}\n");
    }
}
