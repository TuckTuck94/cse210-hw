using System;

namespace Foundation02
{
public class Order
    {
        private List<Product> products;
        private Customer customer;

        public Order(List<Product> products, Customer customer)
        {
            this.products = products;
            this.customer = customer;
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public Customer GetCustomer()
        {
            return customer;
        }

        public double GetTotalCost()
        {
            double totalCost = 0;
            foreach (Product product in products)
            {
                totalCost += product.GetPriceOfProduct();
            }

            if (customer.LivesInUsa())
            {
                return totalCost + 5;
            }
            else
            {
                return totalCost + 35;
            }
        }

        public string GetPackingLabel()
        {
            string packingLabel = "";
            foreach (Product product in products)
            {
                packingLabel += product.GetName() + " (" + product.GetProductId() + ")\n";
            }

            return packingLabel;
        }

        public string GetShippingLabel()
        {
            return customer.GetName() + "\n" + customer.GetAddress().ToString();
        }
    }
}