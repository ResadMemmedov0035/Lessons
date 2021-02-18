using System;
using System.Threading;

namespace SignUp_LogIn_JustForFun
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter '1' for Sign Up");
                Console.WriteLine("Enter '2' for Log In");
                Console.WriteLine("Enter '3' for Exit");

                Console.Write("-->");
                byte.TryParse(Console.ReadLine(), out byte dec);

                Console.Clear();


                if (dec == 1) SuLi_Executer.ExecSignUp();

                if (dec == 2) SuLi_Executer.ExecLogIn();

                if (dec == 3) break;

                Thread.Sleep(1500);
                Console.Clear();
            }
        }
    }
}
