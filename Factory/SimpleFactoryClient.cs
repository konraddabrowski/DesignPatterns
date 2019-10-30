using Arcaim.DesignPatterns.Factory.Italia;

namespace Arcaim.DesignPatterns.Factory
{
    public static class SimpleFactoryClient
    {
        public static void Run()
        {
            Pizzeria italianPizza = new ItalianPizzaFactory();
            var pizza = italianPizza.Order("cheese");
            System.Console.WriteLine(pizza.ToString());
        }
    }
}