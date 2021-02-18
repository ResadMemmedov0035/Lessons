using System.Collections.Generic;
using System.Linq;

namespace SignUp_LogIn_JustForFun
{
    class LocalUserStorage
    {
        private List<User> users;

        public LocalUserStorage()
        {
            users = new List<User>();
        }

        public bool TryAdd(User user)
        {
            if (!users.Any(x => x.Name == user.Name))
            {
                users.Add(user);
                return true;
            }
            return false;
        }

        public bool CheckUser(string name, string password)
        {
            if (users.Any(x => x.Name == name && x.Password == password))
            {
                return true;
            }
            return false;
        }
    }
}