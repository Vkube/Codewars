using System;

namespace Is_it_even
{
    class Number
    {
        static void Main(string[] args)
        {
            IsEven(12);
        }

        private static bool IsEven(double n) => n % 2 == 0;
    }
}
