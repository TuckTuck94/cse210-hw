 using System;

namespace Foundation02
{
 public class Customer
    {
        private string name;
        private Address address;

        public Customer(string name, Address address)
        {
            this.name = name;
            this.address = address;
        }

        public string GetName()
        {
            return name;
        }

        public Address GetAddress()
        {
            return address;
        }

        public bool LivesInUsa()
        {
            return address.IsInUsa();
        }
    }
}