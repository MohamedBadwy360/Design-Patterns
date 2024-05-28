namespace _02_Decorator.After
{
    // Concrete Component
    public class StrawberryIceCream : IceCream
    {
        public override string Description => "Strawberry IceCream";

        public override decimal CalculateCost() => 5.5m;
    }
}
