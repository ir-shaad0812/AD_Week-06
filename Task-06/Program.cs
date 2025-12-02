using System;
using System.Collections.Generic;
using System.Linq;

namespace Task6_LINQTravelCompany
{
    public class TourBooking
    {
        public string CustomerName { get; set; }
        public string Destination { get; set; }
        public double Price { get; set; }
        public int DurationInDays { get; set; }
        public bool IsInternational { get; set; }
    }

    public class TourSummary
    {
        public string CustomerName { get; set; }
        public string Destination { get; set; }
        public string Category { get; set; } // Domestic / International
        public double Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<TourBooking> bookings = new List<TourBooking>
            {
                new TourBooking { CustomerName = "Alice", Destination = "Kathmandu", Price = 8000, DurationInDays = 3, IsInternational = false },
                new TourBooking { CustomerName = "Bob", Destination = "Pokhara", Price = 12000, DurationInDays = 5, IsInternational = false },
                new TourBooking { CustomerName = "Charlie", Destination = "Bangkok", Price = 20000, DurationInDays = 6, IsInternational = true },
                new TourBooking { CustomerName = "Dinesh", Destination = "Dubai", Price = 30000, DurationInDays = 7, IsInternational = true },
                new TourBooking { CustomerName = "Eva", Destination = "Chitwan", Price = 15000, DurationInDays = 4, IsInternational = false }
            };

            // 1) Filter: Price > 10000 and Duration > 4 days
            var filtered = bookings
                .Where(b => b.Price > 10000)
                .Where(b => b.DurationInDays > 4)
                .ToList();

            // 2) Project to summary
            var summaryList = filtered
                .Select(b => new TourSummary
                {
                    CustomerName = b.CustomerName,
                    Destination = b.Destination,
                    Category = b.IsInternational ? "International" : "Domestic",
                    Price = b.Price
                })
                .ToList();

            // 3) Sort: Domestic first, then International, then by price
            var sorted = summaryList
                .OrderBy(s => s.Category) // "Domestic" then "International"
                .ThenBy(s => s.Price)
                .ToList();

            // 4) Display
            Console.WriteLine("Tour Summary Report:");
            foreach (var tour in sorted)
            {
                Console.WriteLine("---");
                Console.WriteLine($"Customer: {tour.CustomerName}");
                Console.WriteLine($"Destination: {tour.Destination}");
                Console.WriteLine($"Category: {tour.Category}");
                Console.WriteLine($"Price: Rs. {tour.Price}");
            }

            Console.ReadLine();
        }
    }
}
