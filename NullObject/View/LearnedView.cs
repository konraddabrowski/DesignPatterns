using System;
using Arcaim.DesignPatterns.NullObject.Entities;

namespace Arcaim.DesignPatterns.NullObject.View
{
    public class LearnedView
    {
        private readonly ILearned _learned;

        public LearnedView(ILearned learned)
        {
            // if (learned == null) throw new ArgumentNullException();
            // if (learned.Name == null) throw new ArgumentNullException();
            // if (learned.Surname == null) throw new ArgumentNullException();

            _learned = learned;
        }

        public void RenderView()
        {
            Console.WriteLine("User name: " + _learned.Name);
            Console.WriteLine("User surname: " + _learned.Surname);
        }
    }
}