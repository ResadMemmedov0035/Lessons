using System;
using System.Collections.Generic;
//using System.Linq;

namespace Lesson_4
{
    //class MyClass
    //{
    //    int A;
    //    int B;

    //    public MyClass(int a, int b) => (A, B) = (a, b);
    //}

    class Program
    {
        static string RandPassGenerate(int len)
        {
            Random rand = new Random();

            string characters = "ABCDEFGJIJKLMNOPQRSTUVWXYZ" +
                                "abcdefghijklmnopqrstuvwxyz" +
                                "1234567890";

            string password = "";

            for (int i = 0; i < len; i++)
            {
                password += characters[rand.Next(0, characters.Length)];
            }

            return password;
        }

        static void RandomPass(int len)
        {
            string alphabet = "";
            for (int i = 65; i < 91; i++)
            {
                alphabet += Convert.ToString(((char)i));
                alphabet += Convert.ToString(((char)i)).ToLower();
            }
            for (int i = 0; i < 10; i++) alphabet += i.ToString();
            for (int i = 33; i < 48; i++) alphabet += Convert.ToString(((char)i));
            Random rand = new Random();
            string password = "";
            for (int i = 0; i < len; i++)
            {
                password += alphabet[rand.Next(0, alphabet.Length)];
            }
            Console.WriteLine(password);
        }


        static void ArrRandomizer<T>(T[] arr)
        {
            Random rand = new Random();

            int len = arr.Length;
            int r;

            while (len > 1)
            {
                r = rand.Next(0, len); // 5 4 3 1 2
                (arr[r], arr[len - 1]) = (arr[len - 1], arr[r]);
                len--;
            }

        }

        static void Randomizer<T>(T[] arr)
        {
            int len = arr.Length;
            List<int> usedIndexes = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < len; i++, len--)
            {
                int randomIndex1 = 0, randomIndex2 = 0;
                bool restart = true;
                while (restart)
                {
                    bool check = false;
                    randomIndex1 = rand.Next(0, len);
                    foreach (var item in usedIndexes)
                    {
                        if (item == randomIndex1) check = true;
                    }
                    if (!check) restart = false;
                }
                restart = true;
                while (restart)
                {
                    bool check = false;
                    randomIndex2 = rand.Next(0, len);
                    foreach (var item in usedIndexes)
                    {
                        if (item == randomIndex2) check = true;
                    }
                    if (!check) restart = false;
                }
                T temp = arr[randomIndex1];
                arr[randomIndex1] = arr[randomIndex2];
                arr[randomIndex2] = temp;
            }
        }

        class MyClass
        {
            public int Age { get; set; }
        }

        class MyList<T>
        {
            private T[] arr = new T[0];

            public int Count => arr.Length;

            public T this[int index]
            {
                get => arr[index];
                set => arr[index] = value;
            }

            public void Add(T item)
            {
                var temp = new T[arr.Length + 1];

                for (int i = 0; i < arr.Length; i++)
                {
                    temp[i] = arr[i];
                }
                temp[temp.Length - 1] = item;

                arr = temp;
            }

            public void RemoveAt(int index) // homework
            { 

            }
        }

        static void Main(string[] args)
        {

            List<int> list = new List<int>()
            {
                1,2,3,4,5,6,7,8,9
            };

            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);

            list.TrimExcess();

            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);

            list.Add(10);

            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);

            /// ///


            //MyList<int> myList = new MyList<int>();

            //myList.Add(10);
            //myList.Add(11);
            //myList.Add(12);

            //for (int i = 0; i < myList.Count; i++)
            //{
            //    Console.WriteLine(myList[i] + " ");
            //}


            /// /// 


            //var mies = new List<MyClass>();

            //mies.Add(new MyClass() { Age = 17 });

            //MyClass firstAge17User = mies.Find(x => x.Age == 17);

            //mies.Remove(firstAge17User);



            //List<int> list = new List<int>();

            //list.Add(12);
            //list.Add(10);
            //list.Add(11); 
            //list.Add(12);
            //list.Add(12);

            //foreach (var item in list)
            //    Console.WriteLine(item);
            //Console.WriteLine();

            //list.Remove(12);

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}



            /// /// /// /// 



            //int a, b;

            //(a, b) = (1, 2);

            //Console.WriteLine(a + " " + b);

            //(a, b) = (b, a);

            //Console.WriteLine(a + " " + b);


            /// /// /// /// 


            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //ArrRandomizer(arr);

            //foreach (var item in arr)
            //    Console.WriteLine(item);
            //Console.WriteLine();

            //ArrRandomizer(arr);

            //foreach (var item in arr)
            //    Console.WriteLine(item);

            /// /// 

            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Randomizer(arr);

            //foreach (var item in arr)
            //    Console.WriteLine(item);

            //Randomizer(arr);

            //foreach (var item in arr)
            //    Console.WriteLine(item);

            //for (int i = 0; i < 5; i++)
            //    Console.WriteLine(RandPassGenerate(8));
        }
    }
}
