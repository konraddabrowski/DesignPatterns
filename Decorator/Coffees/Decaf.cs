namespace Arcaim.DesignPatterns.Decorator.Caffee
{
    public class Decaf : Drink
    {
        public Decaf()
        {
            description = "Decaf coffee";
        }

        public override double Price()
        {
            return 1.05;
        }
    }
}