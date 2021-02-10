using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_3
{
    class MyGenClass<T1, T2>
    {
        public T1 Value { get; set; }
        public T2 Value2 { get; set; }

        public MyGenClass(T1 val)
        {
            Value = val;
        }
    }

    class MyArray<T>
    {
        private T[] array;

        public int Length { get; } // it is just readonly

        public T this[int index]
        {
            get => array[index];
            set => array[index] = value;
        }

        public MyArray(int len)
        {
            array = new T[len];
            Length = len;
        }
    }


    class Program
    {
        public static int FindMax(int a, int b)
        {
            return a > b ? a : b;
        }
        public static int FindMax(int a, int b, int c)
        {
            return a > b && a > c ? a : 
                            b > c ? b : c;
        }
        public static int FindMax(int a, int b, int c, int d)
        {
            return a > b && a > c && a > d ? a :
                            b > c && b > d ? b :
                                     c > d ? c : d;
        }


        //public static void Reverse(ref int[] arr) // O(n)
        //{
        //    var temp = new int[arr.Length];

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        temp[i] = arr[arr.Length - 1 - i];
        //    }

        //    arr = temp;
        //}

        //public static void Reverse(int[] arr) // O(n/2)
        //{
        //    int len = arr.Length;

        //    for (int i = 0; i < len; i++, len--)
        //    {
        //        int temp = arr[i];
        //        arr[i] = arr[len - 1];
        //        arr[len - 1] = temp;
        //    }
        //}

        //public static void Reverse(int[] arr) // O(n/2)
        //{
        //    int i = 0, len = arr.Length;

        //    while (i < len)
        //    {
        //        int temp = arr[i];
        //        arr[i] = arr[len - 1];
        //        arr[len - 1] = temp;

        //        i++; len--;
        //    }
        //}

        //public static void Reverse(int[] arr) // O(n/2)
        //{
        //    int len = arr.Length;

        //    for (int i = 0; i < len/2; i++)
        //    {
        //        int temp = arr[i];
        //        arr[i] = arr[len - 1 - i];
        //        arr[len - 1 - i] = temp;
        //    }
        //}
        public static void Reverse(int[] arr) // probably O(n/2)
        {
            Array.Reverse(arr);
        }


        public static void Print<T>(T val)
        {
            Console.WriteLine(val);
        }
        public static void Print<T1, T2>(T1 val, T2 val1)
        {
            Console.WriteLine(val + "-" + val1);
        }

        public static int[] i = new int[5];

        class MyInheritList<T> : List<T>
        {

        }


        public static int Sum(params int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

        static void Main(string[] args)
        {

            int[] _1Darr = new int[5]; // one dimensional

            int[,] _2Darr = new int[3, 4] // two dimensional
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12}
            };

            Console.WriteLine(_2Darr[0, 2]); // 3


            for (int i = 0; i < _2Darr.GetLength(0); i++)
            {
                for (int j = 0; j < _2Darr.GetLength(1); j++)
                {
                    Console.Write(_2Darr[i, j] + " ");
                }
                Console.WriteLine();
            }



            // dimension
            // 3D, 2D

            // UTC

            /// ///

            //// int sum = Sum(new int[] { 1, 2, 3, 4, 5 });
            //int sum = Sum(1, 2, 3, 4, 5, 6, 7, 8, 9); // with params

            //Console.WriteLine(sum);

            /// ///

            //int[] arr = new int[5]; // type is reference // array is class -> class is reference

            //MyArray<int> array = new MyArray<int>(5); // same as the above (almost)

            //array[0] = 17;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}


            // LINQ // 

            //var list = new List<string>()
            //{
            //    "Hello", "World"
            //};

            //var nList = list.Where(x => x.Length > 4);

            //foreach (var item in nList)
            //    Console.Write(item + " ");


            /// ///

            // Print(12, "Hello");

            // MyGenClass<string> my = new MyGenClass<string>("Hello");

            // MyGenClass<int> my = new MyGenClass<int>();


            /// /// /// /// 


            //Random random = new Random();

            //int num = random.Next(-10 , 0);

            //Console.WriteLine(num);

            //num = random.Next(1, 11);

            //Console.WriteLine(num);

            //num = random.Next();

            //Console.WriteLine(num);


            /// /// /// /// 


            //int[] arr = new int[] { 1, 2, 3, 4, 5 };

            //foreach (var item in arr)
            //    Console.Write(item + " ");
            //Console.WriteLine();

            //Reverse(arr);

            //foreach (var item in arr)
            //    Console.Write(item + " ");
            //Console.WriteLine();

            /// ///

            //int max = FindMax(3, 3, 3);

            //Console.WriteLine(max);
        }
    }
}
