using Arcaim.DesignPatterns.Factory.IngredientsFactories;

namespace Arcaim.DesignPatterns.Factory.Mexico
{
    public class MexicanPizzaFactory : Pizzeria
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            var ingredientsFactory = new MexicoIngredientsPizzaFactory();

            if (type.Equals("cheese"))
            {
                pizza = new MexicanCheesePizza(ingredientsFactory);
            } else if (type.Equals("pepperoni"))
            {
                pizza = new MexicanPepperoniPizza(ingredientsFactory);
            } else if (type.Equals("seafood"))
            {
                pizza = new MexicanSeafoodPizza(ingredientsFactory);
            } else if (type.Equals("vegetarian"))
            {
                pizza = new MexicanVegetarianPizza(ingredientsFactory);
            }

            return pizza;
        }
    }
}