namespace Arcaim.DesignPatterns.Factory
{
    public abstract class Pizzeria
    {
        // private readonly SimplyPizzaFactory _factory;

        // public Pizzeria(SimplyPizzaFactory factory)
        // {
        //     _factory = factory;
        // }

        public Pizza Order(string type)
        {
            Pizza pizza;

            pizza = CreatePizza(type);

            pizza.Preparation();
            pizza.Baking();
            pizza.Cutting();
            pizza.Packing();
            
            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}