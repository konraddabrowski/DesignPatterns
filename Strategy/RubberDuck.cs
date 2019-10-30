using Arcaim.DesignPatterns.Strategy.Behaviour;

namespace Arcaim.DesignPatterns.Strategy
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            this.SetFly(new IcanNotFly());
            this.SetQuack(new Squealing());
        }

        public override void Display()
        {
            System.Console.WriteLine("I'm Rubber Duck and...");
            Fly();
            Quack();
        }
    }
}