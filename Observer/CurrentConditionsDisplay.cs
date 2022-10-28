using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Interfaces;

namespace Observer
{
    internal class CurrentConditionsDisplay : IDisplayElements, IObserver
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public void Display()
        {
            Console.WriteLine($"Current conditions: {_temperature}F degree , {_humidity} humidity, {_pressure} pressure");
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
