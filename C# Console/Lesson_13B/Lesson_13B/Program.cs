using System;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Lesson_13B
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex("");

            string str = "AA12345678";

            bool check = true;

            if (str[0] != 'A' || str[1] != 'A') check = false;

            if (str.Length != 10) check = false;

            if (!int.TryParse(str.Substring(2), out int r)) check = false;

            Console.WriteLine(check);

            /*

            WebClient web = new WebClient();
            string url =
                $"http://api.openweathermap.org/data/2.5/weather?appid=619607d6b9523abaa7ee9d084538ca3d&units=metric&q=";

            Console.Write("Seher adini daxil edin: ");
            string cityName = Console.ReadLine();

            string json = web.DownloadString(url + cityName);

            var weatherInfo = JsonSerializer.Deserialize<WeatherInfo>(json);

            Console.WriteLine($"{weatherInfo.main.temp}°C");


            /*

            WebClient web = new WebClient();
            string url = $"http://www.omdbapi.com/?apikey=7b2ba0b2&s=";

            Console.Write("Film adini daxil edin: ");
            string movieName = Console.ReadLine();

            string json = web.DownloadString(url + movieName);

            var imdbInfo = JsonSerializer.Deserialize<IMDbInfo>(json);


            if (imdbInfo.Response == "True")
            {
                foreach (var movie in imdbInfo.Search)
                {
                    Console.WriteLine($"\t{movie.Title}");
                }
            }
            else Console.WriteLine("Bu adda film tapilmadi!");


            /*

            WebClient web = new WebClient();
            string url = "http://ip-api.com/json/";

            string json = web.DownloadString(url);
            IPInfo ipInfo = JsonSerializer.Deserialize<IPInfo>(json);

            Console.WriteLine(ipInfo.city);

            */
        }
    }


    public class WeatherInfo
    {
        public Coord coord { get; set; }
        public Weather[] weather { get; set; }
        public string _base { get; set; }
        public Main main { get; set; }
        public int visibility { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public int dt { get; set; }
        public Sys sys { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }

    public class Coord
    {
        public float lon { get; set; }
        public float lat { get; set; }
    }

    public class Main
    {
        public float temp { get; set; }
        public float feels_like { get; set; }
        public float temp_min { get; set; }
        public float temp_max { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
    }

    public class Wind
    {
        public float speed { get; set; }
        public int deg { get; set; }
    }

    public class Clouds
    {
        public int all { get; set; }
    }

    public class Sys
    {
        public int type { get; set; }
        public int id { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

}
