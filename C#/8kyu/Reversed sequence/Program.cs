using System;
using System.Linq;

namespace Reversed_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var result=Kata.ReverseSeq(5);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
    


    public static class Kata
    {
        public static int[] ReverseSeq(int n)
        {
            var result = Enumerable.Range(1,n).Reverse().ToArray();
            return result;
        }
    }
}
