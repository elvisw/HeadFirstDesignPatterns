using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public interface ISubject
    {
        public void RegisterObserver(ICObserver o);
        public void RemoveObserver(ICObserver o);
        public void NotifyObservers();
    }
}
