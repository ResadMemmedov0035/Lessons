using System;
using System.Text;

namespace SignUp_LogIn_JustForFun
{
    static class RandPassGenerator
    {
        public static string Generate(int len)
        {
            var rand = new Random();
            var password = new StringBuilder();

            var str = "QWERTYUIOPASDFGHJKLZXCVBNM" +
                      "qwertyuiopasdfghjklzxcvbnm" +
                      "1234567890";

            for (int i = 0; i < len; i++)
                password.Append(str[rand.Next(0, str.Length)]);

            return password.ToString();
        }
    }
}