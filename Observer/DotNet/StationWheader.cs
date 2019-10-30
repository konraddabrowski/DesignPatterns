using System;
using System.Collections.Generic;
using System.Linq;

namespace Arcaim.DesignPatterns.Observer.DotNet
{
    public class StationWheader : IObservable<WeatherData>
    {
        private List<IObserver<WeatherData>> _observers;
        private WeatherData _currentData;

        public StationWheader()
        {
            _observers = new List<IObserver<WeatherData>>();
            _currentData = new WeatherData();
        }

        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }

            return new Unsubscriber<WeatherData>(_observers, observer);
        }

        public void InformObservers()
        {
            _observers.ForEach(o => o.OnNext(_currentData));
        }

        public void SetReading(float tempetature, float humidity, float pressure)
        {
            _currentData.SetReading(tempetature, humidity, pressure);
            InformObservers();
        }

        private class Unsubscriber<T> : IDisposable
        {
            private List<IObserver<WeatherData>> _observers;
            private IObserver<WeatherData> _observer;

            public Unsubscriber(List<IObserver<WeatherData>> observers, IObserver<WeatherData> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                if (_observers.Contains(_observer))
                {
                    _observers.Remove(_observer);
                }
            }
        }
    }
}