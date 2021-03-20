using System;
using System.Threading;
using System.Linq;
using System.Collections.Generic;

namespace Lesson_15
{
    delegate void MyDelegate();

    class Test
    {
        public event MyDelegate MyEvent;
        public MyDelegate myDelegate;

        public void Foo()
        {
            MyEvent?.Invoke();
        }
    }

    class Timer
    {
        private event Action timeOut;

        public event Action TimeOut
        {
            add 
            {
                timeOut += value;
                Console.WriteLine("Added");
            }
            remove
            {
                timeOut -= value;
                Console.WriteLine("Removed");
            }
        }

        public void StartTimer(int sec)
        {
            for (int i = 1; i <= sec; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }
            timeOut?.Invoke();
        }
    }

    static class MyClass
    {
        public static void Method<T>(this List<T> list)
        { 

        }
    }

    class Program
    {
        static void Print()
        {
            Console.WriteLine("Hi my friend");
        }

        static void PrintTimeOut()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Time out");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 1, 16, 2, 3, 3, 3, 4, 4 };
            List<int> list1 = new List<int> { 1, 1, 3, 3 };
            List<string> strList1 = new List<string> { "Hello", "World", "Hi", "Excuse" };

            var newList = list.Where(x => x % 2 == 0);

            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();



            var seList = list.Select(x => x / 2f);

            foreach (var item in seList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();



            Console.WriteLine(strList1.Max(s => s.Length));


            // list.Last() // first-nen eyni mentiq

            
            var intersect = list.Intersect(list1);
            foreach (var item in intersect)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            int first = list.First(i => i % 2 == 0);

            Console.WriteLine(first);


            var nList = list.Distinct();

            foreach (var item in nList)
            {
                Console.WriteLine(item);
            }


            if (list.Any(x => x > 10)) 
                Console.WriteLine("Yes");
            else 
                Console.WriteLine("No");


            int sum = list.Sum();

            List<string> strList = new List<string> { "Hello", "World" };

            decimal sum1 = strList.Sum(s => s.Length);

            Console.WriteLine(sum1);


            // list.Method();



            /*

            Timer timer = new Timer();

            timer.TimeOut += PrintTimeOut;

            timer.StartTimer(5);

            timer.TimeOut -= PrintTimeOut;

            /*

            Test test = new Test();

            test.MyEvent += () => Console.WriteLine("HEllo World");
            test.MyEvent += Print;

            test.Foo();

            /*

            test.MyEvent += Print; // () => Console.WriteLine("Hello"); // subscribe
            test.Foo();

            test.MyEvent -= Print; // () => Console.WriteLine("Hello"); // unsubscribe
            test.Foo();
            
            test.myDelegate += () => Console.WriteLine("World");
            test.myDelegate.Invoke();

            */
        }
    }
}
