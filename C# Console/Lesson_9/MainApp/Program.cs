using System;
using AnimalsLibrary;

namespace MainApp
{
    class A
    {
        public int Public { get; set; }
        protected int Protected { get; set; }
        private int Private { get; set; }
        internal int Internal { get; set; }

        protected internal int ProtectedInternal { get; set; } // ozumkulere public, qiraqlara protected
        private protected int PrivateProtected { get; set; } // ozumkulere protected, qiraqlara private
    }

    class B : A
    {
        void Foo()
        {
            Protected = 10;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();

            

            ///

            Animal cat = new Cat();
            Animal dog = new Dog();

            cat.Sound();
            dog.Sound();

            Console.ReadKey();
        }
    }
}
