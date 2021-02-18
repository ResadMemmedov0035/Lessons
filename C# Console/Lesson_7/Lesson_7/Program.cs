using System;
using System.Collections.Generic;
using System.IO;

namespace Lesson_7
{
    partial class MyClass
    {
        public List<int> list = new List<int>();

        public int Count => list.Count; // readonly prop //
    }

    class MyList
    {
        int[] arr;

        public MyList(params int[] arr)
        {
            this.arr = arr;
        }
    }


    static class ExtensionMethods
    {
        public static void PrintElems<T>(this List<T> list)
        {
            foreach (var item in list)
                Console.Write($"[{item}]");
            Console.WriteLine();
        }

        public static void Randomizer<T>(this List<T> list)
        { 
            /// some codes...
        }
    }

    class Program
    {
        public static double SquareArea(double side)
        {
            if (side < 0)
                throw new Exception("Side cannot be minus");
            return side * side;
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2,3,4,5, };

            list.PrintElems();
            list.Randomizer();



            /*

            int.TryParse("1wew0", out int num);

            Console.WriteLine(num);

            */


            /*

            int i = 0;

            string s = i switch
            {
                1 => "Uno",
                2 => "Dos",
                // 3 => ...
                _ => "Reqem deyil"
            };


            MyList myList = new MyList(1, 2, 3, 4, 5, 6);


            Console.WriteLine(SquareArea(-10));

            */


            /*

            try
            {
                throw new Exception("I am exception!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            */



            /*

            SignUpLogIn.SignUp(new User()
            {
                Name = "Resad",
                Password = "12345"
            });

            SignUpLogIn.LogIn("Resad", "1235");

            */


            /*

            int x = 5;
            int y = 5;

            x = (x++) - (--y); // x = 1, y = 4
            y = (y--) - (--x); // x = 0, y = 4

            Console.WriteLine(y); // 4

            */


            /*
             
            char ch = 'A';
            int i = ch; // implicit casting

            int num = 100;
            long lng = num; // implicit casting

            checked
            {
                long l1 = 3_000_000_000;
                int a = (int)l1; // explicit casting

                Console.WriteLine(a);
            }

            */
        }
    }
}
