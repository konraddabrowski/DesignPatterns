namespace Arcaim.DesignPatterns.Decorator
{
    public abstract class DrinkDecorator : Drink
    {
        protected Drink _drink;

        protected DrinkDecorator(Drink drink)
        {
            _drink = drink;
        }
    }
}