using System;

namespace Lesson_1
{

    //struct MyStruct
    //{
    //    public int a;

    //    public MyStruct(int num)
    //    {
    //        a = num;
    //    }
    //}

    //class MyClass
    //{
    //    public int i;

    //    public readonly int r;

    //    public const int c = 120;

    //    public static int s;

    //    public MyClass(int a)
    //    {
    //        r = a;
    //    }

    //}

    class MyClass
    {
        public int num;

        public MyClass()
        {
            num = 0;
            Console.WriteLine("first ctor");
            // ...
        }

        //static MyClass()
        //{
        //    Console.WriteLine("Static CTOR");
        //}

        public MyClass(int i) : this()
        {
            num = i;
        }

        public MyClass(string s, int i) : this(i)
        {
            Console.WriteLine("third ctor");
        }
    }

    //class Person
    //{
    //    public int MyProperty { get; set; }

    //    public string Name;
    //    public int Age;
    //    public Job Job;
    //}

    //class Job
    //{
    //    int Id;
    //    string JobName;
    //}

    class My
    {

    }

    enum DaysOfWeeks : sbyte // 0 - 255
    {
        Monday = 5, Tuesday, Wednesday, Thursday = 21, Friday, Saturday, Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            DaysOfWeeks day = DaysOfWeeks.Sunday;

            Console.WriteLine( (int)day + "    " + day.GetTypeCode()); // explicit casting

            //int number = 10;
            //Console.WriteLine("number");

            byte b = 10;
            int i = b; // implicit casting

            //switch (day)
            //{
            //    case DaysOfWeeks.Sunday:
            //        Console.WriteLine("sunday");
            //        break;

            //    default:
            //        break;
            //}


            //int a = 0, b= 0;

            //var na = a++;
            //var na1 =  ++b;

            //Console.WriteLine(na + "  " + na1);

            //Person p = new Person()
            //{
            //    Name = "Resad",
            //    Age = 18,
            //    Job = new Job(),
            //    MyProperty = 0
            //};


            // int a; // local variable

            //MyClass my1 = new MyClass();
            //MyClass my2 = new MyClass();
            //MyClass my3 = new MyClass();
            //MyClass my4 = new MyClass();
            //MyClass my5 = new MyClass();

            //MyClass my = new MyClass();

            //Console.WriteLine(my.num);

            //MyClass my1 = new MyClass(12);

            //Console.WriteLine(my1.num);


            // value - struct / reference - class types //

            //MyClass my = new MyClass(10);
            //MyClass my = new MyClass(20);

            //Console.WriteLine(MyClass.c);
            //Console.WriteLine(MyClass.s);

            //MyStruct myStruct = new MyStruct();
            //MyStruct my = new MyStruct(20); // same as the above
            //Console.WriteLine(my.a);


            // built-in reference //
            // string, array, class, object, delegate, interface, void




            //long l = 1_000_000_000; // digit seperator
            //long l1 = 1000000000; // same as the above




            //int, short, bool, long, float, double, char, string, object, byte, decimal

            //byte // unsigned
            //sbyte // signed

            //int - 4 // signed
            //uint - 4 // unsigned

            // byte -- 1 byte
            // short -- 2 byte
            // int -- 4 byte
            // long -- 8 byte

            // bool -- 1 byte

            // float -- 4 byte
            // double -- 8 byte
            // decimal -- 16 byte

            // char -- 2 byte - unicode

            // ascii -- 1 byte
            // unicode -- 2 byte

            // 1. Readable
            // 2. Logic
            // 3. Universalliq
            // 4. Updateable olabilmesi
        }
    }
}
