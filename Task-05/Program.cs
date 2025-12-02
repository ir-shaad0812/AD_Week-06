using System;
using System.Collections.Generic;
using System.Linq;

namespace Task5_LINQAggregationQuantifierElement
{
    public class CashierSales
    {
        public string CashierName { get; set; }
        public double SalesAmount { get; set; }
    }

    public class Applicant
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Music
    {
        public string Title { get; set; }
        public int DurationInSeconds { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Aggregation operators
            List<CashierSales> salesList = new List<CashierSales>
            {
                new CashierSales { CashierName = "A", SalesAmount = 5000 },
                new CashierSales { CashierName = "B", SalesAmount = 7000 },
                new CashierSales { CashierName = "C", SalesAmount = 3000 },
                new CashierSales { CashierName = "D", SalesAmount = 9000 }
            };

            int totalCashiers = salesList.Count();
            double totalSales = salesList.Sum(s => s.SalesAmount);
            double maxSales = salesList.Max(s => s.SalesAmount);
            double minSales = salesList.Min(s => s.SalesAmount);
            double avgSales = salesList.Average(s => s.SalesAmount);

            Console.WriteLine("Aggregation Operators:");
            Console.WriteLine($"Total cashiers: {totalCashiers}");
            Console.WriteLine($"Total sales: {totalSales}");
            Console.WriteLine($"Max sales: {maxSales}");
            Console.WriteLine($"Min sales: {minSales}");
            Console.WriteLine($"Average sales: {avgSales}");

            // Quantifier operators
            List<Applicant> applicants = new List<Applicant>
            {
                new Applicant { Name = "Person 1", Age = 17 },
                new Applicant { Name = "Person 2", Age = 19 },
                new Applicant { Name = "Person 3", Age = 21 },
                new Applicant { Name = "Person 4", Age = 16 }
            };

            bool anyUnder18 = applicants.Any(a => a.Age < 18);
            bool allAbove16 = applicants.All(a => a.Age > 16);

            Console.WriteLine("\nQuantifier Operators:");
            Console.WriteLine($"Any applicant under 18: {anyUnder18}");
            Console.WriteLine($"All applicants above 16: {allAbove16}");

            // Element operators
            List<Music> songs = new List<Music>
            {
                new Music { Title = "Song A", DurationInSeconds = 180 },
                new Music { Title = "Song B", DurationInSeconds = 250 },
                new Music { Title = "Song C", DurationInSeconds = 400 },
                new Music { Title = "Song D", DurationInSeconds = 700 }
            };

            var firstSong = songs.First();  // first in list
            var lastSong = songs.Last();    // last in list

            var firstAbove4Min = songs.First(s => s.DurationInSeconds > 240);   // >4 min
            var above10Min = songs.FirstOrDefault(s => s.DurationInSeconds > 600); // >10 min

            Console.WriteLine("\nElement Operators:");
            Console.WriteLine($"First song: {firstSong.Title}");
            Console.WriteLine($"Last song: {lastSong.Title}");
            Console.WriteLine($"First song longer than 4 minutes: {firstAbove4Min.Title}");

            if (above10Min == null)
            {
                Console.WriteLine("No song longer than 10 minutes.");
            }
            else
            {
                Console.WriteLine($"First song longer than 10 minutes: {above10Min.Title}");
            }

            Console.ReadLine();
        }
    }
}
