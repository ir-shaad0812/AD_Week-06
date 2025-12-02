namespace Task_02
{
    public delegate int CalculateFunc(int x, int y);
    internal class Program
    {
        static void Main(string[] args)
        {

            CalculateFunc caldel;

            caldel = Calculate.Add;
            Console.WriteLine($"Add  of :{caldel(10, 5)}");

            caldel = Calculate.Sub;
            Console.WriteLine($"Sub of :{caldel(10, 5)}");
        }
    }
}
