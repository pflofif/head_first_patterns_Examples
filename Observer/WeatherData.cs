using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Interfaces;

namespace Observer
{
    internal class WeatherData : ISubject
    {
        private readonly List<IObserver> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;
        public WeatherData()
        {
            _observers = new List<IObserver>();
        }
        public void RegisterObserver(IObserver o) => _observers.Add(o);

        public void RemoveObserver(IObserver o) => _observers.Remove(o);

        public void NotifyObserver() =>
            _observers.ForEach(observer => observer.Update(_temperature, _humidity, _pressure));

        public void MeasurementChanged() => NotifyObserver();

        public void SetMeasurement(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementChanged();
        }
    }
}
