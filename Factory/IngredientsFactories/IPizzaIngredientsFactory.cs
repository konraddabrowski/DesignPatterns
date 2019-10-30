// Wzorzec fabryka abstrakcyjna dostarcza interfejs do tworzenia
// całych rodzin spokrewnionych lub zależnych od siebie obiektów
// bez konieczności określania ich klas rzeczywistych

using Arcaim.DesignPatterns.Factory.Ingredients.Cakes;
using Arcaim.DesignPatterns.Factory.Ingredients.Cheeses;
using Arcaim.DesignPatterns.Factory.Ingredients.Meats;
using Arcaim.DesignPatterns.Factory.Ingredients.Sauces;
using Arcaim.DesignPatterns.Factory.Ingredients.Seafood;
using Arcaim.DesignPatterns.Factory.Ingredients.Vegetables;

namespace Arcaim.DesignPatterns.Factory.IngredientsFactories
{
    public interface IPizzaIngredientsFactory
    {
        Cake CreateCake();
        Sauce CreateSauce();
        Cheese CreateCheese();
        Vegetable[] CreateVegetables();
        Pepperoni CreatePepperoni();
        Clams CreateClams();
    }
}