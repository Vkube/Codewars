using System;

namespace Ones_and_Zeros
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 1, 1, 1 };

            var result = Kata.binaryArrayToNumber(array);
            Console.WriteLine(result);
        }
    }
}
