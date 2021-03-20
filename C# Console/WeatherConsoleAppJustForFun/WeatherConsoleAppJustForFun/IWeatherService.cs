using WeatherConsoleAppJustForFun.Models;

namespace WeatherConsoleAppJustForFun
{
    interface IWeatherService
    {
        WeatherInfo GetWeatherInfo(string cityName);
    }

}
