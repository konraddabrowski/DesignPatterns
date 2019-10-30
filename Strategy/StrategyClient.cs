// Wzorzec Strategia definiuje rodzinę algorytmów, pakuje je jako
// osobne klasy i powoduje, że są one w pełni wymienne. Zastosowanie
// tego wzorca pozwala na to, aby zmiany w implementacji algorytmów
// przetwarzania były całkowicie niezależne od strony klienta, który
// z nich korzysta.

namespace Arcaim.DesignPatterns.Strategy
{
    public static class StrategyClient
    {
        public static void Run()
        {
            var rubberDuck = new RubberDuck();
            var wildDuck = new WildDuck();

            System.Console.WriteLine("Rubber Duck:");
            rubberDuck.Display();

            System.Console.WriteLine("Wild Duck:");
            wildDuck.Display();
        }
    }
}