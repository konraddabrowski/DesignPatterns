using Arcaim.DesignPatterns.Strategy.Behaviour;

namespace Arcaim.DesignPatterns.Strategy
{
    public class WildDuck : Duck
    {
        public WildDuck()
        {
            this.SetFly(new Flying());
            this.SetQuack(new Quacking());
        }

        public override void Display()
        {
            System.Console.WriteLine("I'm Wild Duck and...");
            Fly();
            Quack();
        }
    }
}