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
                //事件订阅
                provider.MeasurementsChanged += RefreshData;
        }

        //事件处理，并从e获取数据
        //WeatherData不再派生自 System.EventArgs，所以e参数的类型可以直接为WeatherData
        //private void RefreshData(object? sender, EventArgs e)
        private void RefreshData(object? sender, WeatherData e)
        {
            //LoadData((WeatherData)e);
            LoadData(e);
            Display();
        }

        protected abstract void LoadData(WeatherData value);
        protected abstract void Display();


        public virtual void Subscribe(WeatherHandler provider)
        {
            //事件订阅
            provider.MeasurementsChanged += RefreshData;
        }

        public virtual void Unsubscribe(WeatherHandler provider)
        {
            //事件退订
            provider.MeasurementsChanged -= RefreshData;
        }

    }
}
