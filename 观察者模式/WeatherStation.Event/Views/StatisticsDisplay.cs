using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.Event.Controllers;
using WeatherStation.Event.Models;

namespace WeatherStation.Event.Views
{
    public class StatisticsDisplay : DisplayBase
    {
        private double _maxTemp;
        private double _minTemp = 200;
        private double _tempSum;
        private int _numReadings;

        public StatisticsDisplay(WeatherHandler provider) : base(provider)
        {
        }

        protected override void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " + (_tempSum / _numReadings)
            + "/" + _maxTemp + "/" + _minTemp);
        }

        protected override void LoadData(WeatherData value)
        {
            _tempSum += value.Temperature;
            _numReadings++;

            if (value.Temperature > _maxTemp)
            {
                _maxTemp = value.Temperature;
            }

            if (value.Temperature < _minTemp)
            {
                _minTemp = value.Temperature;
            }
        }
    }
}
