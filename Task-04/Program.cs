using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4_LINQBasics
{
    public class Book
    {
        public string Title { get; set; }
        public double Price { get; set; }
    }

    public class Student
    {
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1) Projection: square numbers
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            var squares = numbers
                .Select(n => n * n)
                .ToList();

            Console.WriteLine("Squared numbers:");
            foreach (var s in squares)
            {
                Console.WriteLine(s);
            }

            // 2) Filtering: books above Rs. 1000
            List<Book> books = new List<Book>
            {
                new Book { Title = "Book A", Price = 800 },
                new Book { Title = "Book B", Price = 1200 },
                new Book { Title = "Book C", Price = 2000 },
                new Book { Title = "Book D", Price = 500 }
            };

            var expensiveBooks = books
                .Where(b => b.Price > 1000)
                .ToList();

            Console.WriteLine("\nBooks priced above Rs. 1000:");
            foreach (var book in expensiveBooks)
            {
                Console.WriteLine($"{book.Title} - Rs. {book.Price}");
            }

            // 3) Sorting: students alphabetically
            List<Student> students = new List<Student>
            {
                new Student { Name = "Sita" },
                new Student { Name = "Ram" },
                new Student { Name = "Bikash" },
                new Student { Name = "Anita" },
                new Student { Name = "Kiran" },
                new Student { Name = "Sunil" },
                new Student { Name = "Aman" },
                new Student { Name = "Dipesh" },
                new Student { Name = "Hari" },
                new Student { Name = "Laxmi" }
            };

            var sortedStudents = students
                .OrderBy(s => s.Name)
                .ToList();

            Console.WriteLine("\nStudents sorted alphabetically:");
            foreach (var s in sortedStudents)
            {
                Console.WriteLine(s.Name);
            }

            Console.ReadLine();
        }
    }
}
