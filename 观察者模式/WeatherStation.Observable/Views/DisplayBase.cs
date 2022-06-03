using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.Observable.Controllers;
using WeatherStation.Observable.Models;

namespace WeatherStation.Observable.Views
{
    public abstract class DisplayBase : IObserver<WeatherData>, IDisplayElement
    {
        private IDisposable? _unsubscriber;

        public DisplayBase(WeatherHandler provider)
        {
            if (provider != null)
                _unsubscriber = provider.Subscribe(this);
        }


        public virtual void Subscribe(WeatherHandler provider)
        {
            _unsubscriber = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            if (_unsubscriber != null)
            {
                _unsubscriber.Dispose();
            }
        }

        public void OnCompleted()
        {
            Console.WriteLine("Weather station has completed transmitting data");
            if (_unsubscriber != null)
            {
                _unsubscriber.Dispose();
            }
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Error occured {0}", error);
        }

        public abstract void OnNext(WeatherData value);
        public abstract void Display();

    }
}
