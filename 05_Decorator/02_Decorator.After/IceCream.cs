namespace _02_Decorator.After
{
    // Component
    public abstract class IceCream
    {
        public abstract string Description { get; }
        public abstract decimal CalculateCost();

        public override string ToString()
        {
            return $"{Description} ({CalculateCost().ToString("C")})";
        }
    }
}
