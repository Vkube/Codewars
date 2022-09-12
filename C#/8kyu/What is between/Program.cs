using System;
using System.Collections.Generic;

namespace What_is_between
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Kata.Between(-2, 2);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
    


    public class Kata {
        public static int[] Between(int a, int b)
        {
            List<int> array = new List<int>();

            for (int i = a; i <= b; i++)
            {
                array.Add(i);
            }

            return array.ToArray();
        }
    }
}
