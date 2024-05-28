namespace _02_Decorator.After
{
    // Concrete Decorator
    public class FruitMix : IceCreamDecorator
    {
        public FruitMix(IceCream iceCream) : base(iceCream)
        {
        }

        public override string Description => $"{base.Description} + FruitMix";

        public override decimal CalculateCost() => base.CalculateCost() + 0.75m;
    }
}
