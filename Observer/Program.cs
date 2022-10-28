// See https://aka.ms/new-console-template for more information

using Observer;

var currentDisplay = new CurrentConditionsDisplay();
var statisticDisplay = new StatisticDisplay();

var weatherData = new WeatherData();

weatherData.RegisterObserver(currentDisplay);
weatherData.RegisterObserver(statisticDisplay);

weatherData.SetMeasurement(12,11,991);
Console.WriteLine();
weatherData.SetMeasurement(100,199,1);
Console.WriteLine();
weatherData.SetMeasurement(121,1.1F,0.11F);
