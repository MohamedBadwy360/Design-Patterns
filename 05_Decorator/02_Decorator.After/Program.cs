namespace _02_Decorator.After
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IceCream order = new BasicIceCream();
            order = new Sprinkles(order);
            order = new ChocolateChips(order);
            order = new FruitMix(order);

            IceCream order2 = new StrawberryIceCream();
            order2 = new Sprinkles(order2);

            Console.WriteLine(order);
            Console.WriteLine(order2);
        }
    }
}
