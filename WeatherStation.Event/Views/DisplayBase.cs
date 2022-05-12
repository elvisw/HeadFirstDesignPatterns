using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.Event.Controllers;
using WeatherStation.Event.Models;

namespace WeatherStation.Event.Views
{
    public abstract class DisplayBase
    {
        public DisplayBase(WeatherHandler provider)
        {
            if (provider != null)
                provider.MeasurementsChanged += RefreshData;
        }

        private void RefreshData(object? sender, EventArgs e)
        {
            LoadData((WeatherData)e);
            Display();
        }

        protected abstract void LoadData(WeatherData value);
        protected abstract void Display();


        public virtual void Subscribe(WeatherHandler provider)
        {
            provider.MeasurementsChanged += RefreshData;
        }

        public virtual void Unsubscribe(WeatherHandler provider)
        {
            provider.MeasurementsChanged -= RefreshData;
        }

    }
}
