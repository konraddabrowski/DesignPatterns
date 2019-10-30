namespace Arcaim.DesignPatterns.Strategy.Behaviour
{
    public class IcanNotFly : IFly
    {
        public void Fly()
        {
            System.Console.WriteLine("I can not fly :(");
        }
    }
}