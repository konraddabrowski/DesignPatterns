using Arcaim.DesignPatterns.Observer.Simple.Observables;

namespace Arcaim.DesignPatterns.Observer.Simple.Observers
{
    public class Forecast : IObserver, IDisplayElement
    {
        private IObservable _observable;
        private float _humidity;
        private float _tempetature;

        public Forecast(IObservable observable)
        {
            _observable = observable;
            _observable.Register(this);
        }

        public void Display()
        {
            System.Console.WriteLine($"Tomorrow will be great weather!");
        }

        public void Update(float tempetature, float humidity, float pressure)
        {
            _tempetature = tempetature;
            _humidity = humidity;
            Display();
        }
    }
}