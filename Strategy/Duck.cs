using System;
using Arcaim.DesignPatterns.Strategy.Behaviour;

namespace Arcaim.DesignPatterns.Strategy
{
    public abstract class Duck
    {
        private IFly _fly;
        private IQuack _quack;

        public void SetFly(IFly fly)
        {
            _fly = fly;
        }

        public void SetQuack(IQuack quack)
        {
            _quack = quack;
        }

        public void Quack()
        {
            _quack.Quack();
        }

        public void Fly()
        {
            _fly.Fly();
        }

        public void Swim()
        {
            System.Console.WriteLine("All ducks can swim");
        }

        public abstract void Display();
    }
}