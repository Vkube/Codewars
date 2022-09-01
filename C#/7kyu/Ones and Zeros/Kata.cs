using System;
using System.Linq;

namespace Ones_and_Zeros
{
    public class Kata
    {
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            string numbers = "";
            for (int i = 0; i < BinaryArray.Length; i++)
            {
                numbers += BinaryArray[i].ToString();
            }

            return Convert.ToInt32(numbers, 2);
        }
    }
}