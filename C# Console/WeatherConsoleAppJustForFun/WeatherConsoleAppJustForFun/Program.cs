using System;

namespace WeatherConsoleAppJustForFun
{
    class Program
    {
        static void Main(string[] args)
        {
            IIPService IPService = new IPService();
            IWeatherService weatherService = new WeatherService();


            while (true)
            {
                Console.WriteLine("[1] for weather forecast for current location(by city)");
                Console.WriteLine("[2] for weather forecast for inputed location(by city)");
                Console.WriteLine("[3] for exit");

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                Console.Clear();

                if (keyInfo.Key == ConsoleKey.D1)
                {
                    string cityName = IPService.GetIPInfo().city;
                    var weatherInfo = weatherService.GetWeatherInfo(cityName);

                    ConsoleWeatherInfoPrinter.Print(weatherInfo);
                }

                else if (keyInfo.Key == ConsoleKey.D2)
                {
                    Console.Write("City name: ");
                    string input = Console.ReadLine();

                    var weatherInfo = weatherService.GetWeatherInfo(input);

                    ConsoleWeatherInfoPrinter.Print(weatherInfo);
                }

                else if (keyInfo.Key == ConsoleKey.D3)
                    break;

            }
        }
    }
}
