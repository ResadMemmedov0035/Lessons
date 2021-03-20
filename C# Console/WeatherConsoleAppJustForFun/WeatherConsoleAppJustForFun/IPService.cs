using System.Net;
using System.Text.Json;
using WeatherConsoleAppJustForFun.Models;

namespace WeatherConsoleAppJustForFun
{
    class IPService : IIPService
    {
        private string url = @"http://ip-api.com/json/";

        private WebClient web = new WebClient();

        public IPInfo GetIPInfo()
        {
            string json = web.DownloadString(url);
            return JsonSerializer.Deserialize<IPInfo>(json);
        }
    }
}
