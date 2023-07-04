using System;

namespace Foundation02
{
    public class Product
    {
        private string name;
        private int productId;
        private double price;
        private int quantity;

        public Product(string name, int productId, double price, int quantity)
        {
            this.name = name;
            this.productId = productId;
            this.price = price;
            this.quantity = quantity;
        }

        public string GetName()
        {
            return name;
        }

        public int GetProductId()
        {
            return productId;
        }

        public double GetPrice()
        {
            return price;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public double GetPriceOfProduct()
        {
            return price * quantity;
        }
    }
}