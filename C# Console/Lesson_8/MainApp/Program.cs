using System;

class MyClass
{
    public void Hi(string name) => Console.WriteLine($"Hi, {name}");
}


abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    //public Animal(string name)
    //{
    //    Name = name;
    //}

    public void Sound() => Console.WriteLine("ANIMAL SOUND");

    //public virtual void VSound() => Console.WriteLine("VIRTUAL ANIMAL SOUND");

    public abstract void VSound();

    public override string ToString()
    {
        return $"{Name} {Age}";
    }
}

sealed class Cat : Animal
{
    //public Cat(string name) : base(name) { }

    public int SpecCat { get; set; }

    public new void Sound() => Console.WriteLine("MIAV"); // method hiding/shadowing

    public override void VSound() => Console.WriteLine("VIRTUAL MIAV"); // method overriding

    public override string ToString()
    {
        return base.ToString() + " [type:cat]";
    }
}


abstract class Person
{
    public virtual string Profession { get; } = "N/A";
    public string Name { get; set; }
    public int Age { get; set; }
}

class Programmer : Person
{
    public override string Profession => "Programmer";
}

class Police : Person
{
    public override string Profession => "Police";
}


interface IInterface
{
    public int Num { get; set; }
    public void Hi();
}

class MyClass2 : Animal, IInterface, IDisposable
{
    public int Num { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public void Hi()
    {
        throw new NotImplementedException();
    }

    public override void VSound()
    {
        throw new NotImplementedException();
    }
}

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Animal animal = new Animal(); // error because of abstract class

            IInterface obj = new MyClass2();
            obj.Hi();

            Cat cat = new Cat();
            Animal cat1 = new Cat();

            cat.Sound();
            cat1.Sound();

            cat.VSound();
            cat1.VSound();


            /*

            int a = null; // error

            int? na = null; // same as the below
            //Nullable<int> na = null;
        
            */


            /*

            // ?? --> if(null)
            // ? --> if(!null)
            //
            // kiminiden dusunule biler


            MyClass my = null;

            my?.Hi("Resad"); // same as the below

            //if (my != null)
            //    my.Hi("Resad");


            ///

            string str = null;
            string str1 = "";

            str = str ?? "Anotherthing";
            str ??= "Anotherthing"; // same as the above

            //

            str1 = str ?? "Something"; // same as the below

            if (str == null) str1 = "Something";
            else str1 = str;

            Console.WriteLine(str1);

            */
        }
    }
}
