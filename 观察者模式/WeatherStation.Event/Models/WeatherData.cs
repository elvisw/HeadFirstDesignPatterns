using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.Event.Models
{

    //public class WeatherData : EventArgs
    //.NET Core 中，WeatherData不需要派生自 System.EventArgs
    public class WeatherData
    {
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double Pressure { get; set; }
    }
}
