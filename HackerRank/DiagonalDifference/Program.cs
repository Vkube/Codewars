using System;
using System.Collections.Generic;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new List<List<int>>()
            {
                new List<int>() { 3 }, new List<int>() { 11, 2, 4 }, new List<int>() { 4, 5, 6 },
                new List<int>() { 10, 8, -12 }
            };
            Console.WriteLine(diagonalDifference(array));
        }


        public static int diagonalDifference(List<List<int>> arr)
        {
            var firstList = arr[0];
            var secondList = arr[1];
            var thirdList = arr[2];
            var fourList = arr[3];

            int firstDiagonalSum = 0;
            int secondDiagonalSum = 0;
            if (firstList.Count < 3)
            {
                firstDiagonalSum += secondList[0] + thirdList[1] + fourList[2];
                secondDiagonalSum += secondList[2] + thirdList[1] + fourList[0];
            }

            return Math.Abs(firstDiagonalSum - secondDiagonalSum);
        }
    }
}