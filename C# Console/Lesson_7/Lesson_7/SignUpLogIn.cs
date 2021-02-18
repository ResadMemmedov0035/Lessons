using System.Collections.Generic;
using System;
using System.Linq;

namespace Lesson_7
{
    class SignUpLogIn
    {
        private static List<User> users = new List<User>();


        public static void SignUp(User user) => users.Add(user);

        public static void LogIn(string name, string password)
        {
            if (users.Any(x => x.Name == name && x.Password == password))
            {
                Console.WriteLine("Xos gelmisiniz " + name);
            }
            else Console.WriteLine("Daxil edilen sifre ve ya ad sehvdir!");
        }

        public static void LogIn(User user)
        {
            if (users.Any(x => x.Equals(user)))
            {
                Console.WriteLine("Xos gelmisiniz " + user.Name);
            }
            else Console.WriteLine("Daxil edilen sifre ve ya ad sehvdir!");
        }
    }
}
