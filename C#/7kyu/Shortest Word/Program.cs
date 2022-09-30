using System;
using System.Collections.Generic;
using System.Linq;

namespace Shortest_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            var res1 = Kata.FindShort("bitcoin take over the world maybe who knows perhaps");
            var res2 = Kata.FindShort("turns out random test cases are easier than writing out basic ones");
            var res3 = Kata.FindShort("Let's travel abroad shall we");
        }
    }
    
    public class Kata
    {
        public static int FindShort(string s)
        {
            /*string[] words = s.Split(' ');
            List<int> lengthWords = new List<int>();

            foreach (var word in words)
            {
                lengthWords.Add(word.Length);
            }

            return lengthWords.Min();*/
            
            var words = s.Split(' ');
            var sorted=words.OrderBy(n => n.Length);
            var shortest = sorted.FirstOrDefault();
            return shortest.Length;
        }
    }
}
