using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class CurrentConditionsDisplay : ICObserver, IDisplayElement
    {
        private double _temperature;
        private double _humidity;
        private readonly ISubject _whetherData;

        public CurrentConditionsDisplay(ISubject whetherData)
        {
            _whetherData = whetherData;
            whetherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {_temperature}C degrees and {_humidity}% humidity"); 
        }

        public void Update(double temp, double humidity, double pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }
    }
}
