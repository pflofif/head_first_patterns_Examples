using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Interfaces;

namespace Observer
{
    internal class StatisticDisplay : IDisplayElements, IObserver
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public void Display()
        {
            Console.WriteLine($"TEMP: {_temperature}F degree , HUMIDITY: {_humidity}%, PRESSURE: {_pressure}");
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            Display();
        }
    }
}
