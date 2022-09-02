using System;

namespace Twice_as_old
{
    class Program
    {
        static void Main(string[] args)
        {
           var result= TwiceAsOldSolution.TwiceAsOld(45, 30);
           Console.WriteLine(result);
        }
    }
    
    public class TwiceAsOldSolution
    {
        public static int TwiceAsOld(int dadYears, int sonYears)
        {
            int ageOfSun = sonYears * 2;
            int result = dadYears - ageOfSun;

            return Math.Abs(result);
        }
    }
}

