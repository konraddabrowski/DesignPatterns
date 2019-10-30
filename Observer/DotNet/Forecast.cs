using System;
using Arcaim.DesignPatterns.Observer.Simple;

namespace Arcaim.DesignPatterns.Observer.DotNet
{
    public class Forecast : IObserver<WeatherData>, IDisplayElement
    {
        private float _humidity;
        private float _pressure;
        private IDisposable _cancellation;

        public void Display()
        {
            System.Console.WriteLine($"Tomorrow will be great weather!");
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
            _pressure = value.Pressure;

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