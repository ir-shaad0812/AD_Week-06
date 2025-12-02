using System;

namespace Task3_FuncProcessNumbers
{
    class Program
    {
        // Method that takes Func<int, bool> to filter numbers
        static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
        {
            foreach (int n in numbers)
            {
                if (condition(n))
                {
                    Console.WriteLine(n);
                }
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 4, 7, 12, 15, 20 };

            Console.WriteLine("Even numbers:");
            ProcessNumbers(numbers, n => n % 2 == 0);

            Console.WriteLine("\nNumbers greater than 10:");
            ProcessNumbers(numbers, n => n > 10);

            Console.ReadLine();
        }
    }
}
