using System;
using System.Linq;

namespace How_good_are_you_really
{
    class Program
    {
        static void Main(string[] args)
        {
            var classAverage = new int[] { 100, 40, 34, 57, 29, 72, 57, 88 };
            var result = Kata.BetterThanAverage(classAverage, 75);
        }
    }
    
    public class Kata
    {
        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            return ClassPoints.Average() < YourPoints;
        }
    }
}
