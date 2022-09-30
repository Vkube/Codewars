using System;
using System.Collections.Generic;
using System.Linq;

namespace Moves_in_squared_strings__I_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Opstrings.VertMirror("hSgdHQ\nHnDMao\nClNNxX\niRvxxH\nbqTVvA\nwvSyRu");
        }
    }
    
    
    public class Opstrings
    {
        public  static void VertMirror(string strng)
        {
            List<string> arrayOfWords = strng.Split("\\").ToList();
            





            /* char[] charArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                reverse += charArray[i];
            }
            return reverse;
            */
        }









        }
        /*
        public  static string HorMirror(string strng)
        {
            
        }
        public static string Oper(... fct, string s)
        {
            // your code and complete ... before operator
        }
        */
    }

