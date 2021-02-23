using System;

namespace ConsoleApp9
{
    class Program
    {
        static void User_Write(ref Keep_User keep_, ref int tamp)
        {
            string a = "", b = "";

            Write_foo(ref a, ref b);
            User user = new User(a, b);
            if (tamp == 1) { keep_.Add_User(user); }
            if (a == "add" && b == "add" || tamp == 1) tamp++;

        }
        static void Write_foo(ref string a, ref string b)
        {

            Console.WriteLine("If you have not account write 'add' at nick and password ");
            Console.Write("Add nick name ---"); a = Console.ReadLine();
            Console.Write("Add password ---"); b = Console.ReadLine();
            Console.Clear();
        }
        static void ExecProgram(ref Keep_User keep_)
        {
            int tamp = 0;
            do
            {

                User_Write(ref keep_, ref tamp);

            } while (true);

        }
        static void Main()
        {
            Keep_User keep_ = new Keep_User();

            ExecProgram(ref keep_);
        }
    }

}




