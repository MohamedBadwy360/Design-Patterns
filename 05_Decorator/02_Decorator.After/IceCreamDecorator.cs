namespace _02_Decorator.After
{
    // Decorator
    public abstract class IceCreamDecorator : IceCream
    {
        protected IceCream _iceCream;

        protected IceCreamDecorator(IceCream iceCream)
        {
            _iceCream = iceCream;
        }

        public override string Description => _iceCream.Description;
        public override decimal CalculateCost() => _iceCream.CalculateCost();
    }
}
