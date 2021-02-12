using System;
using System.Collections.Generic;

namespace Lesson_5
{

    class MyClass
    {
        public int Num { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(DateTime.Now.ToShortDateString());

            var begin = DateTime.Now;

            int i = 0;
            while (i < 10000_000)
            {
                i++;
            }

            var end = DateTime.Now;

            Console.WriteLine(end.Subtract(begin).TotalMilliseconds); // 1 san. = 1000 millisan.



            /// /// /// ///
            


            //Console.Write("Eded daxil edin: ");
            //int i = int.Parse(Console.ReadLine());

            //string str = i switch
            //{
            //    1 => "Bir",
            //    2 => "Iki",
            //    3 => "Uc",
            //    _ => "No data"
            //};

            ////switch (i)
            ////{
            ////    case 1: str = "Bir"; break;
            ////    case 2: str = "Iki"; break;
            ////    case 3: str = "Uc"; break;
            ////    default: str = "No data"; break;
            ////}

            ////if (i == 1) str = "Bir";
            ////else if (i == 2) str = "Iki";
            ////else if (i == 3) str = "Uc";
            ////else str = "No data";

            //Console.WriteLine(str);



            /// /// /// ///


            //var dic = new Dictionary<int, string>();


            //dic[10] = "Hello";
            //dic[11] = "World";
            //dic[12] = "Hi";
            //dic[13] = "Hola";
            //dic[14] = "Resad";




            //if (dic.TryAdd(9, "Salam"))
            //{
            //    Console.WriteLine(dic[9]);
            //}
            //else Console.WriteLine("Key onsuzda var");


            //// dic.ContainsKey(10)
            //if (dic.TryGetValue(10, out string value))
            //{
            //    Console.WriteLine(value);
            //}
            //else Console.WriteLine("Bele bir data yoxdur");


            //var contain = dic.ContainsKey(9);
            ////            dic.ContainsValue()

            //if (!contain) dic[9] = "Hello";

            //Console.WriteLine(dic[9]);


            ///


            //foreach (var item in dic.Keys)
            //    Console.WriteLine(item);

            //foreach (var item in dic.Values)
            //    Console.WriteLine(item);


            ///


            //dic.Add(10, "Hello");
            //dic.Add(10, "World"); // error

            //dic[10] = "Hello";
            //dic[10] = "world"; // not error

            //Console.WriteLine(dic[10]);



            /// /// /// ///


            //List<MyClass> mies = new List<MyClass>();
            //var m = new MyClass() { Num = 10 };
            //mies.Add(m);
            //Console.WriteLine(mies.Contains(m));



            //List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

            //Console.WriteLine("toString: " + list.ToString());

            //bool c =  list.Contains(5);
            //Console.WriteLine(c);
            //list.Insert(0, 100);
            //list.AddRange(new int[] { 8, 9, 10 }); // list-de elave oluna biler (daha dogrusu IEnumerable)

            //int[] array = list.ToArray();

            //foreach (var item in list)
            //    Console.WriteLine(item);



            /// /// /// ///



            //int[] arr = new int[] { 1, 2, 3, 4, 5 };
            //// arr.Rank // dimension length // so arr.Rank --> 1
            //int[] arr1 = new int[7];
            //arr.CopyTo(arr1, 0);

            //foreach (var item in arr1)
            //{
            //    Console.WriteLine(item);
            //}

            /// /// 


            //int[][,] arr2 = new int[][,] // arr2's Length --> 1 , arr2[0]'s Length --> 6
            //{
            //    new int[,]
            //    { 
            //        { 1, 2, 3 }, 
            //        { 4, 5, 6 } 
            //    }
            //};

            //int[][] jarr = new int[][] // jagged array
            //{
            //    new int[]{ 1, 2, 3, 4, 5 },
            //    new int[]{ 6, 7, 8 },
            //    new int[]{ 9, 10, 11, 12 }
            //};

            //foreach (var arr in jarr)
            //{
            //    foreach (var item in arr)
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < jarr.Length; i++)
            //{
            //    for (int j = 0; j < jarr[i].Length; j++)
            //    {
            //        Console.Write(jarr[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            /// /// 


            // int[] arr = new int[] { 1, 2, 3, 4 };

            //int[,] _2Darr = new int[,] // _2Darr's Length --> 6
            //{
            //    { 1, 2, 3 },
            //    { 4, 5, 6}
            //};

            //for (int i = 0; i < _2Darr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < _2Darr.GetLength(1); j++)
            //    {
            //        Console.Write(_2Darr[i, j]);
            //    }
            //    Console.WriteLine();
            //}


            //int[,,] _3Darr = new int[2, 2, 3]
            //{
            //    {
            //        { 1, 2, 3 },
            //        { 4, 5, 6}
            //    },
            //    {
            //        { 7, 8, 9},
            //        { 10, 11, 12 }
            //    }
            //};

            //for (int i = 0; i < _3Darr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < _3Darr.GetLength(1); j++)
            //    {
            //        for (int k = 0; k < _3Darr.GetLength(2); k++)
            //        {
            //            Console.Write(_3Darr[i, j, k] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine("-------------------");
            //}
        }
    }
}
