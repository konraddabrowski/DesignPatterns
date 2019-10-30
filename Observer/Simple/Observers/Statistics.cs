using Arcaim.DesignPatterns.Observer.Simple.Observables;

namespace Arcaim.DesignPatterns.Observer.Simple.Observers
{
    public class Statistics : IObserver, IDisplayElement
    {
        private IObservable _observable;
        private float _humidity;
        private float _pressure;
        private float _tempetature;

        public Statistics(IObservable observable)
        {
            _observable = observable;
            _observable.Register(this);
        }

        public void Display()
        {
            System.Console.WriteLine($"Statistics...");
        }

        public void Update(float tempetature, float humidity, float pressure)
        {
            _tempetature = tempetature;
            _pressure = pressure;
            _humidity = humidity;
            Display();
        }
    }
}