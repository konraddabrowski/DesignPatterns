namespace Arcaim.DesignPatterns.Strategy.Behaviour
{
    public class Quacking : IQuack
    {
        public void Quack()
        {
            System.Console.WriteLine("I'm quacking..."); // Kwaczę
        }
    }
}