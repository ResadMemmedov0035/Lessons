using System.Net;
using System.Text.Json;
using WeatherConsoleAppJustForFun.Models;

namespace WeatherConsoleAppJustForFun
{
    class WeatherService : IWeatherService
    {
        private string baseURL = @"http://api.openweathermap.org/data/2.5/weather?appid=619607d6b9523abaa7ee9d084538ca3d";

        private WebClient web = new WebClient();

        public WeatherInfo GetWeatherInfo(string cityName)
        {
            string json = web.DownloadString(baseURL + "&units=metric"+ $"&q={cityName}");
            return JsonSerializer.Deserialize<WeatherInfo>(json);
        }
    }

}
