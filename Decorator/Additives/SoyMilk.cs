namespace Arcaim.DesignPatterns.Decorator.Additives
{
    public class SoyMilk : DrinkDecorator
    {
        public SoyMilk(Drink drink) : base(drink)
        {
        }

        public override string GetDescription()
        {
            return _drink.GetDescription() + ", soy milk";
        }

        public override double Price()
        {
            return _drink.Price() + 0.15;
        }
    }
}