using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_14
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString() => $"{Name}, {Age}";
    }

    class Program
    {
        delegate void MyDelegate();

        delegate int SomeDelegate(int a, int b);

        static int Sum(int num1, int num2) { return num1 + num2; }


        delegate bool Check<T>(T item);

        static void Filter<T>(T[] arr, Predicate<T> check)
        {
            foreach (var item in arr)
            {
                if (check(item))
                    Console.WriteLine(item);
            }
        }

        static bool PositiveCheck(int num) { return num > 0; }

        static bool EvenCheck(int num) { return num % 2 == 0; }

        static bool LenCheck(string str) { return str.Length > 3; }

        static void Print(string name)
        {
            Console.WriteLine("My name is " + name);
        }

        static string Foo(int a, int b) { return (a + b).ToString(); }


        static bool ExistItem<T>(List<T> list, Predicate<T> match)
        {
            foreach (var item in list)
            {
                if (match(item)) return true;
            }
            return false;
        }

        static bool IsHigherThan100(int num) { return num > 100; }

        static void Main(string[] args)
        {
            /*

            var personList = new List<Person>
            {
                new Person { Name = "Resad", Age = 17 },
                new Person { Name = "Behruz", Age = 21 },
                new Person { Name = "Rasim", Age = 20 },
                new Person { Name = "Anar", Age = 20 }
            };

            personList.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
            personList.ForEach(x => Console.WriteLine(x));

            */



            var list = new List<int> { 2, 45, -8, 99, -67, -21 };

            var convertedList = list.ConvertAll(x => (long)x);

            convertedList.ForEach(x => Console.WriteLine(x));


            //if (list.TrueForAll(x => x < 100))
            //{
            //    Console.WriteLine("DA");
            //}
            //else Console.WriteLine("NYET");


            // list.ForEach(num => Console.WriteLine(num));


            //if (list.Exists(num => num > 100)/*ExistItem(list, x => x > 100)*/)
            //{
            //    Console.WriteLine("Exists");
            //}
            //else Console.WriteLine("Doesn't exist");


            //int num = list.Find(x => x > 0);
            //Console.WriteLine(num);

            //int num1 = list.FindLast(x => x > 0);
            //Console.WriteLine(num1);

            //List<int> newList = list.FindAll(x => x > 0);
            //newList.ForEach(x => Console.WriteLine(x));
            //Console.WriteLine();


            //list.RemoveAll(x => x > 0);
            //list.ForEach(x => Console.WriteLine(x));

            
            //list.Sort((x, y) => x - y);
            //list.ForEach(x => Console.WriteLine(x));



            /*

            Predicate<int> predicate = num => num > 0;

            int[] arr = new int[] { 12, -43, 66, 87, -51, -2 };

            Filter(arr, num => num > 0);


            Action action = () =>
            {
                Console.WriteLine("Hello world");
                Console.WriteLine("Ola");
            };

            action();


            /*

            Predicate<int> predicate = delegate (int num) { return num > 0; };

            int[] arr = new int[] { 12, -43, 66, 87, -51, -2 };

            Filter(arr, delegate (int num) { return num > 0; });


            /*

            //Action;
            //Func;
            //Predicate;

            Predicate<int> predicate = PositiveCheck;
            Predicate<string> predicate1 = LenCheck;

            //

            Func<int, int, string> func = Foo;

            //

            Action action = Print;

            Action<string> action1 = Print;

            action1("Resad");

            action();
            // action?.Invoke();


            /*

            int[] arr = new int[] { 12, -43, 66, 87, -51, -2 };

            Filter(arr, PositiveCheck);

            string[] strArr = new string[] { "Hello", "Ola", "Hi", "Four", "Apple" };

            Filter<string>(strArr, LenCheck);


            //Check check = PositiveCheck;
            //check += EvenCheck; // sonuncu subscribe olunan return olunur



            /*

            SomeDelegate someDelegate = Sum;

            int sum = someDelegate(12, 45);

            Console.WriteLine(sum);


            /*

            MyDelegate myDelegate = Print;
            // MyDelegate myDelegate = new MyDelegate(Print); // same as the above

            myDelegate += PrintSomething;
            myDelegate += PrintSomethingElse;

            myDelegate = Print;

            myDelegate();
            // myDelegate.Invoke(); // same as the above

            */
        }

        static void Print()
        {
            Console.WriteLine("Something");
        }
        static void PrintSomething()
        {
            Console.WriteLine("Print Something");
        }
        static void PrintSomethingElse()
        {
            Console.WriteLine("Print Something Else");
        }
    }
}
