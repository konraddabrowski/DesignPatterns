using Arcaim.DesignPatterns.Decorator.Additives;
using Arcaim.DesignPatterns.Decorator.Caffee;

namespace Arcaim.DesignPatterns.Decorator
{
    public static class DecoratorClient
    {
        public static void Run()
        {
            Drink drink = new Expresso();
            System.Console.WriteLine($"{drink.GetDescription()}: {drink.Price()} zł");

            drink = new Chocolate(drink);
            drink = new Chocolate(drink);
            drink = new WhippedCream(drink);
            System.Console.WriteLine($"{drink.GetDescription()}: {drink.Price()} zł");
        }
    }
}