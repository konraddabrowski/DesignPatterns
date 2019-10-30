using Arcaim.DesignPatterns.Factory.IngredientsFactories;

namespace Arcaim.DesignPatterns.Factory.America
{
    public class AmericanPepperoniPizza : Pizza
    {
        private readonly IPizzaIngredientsFactory _pizzaIngredientsFactory;

        public AmericanPepperoniPizza(IPizzaIngredientsFactory pizzaIngredientsFactory)
        {
            _pizzaIngredientsFactory = pizzaIngredientsFactory;
        }

        public override void Preparation()
        {
            System.Console.WriteLine($"Przygotowanie: {GetName()}");
            this.cake = _pizzaIngredientsFactory.CreateCake();
            this.sauce = _pizzaIngredientsFactory.CreateSauce();
            this.cheese = _pizzaIngredientsFactory.CreateCheese();
        }
    }
}