// See https://aka.ms/new-console-template for more information
using WeatherStation;

WeatherData weatherData = new WeatherData();

CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);

StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

weatherData.SetMeasurements(20, 65, 30.4);
weatherData.SetMeasurements(22, 70, 29.2);
weatherData.SetMeasurements(18, 90, 29.2);