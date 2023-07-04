using System;

namespace Foundation02
{
    class Program
    {
        static void Main(string[] args)
        {
            //To add a new product, enter as follows: Product product# = new Product("(Product Here)", ID Here, Price, Quantity);
            Product product1 = new Product("Basketball", 9745, 20.00, 2);
            Product product2 = new Product("Gatorade", 1278, 3.00, 1);
            Product product3 = new Product("Basketball Shoes", 5555, 50.00, 1);

            
            //Same with adding a new Customer
            Customer customer1 = new Customer("Damian Lillard", new Address("Middle of Nowhere", "Temecula", "CA", "USA"));
            Customer customer2 = new Customer("Luka Doncic", new Address("Ljubljana Outskirts", "Ljubljana", "Slovenia", "Slovenia"));

            //Orders found here.
            Order order = new Order(
                new List<Product>() { product1, product2, product3 },
                customer1);  
            Order order1 = new Order(
                new List<Product>() { product1, product2, product3 },
                customer2);  

            // Print everything for Damian's Order
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine("Total:");
            Console.WriteLine(order.GetTotalCost());
            Console.WriteLine($"Thank You for Your Order!");

            Console.WriteLine();
            // Print the shipping label
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine("Total:");
            Console.WriteLine(order1.GetTotalCost());
            Console.WriteLine($"Thank You for Your Order!");

            
        }
    }
}