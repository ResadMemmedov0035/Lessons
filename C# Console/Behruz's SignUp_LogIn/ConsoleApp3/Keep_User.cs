using System.Collections.Generic;
using System;
namespace ConsoleApp9
{
    class Keep_User
    {
        List<User> list = new List<User>();

        public void Add_User(User user)
        {
            list.Add(user);
        }

        public bool Add_Control(User user)
        {
            foreach (var item in list)
            {
                if (user.NickName == item.NickName) return true;
            }
            return false;
        }

        public void Enter_User(User user)
        {
            if (CheckUser(user)) Console.WriteLine("Hello");
            else Console.WriteLine("Wrong");

            Console.ReadKey();
            Console.Clear();
        }

        private bool CheckUser(User user)
        {
            foreach (var item in list)
            {
                if (user.NickName == item.NickName && user.Password == item.Password)
                {
                    return true;
                }
            }
            return false;
        }

    }

}










