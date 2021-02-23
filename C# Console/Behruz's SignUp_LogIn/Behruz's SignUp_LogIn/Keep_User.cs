using System.Collections.Generic;

namespace ConsoleApp9
{
    class Keep_User
    {
        List<User> list = new List<User>();

        public void Add_User(User user)
        {
            list.Add(user);
        }

        public List<User> Return_User(User user)
        {

            return list;
        }

    }

}




