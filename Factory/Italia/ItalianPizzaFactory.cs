using Arcaim.DesignPatterns.Factory.IngredientsFactories;

namespace Arcaim.DesignPatterns.Factory.Italia
{
    public class ItalianPizzaFactory : Pizzeria
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            var ingredientsFactory = new ItalianIngredientsPizzaFactory();

            if (type.Equals("cheese"))
            {
                pizza = new ItalianCheesePizza(ingredientsFactory);
            } else if (type.Equals("pepperoni"))
            {
                pizza = new ItalianPepperoniPizza(ingredientsFactory);
            } else if (type.Equals("seafood"))
            {
                pizza = new ItalianSeafoodPizza(ingredientsFactory);
            } else if (type.Equals("vegetarian"))
            {
                pizza = new ItalianVegetarianPizza(ingredientsFactory);
            }

            return pizza;
        }
    }
}