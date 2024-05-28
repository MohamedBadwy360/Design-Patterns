namespace _02_Decorator.After
{
    // Concrete Decorator
    public class ChocolateChips : IceCreamDecorator
    {
        public ChocolateChips(IceCream iceCream) : base(iceCream)
        {
        }

        public override string Description => $"{base.Description} + ChocolateChips";

        public override decimal CalculateCost() => base.CalculateCost() + 0.45m;
    }
}
