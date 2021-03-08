using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace Lesson_12
{
    [Serializable]
    public class Person
    {
        public Person() { }

        public Person(string surname, string name, int age)
        {
            Surname = surname;
            Name = name;
            Age = age;
        }

        public string Surname { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}, {Age}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Binary, XML, Json

            /// Json Serializtion ///

            /// Read ///

            string pjson = File.ReadAllText("people.json");
            var people = JsonSerializer.Deserialize<List<Person>>(pjson);

            foreach (var item in people)
            {
                Console.WriteLine(item);
            }

            //

            string json = File.ReadAllText("person.json");
            Person person = JsonSerializer.Deserialize<Person>(json);

            Console.WriteLine(person);

            /* 
            /// Write ///

            var people = new List<Person>
            {
                new Person("Memmedov", "Resad", 17),
                new Person("Filnakesov", "Rovshen", 17),
                new Person("Aliyev", "Rasim", 20),
                new Person("Filankesov", "Behruz", 21)
            };

            string peoplejson = JsonSerializer.Serialize(people);
            File.WriteAllText("people.json", peoplejson);

            //

            Person person = new Person("Memmedov", "Resad", 17);

            string json = JsonSerializer.Serialize(person);
            File.WriteAllText("person.json", json);




            /// XML Serialization ///
            /// 
            /// needs: parameterless ctor, public class

            /*
            /// Read /// 

            Person person;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));

            using (var fileStream = new FileStream("person.xml", FileMode.Open))
            {
                person = xmlSerializer.Deserialize(fileStream) as Person;
            }
            Console.WriteLine(person);

            /*
            /// Write ///

            var people = new List<Person>
            {
                new Person("Memmedov", "Resad", 17),
                new Person("Filnakesov", "Rovshen", 17),
                new Person("Aliyev", "Rasim", 20),
                new Person("Filankesov", "Behruz", 21)
            };
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));

            using (var fileStream = new FileStream("people.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fileStream, people);
            }



            /// Binary Serialization ///
            /// 
            /// needs: [Serializable]

            /*
            /// Read ///

            var formatter = new BinaryFormatter();
            List<Person> people;

            using (var fileStream = new FileStream("people.bin", FileMode.Open))
            {
                people = formatter.Deserialize(fileStream) as List<Person>;
            }

            foreach (var item in people)
            {
                Console.WriteLine(item);
            }


            /*
            /// Write ///

            var formatter = new BinaryFormatter();

            var people = new List<Person>
            {
                new Person("Memmedov", "Resad", 17),
                new Person("Filnakesov", "Rovshen", 17),
                new Person("Aliyev", "Rasim", 20),
                new Person("Filankesov", "Behruz", 21)
            };

            using (var fileStream = new FileStream("people.bin", FileMode.Create))
            {
                formatter.Serialize(fileStream, people);
            }



            /// File stream with FileStream with StreamWriter/Reader
            /// 


            /* Read **

            using (FileStream fstream = new FileStream("superfile.txt", FileMode.Open))
            {
                using (StreamReader sreader = new StreamReader(fstream))
                {
                    while (!sreader.EndOfStream)
                    {
                        Console.WriteLine(sreader.ReadLine());
                    }

                    //string str = sreader.ReadToEnd();
                    //Console.WriteLine(str);
                }
            }

            /* Write **

            using (FileStream fstream = new FileStream("superfile.txt", FileMode.Create))
            {
                using (StreamWriter swriter = new StreamWriter(fstream))
                {
                    string str = "Hi my friend";
                    swriter.Write(str);
                }
            }


            /// File stream with FileStream
            /// 


            /* Read **

            using (FileStream fstream = new FileStream("sample.txt", FileMode.Open))
            {
                byte[] buffer = new byte[20];
                fstream.Read(buffer, 0, 20);
                string str = Encoding.UTF8.GetString(buffer);

                Console.WriteLine(str);
            }

            ///

            //FileStream fstream = new FileStream("sample.txt", FileMode.Open);

            //byte[] buffer = new byte[20];
            //fstream.Read(buffer, 0, 20);
            //string str = Encoding.UTF8.GetString(buffer);

            //Console.WriteLine(str);

            //fstream.Close();


            /* Write **

            //using (Person person = new Person())
            //{
            //    Console.WriteLine("In using");
            //}

            using (FileStream fstream = new FileStream("sample.txt", FileMode.Create))
            {
                string str = "Hello World";
                byte[] buffer = Encoding.UTF8.GetBytes(str);
                fstream.Write(buffer, 0, buffer.Length);
            }

            ///

            //FileStream fstream = new FileStream("sample.txt", FileMode.Create);

            //string str = "Hello World";
            //byte[] buffer = Encoding.UTF8.GetBytes(str);
            //fstream.Write(buffer, 0, buffer.Length);

            //fstream.Close();



            /// File stream with File ///
            /// 

            // Read //
            /*

            string[] people = File.ReadAllLines("people.txt");
            foreach (var item in people)
            {
                Console.WriteLine(item + "-");
            }
            Console.WriteLine();

            /*

            string data = File.ReadAllText("people.txt");
            Console.WriteLine(data);
            

            // Write //
            /*

            string[] strArr = new string[] { "Resad", "Rovhen", "Anar", "Behruz" };
            File.WriteAllLines("people.txt", strArr);


            /*

            string str = "Another text";
            File.WriteAllText(@"..\..\..\another.txt", str);

            /*

            string str = "Some text";
            File.WriteAllText(@"C:\Users\hp\Desktop\test.txt", str);

            /*

            string str = "Salam dunya";
            File.WriteAllText("hello.txt", str);

            */
        }
    }
}
