public class Rectangle
{
    // Auto-properties
    public double Length { get; set; }
    public double Height { get; set; }

    // Expression-bodied method for Area
    public double GetArea() => Length * Height;

    // New method: Perimeter = 2 * (Width + Height)
    public double GetPerimeter() => 2 * (Length + Height);
}
