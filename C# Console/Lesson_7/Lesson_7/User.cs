namespace Lesson_7
{
    class User
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is User user)
            {
                return user.Name == Name && user.Password == Password;
            }
            return false;
        }
    }
}