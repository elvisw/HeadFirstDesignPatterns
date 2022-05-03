using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public interface ICObserver
    {
        public void Update(double temp, double humidity, double pressure);
    }
}
