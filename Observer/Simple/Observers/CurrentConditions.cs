using Arcaim.DesignPatterns.Observer.Simple.Observables;

namespace Arcaim.DesignPatterns.Observer.Simple.Observers
{
    public class CurrentConditions : IObserver, IDisplayElement
    {
        private IObservable _observable;
        private float _humidity;
        private float _tempetature;

        public CurrentConditions(IObservable observable)
        {
            _observable = observable;
            _observable.Register(this);
        }

        public void Display()
        {
            System.Console.WriteLine($"Current conditions: {_tempetature} degrees Celsius and {_humidity} % humidity");
        }

        public void Update(float tempetature, float humidity, float pressure)
        {
            _tempetature = tempetature;
            _humidity = humidity;
            Display();
        }
    }
}