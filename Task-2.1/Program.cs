using System;

namespace Task2_1_DiscountStrategy
{
    // Delegate for discount strategy
    public delegate double DiscountStrategy(double price);

    class Program
    {
        // Discount methods
        static double FestivalDiscount(double price) => price * 0.8; // 20% off
        static double SeasonalDiscount(double price) => price * 0.9; // 10% off
        static double NoDiscount(double price) => price;            // no discount

        // Method using delegate
        static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
        {
            return strategy(originalPrice);
        }

        static void Main(string[] args)
        {
            double originalPrice = 5000.0;

            double festivalPrice = CalculateFinalPrice(originalPrice, FestivalDiscount);
            double seasonalPrice = CalculateFinalPrice(originalPrice, SeasonalDiscount);
            double noDiscountPrice = CalculateFinalPrice(originalPrice, NoDiscount);

            Console.WriteLine($"Original Price: {originalPrice}");
            Console.WriteLine($"Festival Discount (20%): {festivalPrice}");
            Console.WriteLine($"Seasonal Discount (10%): {seasonalPrice}");
            Console.WriteLine($"No Discount: {noDiscountPrice}");

            // Lambda expression for 30% discount
            double lambdaDiscountPrice = CalculateFinalPrice(
                originalPrice,
                price => price * 0.7 // 30% off
            );

            Console.WriteLine($"Lambda 30% Discount: {lambdaDiscountPrice}");

            Console.ReadLine();
        }
    }
}
