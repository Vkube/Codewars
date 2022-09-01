using System;
using System.Linq;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new[] { 1, 5.2, 4, 0, -1 };
            double[] array1 = new []{1.0d, 5.2d, 4.0d, 0.0d, -1.0d};
           Console.WriteLine( Kata.SumArray(array));
        }
    }

    public class Kata
    {
        public static double SumArray(double[] array)
        {
            double sum = 0;
            if (array == null || array.Length == 0) return sum;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
