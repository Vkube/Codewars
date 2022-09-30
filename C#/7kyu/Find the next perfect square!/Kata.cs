using System;
using System.Numerics;

namespace Find_the_next_perfect_square_
{
    public class Kata
    {
        public static long FindNextSquare(long num)
        {
            var o = (long)Math.Sqrt((double)num);
            return !BigInteger.Pow(o, 2).Equals(num) ? -1 : (long)BigInteger.Pow(o + 1, 2);
           
        }
    }
}