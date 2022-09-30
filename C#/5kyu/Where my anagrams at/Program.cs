using System;
using System.Collections.Generic;
using System.Linq;

namespace Where_my_anagrams_at
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOfWords = new List<string> { "a", "b", "c", "d" };
            Kata.Anagrams("a", arrayOfWords);
        }
    }
    
    public static class Kata
    {
        public static List<string> Anagrams(string word, List<string> words)
        {
            var listOfWords = new List<string>();
            var charOfArrays = words.Select(c => c.ToCharArray());
            
            //
            return listOfWords;
        }
    }
    
    
    
    
}
