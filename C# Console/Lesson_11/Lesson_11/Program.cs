using System;
using System.Collections;
using System.Collections.Generic;

namespace Lesson_11
{
    class MyList<T> : IEnumerable<T>, ICloneable
    {
        class MyEnumerator : IEnumerator
        {
            private T[] e_array;
            private int index = -1;

            public MyEnumerator(T[] arr)
            {
                e_array = arr;
            }

            public object Current => e_array[index];

            public bool MoveNext()
            {
                if (e_array.Length - 1 > index)
                {
                    index++;
                    return true;
                }
                return false;
            }

            public void Reset() => index = -1;
        }

        private T[] array;

        public int Count => array.Length;

        public T this[int index]
        {
            get => array[index];
            set => array[index] = value;
        }

        public MyList() // for new() generic costraint
        {
            array = new T[0];
        }

        public MyList(params T[] arr)
        {
            array = arr;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();

            //foreach (var item in array)
            //{
            //    yield return item;
            //}

            // return new MyEnumerator(array); // olmamasi gereken //
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in array)
            {
                yield return item;
            }
        }

        public object Clone()
        {
            return new MyList<T>(array);
        }
    }

    class Program
    {
        static IEnumerable Items()
        {
            yield return 1;
            yield return 3;
            yield return 4;
            yield return 7;
        }

        static void GenFoo<T>(T item) where T : new()/*parametrsiz ctor teleb edir*/ // ICloneable, IEnumerable // struct // class
        { 

        }

        static void Main(string[] args)
        {
            GenFoo(new MyList<int>());



            /*

            foreach (var item in Items())
            {
                Console.WriteLine(item);
            }


            var my = new MyList<int>(1, 2, 3, 4, 5);

            //for (int i = 0; i < my.Count; i++)
            //{
            //    Console.WriteLine(my[i]);
            //}

            foreach (var item in my)
            {
                Console.WriteLine(item);
            }


            //IEnumerator iterator = my.GetEnumerator();
            //while (iterator.MoveNext())
            //{
            //    Console.WriteLine(iterator.Current);
            //}
            //iterator.Reset();

            */
        }
    }
}
