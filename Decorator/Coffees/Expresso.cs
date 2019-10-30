namespace Arcaim.DesignPatterns.Decorator.Caffee
{
    public class Expresso : Drink
    {
        public Expresso()
        {
            description = "Expresso coffee";
        }

        public override double Price()
        {
            return 1.99;
        }
    }
}