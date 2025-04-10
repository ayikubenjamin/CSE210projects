using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("123 Oxford St", "Accra", "Greater Accra", "Ghana");

        
        Customer customer1 = new Customer("John Stone", address1);
        Customer customer2 = new Customer("Jane Adams", address2);

        
        Product product1 = new Product("Laptop", 101, 999.99, 1);
        Product product2 = new Product("Mouse", 102, 25.50, 2);
        Product product3 = new Product("Keyboard", 103, 45.00, 1);
        Product product4 = new Product("Monitor", 104, 150.75, 1);

        
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        
        List<Order> orders = new List<Order> { order1, order2 };

        
        foreach (Order order in orders)
        {
            
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.TotalCost():F2}\n");
        }
    }
}