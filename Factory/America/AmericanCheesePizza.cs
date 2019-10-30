using Arcaim.DesignPatterns.Factory.IngredientsFactories;

namespace Arcaim.DesignPatterns.Factory.America
{
    public class AmericanCheesePizza : Pizza
    {
        private readonly IPizzaIngredientsFactory _pizzaIngredientsFactory;

        public AmericanCheesePizza(IPizzaIngredientsFactory pizzaIngredientsFactory)
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