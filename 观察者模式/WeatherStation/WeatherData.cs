using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class WeatherData : ISubject
    {
        private List<ICObserver> _observers;
        private double _temperature;
        private double _humidity;
        private double _pressure;

        public WeatherData()
        {
            _observers = new List<ICObserver>();
        }

        public void NotifyObservers()
        {
            foreach (var item in _observers)
            {
                item.Update(_temperature, _humidity, _pressure);
            }
        }

        public void RegisterObserver(ICObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(ICObserver o)
        {
            _observers.Remove(o);
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(double temperature, double humidity, double pressure)
        {
            _temperature = temperature; 
            _humidity = humidity; 
            _pressure = pressure;
            MeasurementsChanged();
        }

    }
}
