namespace _01_Decorator.Before
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var order = new IceCreamWithSprinkles();
            Console.WriteLine(order);
        }
    }
}
