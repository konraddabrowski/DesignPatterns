namespace Arcaim.DesignPatterns.Decorator.Caffee
{
    public class StronglyRoasted : Drink
    {
        public StronglyRoasted()
        {
            description = "Strongly roasted caffee";
        }

        public override double Price()
        {
            return 0.99;
        }
    }
}