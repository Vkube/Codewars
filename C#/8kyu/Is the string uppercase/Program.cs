using System;

namespace Is_the_string_uppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    
    public static class StringExtensions
    {
        public static bool IsUpperCase(this string text)
        {
            string upperString = text.ToUpper();
            return text == upperString;
        }
    }
}
