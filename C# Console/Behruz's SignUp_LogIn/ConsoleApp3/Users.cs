using System;

namespace ConsoleApp9
{
    static class Users
    {
    
        public static void Registretion(ref Keep_User keep_ , string a, string b)
        {
            Console.WriteLine("Create account");

            User user;
            do
            {
                if (a != "add" && b != "add") Console.WriteLine("Replay please");
                Write_foo(out string name, out string pass);
                if (pass == "random") Randomizer(out pass);
                Console.Clear();
                user = new User(name, pass);
            }
            while (keep_.Add_Control(user));

            keep_.Add_User(user);

        }

        static void Randomizer(out string b)
        {
                Random random = new Random();
                string c = "QWERTYUIOPASDFGHJKLZXCVBNM"+"qwertyuiopasdfghjklzxcvbnm"+"1234567890";
                {
                    b = "";
                    for (int i = 0; i < 8; i++)
                    {
                        b = b + c[random.Next(0, c.Length)];

                    }
                    Console.WriteLine(b);

                    Console.ReadKey();
                }

        }

        public static void Enter(ref Keep_User keep_)
        {
            Write_foo(out string a, out string b);
            User user = new User(a, b);
            if (a == "add" && b == "add") Registretion(ref keep_, a, b);
            else keep_.Enter_User(user);
        }

        public  static void Write_foo(out string a, out string b)
        {

            Console.Write("Add nick name ---"); a = Console.ReadLine();
            Console.Write("Add password ---");  b = Console.ReadLine();
            Console.Clear();
        }
        public static void  Start_program(ref Keep_User keep_)
        {
           
            do
            {

                Console.WriteLine("If you have not account write 'add' at nick and password ");
                
                Enter(ref keep_);
               

            } while (true);

        }
    }

}










