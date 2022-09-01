using System;
using System.Linq;

namespace Isograms
{
    public class Kata
    {
        public static bool IsIsogram(string str)
        {
            str = str.ToLower();
            string uniqCharacter = new String(str.Distinct().ToArray());
            return str == uniqCharacter;
        }
    }
}