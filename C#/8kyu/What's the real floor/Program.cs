using System;

namespace What_s_the_real_floor
{
    class Program
    {
        static void Main(string[] args)
        {
            var res1 = Kata.GetRealFloor(1);
            var res2 = Kata.GetRealFloor(5);
            var res3 = Kata.GetRealFloor(15);
        }
    }
    
    public static class Kata
    {
        public static int GetRealFloor(int n)
        {
            if (n < 0 || n==0)
            {
                return n;
            }
            else if (n > 13)
            {
                return n -= 2;
            }
            else if (n <= 13)
            {
                return n -= 1;
            }

            return n;
        }
    }
}
