using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_2
{
    class MyException : Exception
    {
        public MyException() : base("MyException was Throwed") { }
    }

    class MyClass
    {
        private int age;

        public int Name { get; set; } // prop
        public string Surname { get; set; }
        public int Age // propfull
        {
            get => age;
            set => age = value >= 0 ? value : age;
            //set 
            //{
            //    if (value >= 0)
            //        age = value;
            //}
        }


        // Encapsulation

        // c++ -> getter, setter
        //public string GetName()
        //{
        //    return name;
        //}
        //public void SetName(string name)
        //{
        //    this.name = name;
        //}
    }

    class MyClass2
    {
        public int Count { get; } // read-only property

        public int Count2 { get; private set; }

        public MyClass2(int c)
        {
            Count = c;
        }

        void Foo(int c)
        {
            Count2 = c;
        }
    }

    class MyIntArray
    {
        private int[] array;

        public int Count { get; }

        public int this[int index]
        {
            get => array[index]; /* return the specified index here */ 
            set => array[index] = value; /* set the specified index to value here */
        }

        public MyIntArray(int len)
        {
            array = new int[len];
            Count = len;
        }

        // OLMAMASI GEREKEN //
        //public int GetItem(int index)
        //{
        //    return array[index];
        //}

        //public void SetItem(int index, int item)
        //{
        //    array[index] = item;
        //}
    }

    class Program
    {
        public static void Foo()
        {
            try
            {
                throw new MyException();
            }
            finally { }
        }

        public static int FindMax(int a, int b)
        {
            return a > b ? a : b;
        }

        // ctrl + K + C  ---  for comment
        // ctrl + K + U  ---  for uncomment
        static void Main(string[] args)
        {
            //int l = int.Parse(Console.ReadLine());
            //MyIntArray array = new MyIntArray(l);

            //array[2] = 20;

            //for (int i = 0; i < array.Count; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
            

            //MyClass2 my2 = new MyClass2(21);

            //Console.WriteLine(my2.Count);


            /// /// /// /// /// /// /// /// /// /// /// ///
            
            //Console.OutputEncoding = Encoding.Unicode;
            //Console.InputEncoding = Encoding.Unicode;
            //string name = Console.ReadLine();

            //Console.WriteLine(name);

            /// /// /// /// /// /// /// /// /// /// /// ///
            

            //long number = int.MaxValue; // int -> long

            //number += 1;
            //unchecked
            //{ 
            //    number += 1;
            //}

            //checked
            //{
            //    number += 1;
            //}
            //Console.WriteLine(number);

            /// /// ///

            //int a = 32, b = 0;

            //try
            //{
            //    //Console.WriteLine(a / b);
            //    // throw new MyException();

            //    Foo();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}
            //finally
            //{
            //    Console.WriteLine("Finally was executed");
            //}


            /// /// /// /// /// /// /// /// /// /// /// ///

            //int max = FindMax(12, 10);

            //Console.WriteLine(max);


            /// /// ///


            //string str;

            //Console.Write("Ededi daxil edin: ");
            //int num = int.Parse(Console.ReadLine());

            //str = num % 2 == 0 ? "Even" : "Odd"; // same as the below
            ////if (num % 2 == 0) str = "Even";
            ////else str = "Odd";

            //Console.WriteLine(str);




            // condition ? then : else // ternary operator


            /// /// /// /// /// /// /// /// /// /// /// /// 


            //MyClass my = new MyClass()
            //{ 
            //    Num5 = 10
            //};

        }
    }
}

//class MyClass // ctrl + .
//{
//    //public const int c = 21;

//    //public static const string stcstrng = "Hello";

//    //public static string ss = "World";

//    //public readonly int Number;
//    //public readonly int Number1;
//    //public readonly int Number2;
//    //public readonly int Number3;
//    //public readonly int Number4;

//    //public int Num5;

//    //public MyClass(int number, int number1, int number2, int number3, int number4)
//    //{
//    //    Number = number;
//    //    Number1 = number1;
//    //    Number2 = number2;
//    //    Number3 = number3;
//    //    Number4 = number4;
//    //}
//}
