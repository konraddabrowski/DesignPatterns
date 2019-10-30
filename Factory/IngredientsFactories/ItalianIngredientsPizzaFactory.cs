using Arcaim.DesignPatterns.Factory.Ingredients.Cakes;
using Arcaim.DesignPatterns.Factory.Ingredients.Cheeses;
using Arcaim.DesignPatterns.Factory.Ingredients.Meats;
using Arcaim.DesignPatterns.Factory.Ingredients.Sauces;
using Arcaim.DesignPatterns.Factory.Ingredients.Seafood;
using Arcaim.DesignPatterns.Factory.Ingredients.Vegetables;

namespace Arcaim.DesignPatterns.Factory.IngredientsFactories
{
    public class ItalianIngredientsPizzaFactory : IPizzaIngredientsFactory
    {
        public Cake CreateCake()
        {
            return new ThinCrunchyDough();
        }

        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public Clams CreateClams()
        {
            return new FreshClams();
        }

        public Pepperoni CreatePepperoni()
        {
            return new PepperoniSlices();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public Vegetable[] CreateVegetables()
        {
            return new Vegetable[] {
                new Champignon(),
                new Onion(),
                new Garlic(),
                new RedPepper()
            };
        }
    }
}