using System;

namespace Foundation02
{
public class Address
    {
        private string streetAddress;
        private string city;
        private string state;
        private string country;

        public Address(string streetAddress, string city, string state, string country)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.state = state;
            this.country = country;
        }

        public string GetStreetAddress()
        {
            return streetAddress;
        }

        public string GetCity()
        {
            return city;
        }

        public string GetState()
        {
            return state;
        }

        public string GetCountry()
        {
            return country;
        }

        public bool IsInUsa()
        {
            return country.Equals("USA");
        }

        public string ToString()
        {
            return streetAddress + "\n" + city + ", " + state + " " + country;
        }
    }
}