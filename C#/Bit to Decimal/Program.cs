using System;

namespace Solution
{
    public static class Program
    {
        public static void Main()
        {
            var test = Program.binToDec("11");
        }


        public static int binToDec(string s)
        {
            return Convert.ToInt32(s, 2);
        }
    }
}