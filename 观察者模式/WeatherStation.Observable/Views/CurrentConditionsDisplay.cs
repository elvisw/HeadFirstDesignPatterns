using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.Observable.Controllers;
using WeatherStation.Observable.Models;

namespace WeatherStation.Observable.Views
{
    public class CurrentConditionsDisplay : DisplayBase
    {
        private double _temperature;
        private double _humidity;

        public CurrentConditionsDisplay(WeatherHandler provider) : base(provider)
        {
        }

        public override void OnNext(WeatherData value)
        {
            _temperature = value.Temperature;
            _humidity = value.Humidity;
            Display();
        }

        public override void Display()
        {
            Console.WriteLine($"Current conditions: {_temperature}C degrees and {_humidity}% humidity");
        }
    }
}
