namespace Arcaim.DesignPatterns.Decorator.Additives
{
    public class Milk : DrinkDecorator
    {
        public Milk(Drink drink) : base(drink)
        {
        }

        public override string GetDescription()
        {
            return _drink.GetDescription() + ", milk";
        }

        public override double Price()
        {
            return _drink.Price() + 0.10;
        }
    }
}