using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.Event.Models;

namespace WeatherStation.Event.Controllers
{
    public class WeatherHandler
    {

        private readonly WeatherData _weatherData;

        //声明事件
        //.NET Core 的模式较为宽松。 在此版本中，EventHandler<TEventArgs> 定义不再要求 TEventArgs 必须是派生自 System.EventArgs 的类。
        //因此WeatherData不需要派生自 System.EventArgs
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
