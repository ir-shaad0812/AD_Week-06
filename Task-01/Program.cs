class Program
{
    static void Main()
    {
        var rect= new Rectangle { Length = 5, Height = 3 };

        Console.WriteLine($"Area: {rect.GetArea()}");          // 15
        Console.WriteLine($"Perimeter: {rect.GetPerimeter()}"); // 16
    }
}
