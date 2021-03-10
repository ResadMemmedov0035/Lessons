using System;
using System.IO;
using System.Net;
using System.Text.Json;

namespace Lesson_13
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient web = new WebClient();
            string url = "https://api.exchangeratesapi.io/latest?base=USD";

            string json = web.DownloadString(url);
            var exchange = JsonSerializer.Deserialize<Exchange>(json);

            Console.WriteLine(exchange.@base + ": ");
            Console.WriteLine("USD - " + exchange.rates.USD);
            Console.WriteLine("EUR - " + exchange.rates.EUR);
            Console.WriteLine("GBP - " + exchange.rates.GBP);
            Console.WriteLine("TRY - " + exchange.rates.TRY);
        }
    }

    public class Exchange
    {
        public Rates rates { get; set; }
        public string @base { get; set; }
        public DateTime date { get; set; }
    }

    public class Rates
    {
        public decimal CAD { get; set; }
        public decimal HKD { get; set; }
        public decimal ISK { get; set; }
        public decimal PHP { get; set; }
        public decimal DKK { get; set; }
        public decimal HUF { get; set; }
        public decimal CZK { get; set; }
        public decimal GBP { get; set; }
        public decimal RON { get; set; }
        public decimal SEK { get; set; }
        public decimal IDR { get; set; }
        public decimal INR { get; set; }
        public decimal BRL { get; set; }
        public decimal RUB { get; set; }
        public decimal HRK { get; set; }
        public decimal JPY { get; set; }
        public decimal THB { get; set; }
        public decimal CHF { get; set; }
        public decimal EUR { get; set; }
        public decimal MYR { get; set; }
        public decimal BGN { get; set; }
        public decimal TRY { get; set; }
        public decimal CNY { get; set; }
        public decimal NOK { get; set; }
        public decimal NZD { get; set; }
        public decimal ZAR { get; set; }
        public decimal USD { get; set; }
        public decimal MXN { get; set; }
        public decimal SGD { get; set; }
        public decimal AUD { get; set; }
        public decimal ILS { get; set; }
        public decimal KRW { get; set; }
        public decimal PLN { get; set; }
    }

}
