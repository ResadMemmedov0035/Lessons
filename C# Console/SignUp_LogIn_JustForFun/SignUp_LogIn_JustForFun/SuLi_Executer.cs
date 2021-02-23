using System;

namespace SignUp_LogIn_JustForFun
{
    static class SuLi_Executer
    {
        private static LocalUserStorage storage = new LocalUserStorage();

        public static void ExecSignUp()
        {
            string name, password;
            bool canAdd = true;
            do
            {
                if (!canAdd) Console.WriteLine("Bu adda istifadeci var. Yeniden cehd edin.");

                Console.Write("Yeni istifadeci adini daxil edin:");
                name = Console.ReadLine();

                Console.Write("Sifreni daxil edin(sifre onermesi ucun 'randpass' daxil edin):");
                password = Console.ReadLine();

                if (password == "randpass")
                {
                A:
                    var tempass = RandPassGenerator.Generate(8);
                    Console.WriteLine("Onerilen sifre --> " + tempass);
                    Console.Write("Qalsin '1' , Yeniden yarat '2' :");
                B: var d = Console.ReadLine();

                    if (d == "1") password = tempass;
                    else if (d == "2")
                    {
                        Console.Clear();
                        goto A;
                    }
                    else goto B;
                }

                canAdd = storage.TryAdd(new User() { Name = name, Password = password });

            } while (!canAdd);

            Console.WriteLine("Istifadeci daxil edildi!");
        }

        public static void ExecLogIn()
        {
            string name, password;
            bool exist = true;
            do
            {
                if (!exist) Console.WriteLine("Daxil edilen sifre ve ya istifadeci adi yanlisdir. Yeniden cehd edin.");

                Console.Write("Istifadeci adini daxil edin: ");
                name = Console.ReadLine();

                Console.Write("Sifreni daxil edin: ");
                password = Console.ReadLine();

                exist = storage.CheckUser(name, password);

            } while (!exist);

            Console.WriteLine("Xos gorduk " + name);
        }
    }
}