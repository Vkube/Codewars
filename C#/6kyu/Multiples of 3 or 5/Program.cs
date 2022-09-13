using System;
using System.Collections.Generic;
using System.Linq;

namespace Multiples_of_3_or_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Solution(10));
        }
    }


    public static class Kata
    {
        public static int Solution(int value)
        {
            var sumOfNumbers = new List<int>();

            if (value < 0)
                return 0;

            for (int i = 0; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sumOfNumbers.Add(i);
                }
            }

            return sumOfNumbers.Sum();
        }
    }
}