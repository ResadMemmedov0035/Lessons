using System;

namespace Lesson_10
{
    interface IClass
    {
        void Method();
    }

    class A : IClass
    {
        public void Method()
        {
            Console.WriteLine("I am A");
        }
    }

    class B : IClass
    {
        public void Method()
        {
            Console.WriteLine("I am B");
        }
    }


    class Person
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Person person)
            {
                //var person = obj as Person;
                return this.Name == person.Name && this.Age == person.Age;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Surname.GetHashCode() - Name.GetHashCode() + Age;
        }

        public override string ToString()
        {
            return $"{Name}, {Age}";
        }
    }


    interface IPolice
    {
        void Put();
    }

    interface IProgrammer
    {
        void Put();
    }

    class Somebody : IProgrammer, IPolice
    {
        void IProgrammer.Put()
        {
            Console.WriteLine("Put the USB to computer");
        }

        void IPolice.Put()
        {
            Console.WriteLine("Put the prisoner to jail");
        }
    }

    class Program
    {
        static void Foo(object obj)
        {
            int? a = obj as int?; // unboxing

            Console.WriteLine(obj);
        }

        static void Foo1(int i)
        {
            Console.WriteLine(i);
        }

        static void Foo2<T>(T t)
        {
            Console.WriteLine(t);
        }

        static void Main(string[] args)
        {
            IPolice somebody = new Somebody();
            somebody.Put();

            IProgrammer somebody1 = new Somebody();
            somebody1.Put();

            /*

            Person person = new Person { Name = "Resad", Surname = "Memmedov", Age = 17 };
            Person person1 = new Person { Name = "Memmedov", Surname = "Resad", Age = 17 };
            string str = "Resad";

            Console.WriteLine(person.GetHashCode());
            Console.WriteLine(person1.GetHashCode());
            Console.WriteLine(str.GetHashCode());

            /*

            int a = 10, b = 10;
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            string str = "Resad";
            string str1 = "Resad";

            Console.WriteLine(str.GetHashCode());
            Console.WriteLine(str1.GetHashCode());

            if (str == str1) Console.WriteLine("Beraberdirler");
            else Console.WriteLine("Beraber deyildirler");


            /*

            Person person = new Person { Name = "Resad", Age = 17 };
            Person person1 = new Person { Name = "Resad", Age = 17 };

            if(person.Equals(person1))
                Console.WriteLine("beraberdirler");
            else
                Console.WriteLine("beraber deyildirler");

            ///

            Console.WriteLine(person); // person.ToString()


            /*

            var begin = DateTime.Now;
            Foo(10); //  boxing
            Console.WriteLine("object: " + (DateTime.Now - begin));

            begin = DateTime.Now;
            Foo1(10);
            Console.WriteLine("int: " + (DateTime.Now - begin));

            begin = DateTime.Now;
            Foo2(10); // generic
            Console.WriteLine("generic: " + (DateTime.Now - begin));



            // object obj = new A(); // not boxing or something like that


            /*

            IClass ac = new A();

            IClass bc = ac as B; // ac is B ? (B)ac : null;
            bc?.Method();

            /*

            // A a = new A(); // is A --> true
            // IClass a = new A(); // is A --> true
            IClass b = new B(); // is A --> false

            bool bb = b is A;

            Console.WriteLine(bb);

            */
        }
    }
}
