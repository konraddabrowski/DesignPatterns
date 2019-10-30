namespace Arcaim.DesignPatterns.Strategy.Behaviour
{
    public class Flying : IFly
    {
        public void Fly()
        {
            System.Console.WriteLine("I can fly becouse I have wings");
        }
    }
}