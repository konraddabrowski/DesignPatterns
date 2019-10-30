namespace Arcaim.DesignPatterns.Decorator.Additives
{
    public class Chocolate : DrinkDecorator
    {

        public Chocolate(Drink drink) : base(drink)
        {
        }

        public override string GetDescription()
        {
            return _drink.GetDescription() + ", chocolate";
        }

        public override double Price()
        {
            return _drink.Price() + 0.20;
        }
    }
}