using System;
using Arcaim.DesignPatterns.Observer.Simple;

namespace Arcaim.DesignPatterns.Observer.DotNet
{
    public class CurrentCondition : IObserver<WeatherData>, IDisplayElement
    {
        private float _humidity;
        private float _tempetature;
        private IDisposable _cancellation;

        public void Display()
        {
            System.Console.WriteLine($"Current conditions: {_tempetature} degrees Celsius and {_humidity} % humidity");
        }

        public void OnCompleted()
        {
            // throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            // throw new NotImplementedException();
        }

        public void OnNext(WeatherData value)
        {
            _humidity = value.Humidity;
            _tempetature = value.Tempetature;

            Display();
        }

        public void Subscribe(StationWheader provider)
        {
            _cancellation = provider.Subscribe(this);
        }

        public void Unsubscribe()
        {
            _cancellation.Dispose();
        }
    }
}