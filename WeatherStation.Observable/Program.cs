// See https://aka.ms/new-console-template for more information

using WeatherStation.Observable.Controllers;
using WeatherStation.Observable.Views;

WeatherHandler provider = new WeatherHandler();

CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(provider);
StatisticsDisplay statisticsDisplay = new StatisticsDisplay(provider);
ForecastDisplay forecastDisplay = new ForecastDisplay(provider);

//暂时不订阅
HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(null!);

provider.SetMeasurements(80, 65, 30.4d);

Console.WriteLine("现在开始，HeatIndexDisplay也成为了观察者。");
//订阅
heatIndexDisplay.Subscribe(provider);
provider.SetMeasurements(82, 70, 29.2d);
//退订
heatIndexDisplay.Unsubscribe();
Console.WriteLine("HeatIndexDisplay不再是观察者。");

provider.SetMeasurements(78, 90, 29.2d);
