using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.Observable.Controllers;
using WeatherStation.Observable.Models;

namespace WeatherStation.Observable.Views
{
    public class ForecastDisplay : DisplayBase
    {
        private double _currentPressure = 29.92d;
        private double _lastPressure;

        public ForecastDisplay(WeatherHandler provider) : base(provider)
        {
        } 

        public override void Display()
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

        public override void OnNext(WeatherData value)
        {
            _lastPressure = _currentPressure;
            _currentPressure = value.Pressure;
            Display();
        }
    }
}
