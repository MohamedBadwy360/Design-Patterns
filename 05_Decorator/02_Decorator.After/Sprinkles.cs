namespace _02_Decorator.After
{
    // Concrete Decorator
    public class Sprinkles : IceCreamDecorator
    {
        public Sprinkles(IceCream iceCream) : base(iceCream)
        {
        }

        public override string Description => $"{base.Description} + Sprinkles";

        public override decimal CalculateCost() => base.CalculateCost() + 0.25m;    
    }
}
