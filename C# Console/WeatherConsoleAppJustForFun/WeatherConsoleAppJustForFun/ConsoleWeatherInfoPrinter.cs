using System;
using WeatherConsoleAppJustForFun.Models;

namespace WeatherConsoleAppJustForFun
{
    static class ConsoleWeatherInfoPrinter
    {
        static public void Print(WeatherInfo weatherInfo)
        {
            Console.WriteLine(weatherInfo.name);
            Console.WriteLine("---------------");
            Console.WriteLine("  " + weatherInfo.main.temp + "°C");
            Console.WriteLine("  " + DateTime.UtcNow.AddHours(4).Hour);
            Console.WriteLine("  " + weatherInfo.weather[0].main);
        }
    }
}
