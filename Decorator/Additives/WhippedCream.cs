namespace Arcaim.DesignPatterns.Decorator.Additives
{
    public class WhippedCream : DrinkDecorator
    {
        public WhippedCream(Drink drink) : base(drink)
        {
        }

        public override string GetDescription()
        {
            return _drink.GetDescription() + ", whipped milk";
        }

        public override double Price()
        {
            return _drink.Price() + 0.10;
        }
    }
}