namespace Arcaim.DesignPatterns.Decorator.Caffee
{
    public class StarCafeSpecial : Drink
    {
        public StarCafeSpecial()
        {
            description = "Star Cafe Special Caffee";
        }

        public override double Price()
        {
            return 0.89;
        }
    }
}