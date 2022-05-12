using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.Event.Controllers;
using WeatherStation.Event.Models;

namespace WeatherStation.Event.Views
{
    public class CurrentConditionsDisplay : DisplayBase
    {
        private double _temperature;
        private double _humidity;

        public CurrentConditionsDisplay(WeatherHandler provider) : base(provider)
        {
        }

        protected override void LoadData(WeatherData value)
        {
            _temperature = value.Temperature;
            _humidity = value.Humidity;
        }

        protected override void Display()
        {
            Console.WriteLine($"Current conditions: {_temperature}C degrees and {_humidity}% humidity");
        }
    }
}
