using System;

namespace EventPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address("42 Wallaby Way", "Sydney", "AU", "77777");
            Lecture lecture = new Lecture("Lecture on Machine Learning", "Learn about the basics of machine learning", new DateTime(2023, 7, 10), new TimeSpan(0, 10, 0), address, "Dr. Smith", 100);
            Reception reception = new Reception("Reception for New Employees", "Meet your new colleagues and celebrate your new job", new DateTime(2023, 7, 15), new TimeSpan(18, 00, 0), address, "info@greatcompany.com");
            OutdoorGathering outdoorGathering = new OutdoorGathering("Outdoor Concert", "Enjoy a free concert in the park", new DateTime(2023, 7, 22), new TimeSpan(19, 00, 0), address, "The Weather is Sunny with a high of 75 degrees");


            Console.WriteLine("Standard Details:");
            Console.WriteLine(lecture.GetStandardDetails());
            Console.WriteLine(reception.GetStandardDetails());
            Console.WriteLine(outdoorGathering.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine("Full Details:");
            Console.WriteLine(lecture.GetFullDetails());
            Console.WriteLine(reception.GetFullDetails());
            Console.WriteLine(outdoorGathering.GetFullDetails());
        }
    }
}