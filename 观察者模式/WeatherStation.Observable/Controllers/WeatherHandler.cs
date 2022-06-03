using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.Observable.Models;

namespace WeatherStation.Observable.Controllers
{
    public class WeatherHandler : IObservable<WeatherData>
    {
        private List<IObserver<WeatherData>> _observers;
        private WeatherData _weatherData;

        public WeatherHandler()
        {
            _observers = new List<IObserver<WeatherData>>();
            _weatherData = new WeatherData();
        }

        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
            return new Unsubscriber<WeatherData>(_observers, observer);
        }
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }
        public void SetMeasurements(double temperature, double humidity, double pressure)
        {
            _weatherData.Temperature = temperature;
            _weatherData.Humidity = humidity;
            _weatherData.Pressure = pressure;
            MeasurementsChanged();
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.OnNext(_weatherData);
            }
        }
    }
    public class Unsubscriber<WeatherData> : IDisposable
    {
        private readonly List<IObserver<WeatherData>> _observers;
        private readonly IObserver<WeatherData> _observer;

        public Unsubscriber(List<IObserver<WeatherData>> observers, IObserver<WeatherData> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null && _observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}
