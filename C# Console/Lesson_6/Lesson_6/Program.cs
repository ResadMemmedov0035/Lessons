using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lesson_6
{
    public static class MyClass
    {
        static void MyMethod<T>(this List<T> list)
        {

        }
    }

    class Program
    {
        static void Foo_ref(ref int a) // may be modified
        {
            var tmp = a;
            //a = 10;
            //a++;
        }

        static void Foo_out(out int a) // must be modified/assigned
        {
            a = 10;
        }

        static void Foo_in(in int a) // cannot be modified
        {
            // a = 10;  // sintaksis xeta //
        }


        static string RandPassGenerate(int len)
        {
            var password = new StringBuilder();
            var rand = new Random();

            string str = "qwertyuioplkjhgfdsazxcvbnm" +
                         "QWERTYUIOPLMNBVCXZASDFGHJK" +
                         "1234567890";

            for (int i = 0; i < len; i++)
                password.Append(str[rand.Next(0, str.Length)]);

            return password.ToString();
        }


        static void Main(string[] args)
        {

            /*

            DateTime time = DateTime.Now;

            while (true)
            {
                time = time.AddSeconds(1);
                Console.WriteLine(time.ToLongTimeString());
                Thread.Sleep(1000);
                Console.Clear();
            }

            */


            /*

            DateTime date = DateTime.Now;

            Console.WriteLine(date);


            var begin = DateTime.Now;

            RandPassGenerate(8);

            var end = DateTime.Now;


            var ts =  end.Subtract(begin);
            var ts1 = end - begin; // same as the above

            Console.WriteLine(ts.TotalMilliseconds); // 1 san = 1000 millisan.
            Console.WriteLine(ts1.TotalMilliseconds);

            */


            /*

            StringBuilder builder = new StringBuilder();


            string s = "Hello ", s1 = "World!  ", s2 = "How ", s3 = "are ", s4 = "you?";

            //string str = "";
            //str = str + s;

            var str = builder.Append(s)
                   .Append(s1)
                   .Append(s2)
                   .Append(s3)
                   .Append(s4).ToString();
            //builder.Append(s);
            //builder.Append(s1);


            Console.WriteLine(str);

            */


            /*

            string str = "-Hello--";
            string str1 = "Hello World";
            string str2 = "Resad";


            ///

            char[] chars = str2.ToCharArray();

            ///

            Console.WriteLine(str2.Substring(2)); // returns --> sad
            Console.WriteLine(str2.Substring(2, 2)); // returns --> sa

            ///

            string[] strarr = str1.Split(' ');

            Console.WriteLine(strarr[0] + "    " + strarr[1]);

            ///

            Console.WriteLine(str.Replace('l', 'e')); // -Heeeo--

            ///

            Console.WriteLine(str.Remove(0, 1)); // returns --> Hello--

            ///

            str.Insert(0, "Car"); // returns --> Car-Hello--

            ///

            str = str.ToLower(); // returns --> -hello--
            Console.WriteLine(str);

            ///

            Console.WriteLine(str.Contains("el")); // true

            ///

            str = str.Trim('-');

            Console.WriteLine(str);

            */


            /*
             
            MyClass my1 = new MyClass(12);
            MyClass my2 = new MyClass(20);

            Console.WriteLine(my1 + "   " + my2);

            MyClass.Swap(ref my1, ref my2);
            //var temp = my1;
            //my1 = my2;
            //my2 = temp;

            Console.WriteLine(my1 + "   " + my2);

            /*


            /*

            int a = 10;
            Foo(ref a);
            Console.WriteLine(a);

            */
        }
    }
}
