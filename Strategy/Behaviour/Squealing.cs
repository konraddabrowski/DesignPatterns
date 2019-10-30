namespace Arcaim.DesignPatterns.Strategy.Behaviour
{
    public class Squealing : IQuack
    {
        public void Quack()
        {
            System.Console.WriteLine("I'm squealing..."); // Piszczę
        }
    }
}