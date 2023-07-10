using System;

namespace EventPlanning
{
    abstract class Event
    {
        private string title;
        private string description;
        private DateTime date;
        private TimeSpan time;
        private Address address;

        public Event(string title, string description, DateTime date, TimeSpan time, Address address)
        {
            this.title = title;
            this.description = description;
            this.date = date;
            this.time = time;
            this.address = address;
        }

        public string GetStandardDetails()
        {
            return $"{title} - {description} - {date} - {time} - {address}";
        }

        public abstract string GetFullDetails();

        public string GetShortDescription()
        {
            return $"{GetType().Name}: {title} - {date}";
        }
    }
}

