namespace Arcaim.DesignPatterns.Strategy.Behaviour
{
    public class Silent : IQuack
    {
        public void Quack()
        {
            System.Console.WriteLine("I'm not quacking ...silent");
        }
    }
}