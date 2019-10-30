using System.Collections.Generic;
using Arcaim.DesignPatterns.Observer.Simple.Observables;
using Arcaim.DesignPatterns.Observer.Simple.Observers;

namespace Arcaim.DesignPatterns.Observer.Observables.Simple
{
    public class WeatherData : IObservable
    {
        private List<IObserver> _observers;
        private float _humidity;
        private float _pressure;
        private float _tempetature;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        // public void ReadingChanges()
        // {
        //     float tempetature = GetTemperature();
        //     float humidity = GetHumidity();
        //     float pressure = GetPressure();

        //     CurrentConditionsDisplay.Update(pretempetature, humidity, ssure);
        //     StatisticsDisplay.Update(tempetature, humidity, pressure);
        //     ForecastDisplay.Update(tempetature, humidity, pressure);
        // }

        public void InformObservers()
        {
            _observers.ForEach(o => o.Update(_tempetature, _humidity, _pressure));
        }

        public void Register(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void ReadChanges()
        {
            InformObservers();
        }

        public void SetReading(float tempetature, float humidity, float pressure)
        {
            _humidity = humidity;
            _pressure = pressure;
            _tempetature = tempetature;
            ReadChanges();
        }
    }
}