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

        private readonly WeatherData _weatherData;

        //声明事件
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
            //触发事件，同时传送数据
            MeasurementsChanged?.Invoke(this, _weatherData);

            //下面是
            //MeasurementsChanged?.Invoke(this, _weatherData);
            //的完整写法

            //if (MeasurementsChanged != null)
            //{
            //    MeasurementsChanged(this, _weatherData);
            //}
        }
    }
}
