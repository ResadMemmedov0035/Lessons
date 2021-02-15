namespace Lesson_6
{
    class MyClass
    {
        public int Num { get; set; }

        public MyClass(int num) => Num = num;

        public static void Swap(ref MyClass left, ref MyClass right)
        {
            var temp = left;
            left = right;
            right = temp;
        }

        public override string ToString()
        {
            return Num.ToString();
        }
    }
}
