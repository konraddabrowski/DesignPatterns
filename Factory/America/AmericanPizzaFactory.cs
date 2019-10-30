using Arcaim.DesignPatterns.Factory.IngredientsFactories;

namespace Arcaim.DesignPatterns.Factory.America
{
    public class AmericanPizzaFactory : Pizzeria
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            var ingredientsFactory = new AmericaIngredientsPizzaFactory();

            if (type.Equals("cheese"))
            {
                pizza = new AmericanCheesePizza(ingredientsFactory);
            } else if (type.Equals("pepperoni"))
            {
                pizza = new AmericanPepperoniPizza(ingredientsFactory);
            } else if (type.Equals("seafood"))
            {
                pizza = new AmericanSeafoodPizza(ingredientsFactory);
            } else if (type.Equals("vegetarian"))
            {
                pizza = new AmericanVegetarianPizza(ingredientsFactory);
            }

            return pizza;
        }
    }
}