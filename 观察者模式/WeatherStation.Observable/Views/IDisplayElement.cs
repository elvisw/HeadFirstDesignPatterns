using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.Observable.Controllers;
using WeatherStation.Observable.Models;

namespace WeatherStation.Observable.Views
{
    public interface IDisplayElement
    {
        public void Display();
    }
}
