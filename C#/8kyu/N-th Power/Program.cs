using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Threading;

namespace N_th_Power
{
    class Program
    {
        static void Main(string[] args)
        {
           Kata.fizzBuzz(15);

          Console.WriteLine("__--------");
           Console.WriteLine(Solution.GetUniqueWordsCount("a aa bb aa"));
        }
    }

    public class Kata
    {
        public static double Index(int[] array, int n)
        {
            int indexOfArray = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i == n)
                {
                    indexOfArray += i;
                    return Math.Pow(array[indexOfArray], n);
                }
            }

            return -1;
        }

        public static void fizzBuzz(int n)
        {

            for (var i = 1; i <= n; i++)
            {

                bool multipleOfThree = i % 3 == 0;
                bool multipleOfFive = i % 5 == 0;


                var text = i switch
                {
                    _ when multipleOfThree && multipleOfFive => "FizzBuzz",
                    _ when multipleOfThree => "Fizz",
                    _ when multipleOfFive => "Buzz",
                    _ => $"{i}"
                };
                Console.WriteLine(text);
            }

        }
    }

    public class Solution {
            public static int GetUniqueWordsCount(string input)
            {
                var passed = new HashSet<string>();

                var offset = 0;
                for (var index = 1; index < input.Length; index++)
                {
                    if (input[index] == ' ')
                    {
                        passed.Add(input.Substring(offset, index - offset - 1));
                        offset = index;
                    }
                }

                return passed.Count;
            }
        }
        
    

   
   
}