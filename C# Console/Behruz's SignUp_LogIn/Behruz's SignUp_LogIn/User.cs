namespace ConsoleApp9
{
    class User
    {
        public string NickName { get; set; }
        public string Password { get; set; }
        public User(string nick_name, string password)
        {

            this.NickName = nick_name;
            this.Password = password;
        }

        public override string ToString()
        {
            return $"{NickName }{Password }";
        }
    }

}




