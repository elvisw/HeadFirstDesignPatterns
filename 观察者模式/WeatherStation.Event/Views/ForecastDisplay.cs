using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.Event.Controllers;
using WeatherStation.Event.Models;

namespace WeatherStation.Event.Views
{
    public class ForecastDisplay : DisplayBase
    {
        private double _currentPressure = 29.92d;
        private double _lastPressure;

        public ForecastDisplay(WeatherHandler provider) : base(provider)
        {
        } 

        protected override void Display()
        {
            Console.Write("Forecast: ");
            if (_currentPressure > _lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (_currentPressure == _lastPressure)
            {
                Console.WriteLine("More of the same");
            }
            else if (_currentPressure < _lastPressure)
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }
        }

        protected override void LoadData(WeatherData value)
        {
            _lastPressure = _currentPressure;
            _currentPressure = value.Pressure;
        }
    }
}
