using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.Event.Models;

namespace WeatherStation.Event.Controllers
{
    public class WeatherHandler //: IObservable<WeatherData>
    {

        private WeatherData _weatherData;

        public event EventHandler<WeatherData>? MeasurementsChanged;

        public WeatherHandler()
        {
            _weatherData = new WeatherData();
        }

        public void SetMeasurements(double temperature, double humidity, double pressure)
        {
            _weatherData.Temperature = temperature;
            _weatherData.Humidity = humidity;
            _weatherData.Pressure = pressure;
            MeasurementsChanged?.Invoke(this, _weatherData);
        }
    }
}
