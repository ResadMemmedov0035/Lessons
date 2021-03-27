using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;

namespace Lesson_16_Some_LINQ_Playing_
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = File.ReadAllText("Data.json");
            var people = JsonConvert.DeserializeObject<Person[]>(json);

            Console.WriteLine(people.First(x => x.Salary > 7000));
            Console.WriteLine(people.FirstOrDefault(x => x.Salary > 17000));

            Console.WriteLine(people.Last(x => x.Salary > 7000));
            Console.WriteLine(people.LastOrDefault(x => x.Salary > 70000));


            //var newList = people.Where(p => p.Country == "Azerbaijan" && p.Salary > 5000);

            //foreach (var item in newList)
            //{
            //    Console.WriteLine(item);
            //}



            // Count, Max, Min, Sum, Average

            //Console.WriteLine(people.Count(p => p.Salary > 8000));
            //Console.WriteLine(people.Count(p => p.Country == "Azerbaijan"));

            //Console.WriteLine(people.Max(p => p.Salary));
            //Console.WriteLine(people.Max(p => p.BirthDate));
            ////Console.WriteLine("{0:N0}", people.Max(p => (DateTime.Now - p.BirthDate).TotalDays / 365));

            //Console.WriteLine(people.Min(p => p.Salary));
            //Console.WriteLine(people.Min(p => p.BirthDate));

            //Console.WriteLine(people.Sum(p => p.Salary));

            //Console.WriteLine(people.Average(p => p.Salary));
        }
    }

    public class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Job { get; set; }
        public decimal Salary { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return $"{ID} {FirstName} {LastName} {Job} {Salary} {Email} {Phone} { Gender} {BirthDate} {Country} {City}";
        }
    }

}
