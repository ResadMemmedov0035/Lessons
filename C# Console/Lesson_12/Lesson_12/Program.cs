using System;
using System.Collections.Generic;
using System.IO;

namespace Lesson_12
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

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
