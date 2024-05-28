namespace _02_Decorator.After
{
    // Concrete Component
    public class BasicIceCream : IceCream
    {
        public override string Description => "IceCream";

        public override decimal CalculateCost() => 3.5m;
    }
}
