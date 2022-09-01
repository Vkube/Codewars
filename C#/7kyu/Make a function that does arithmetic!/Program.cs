using System;

namespace Make_a_function_that_does_arithmetic_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Arithmetic(1, 2, "add"));
        }
    }
    
    public class Kata 
    {
        public static double Arithmetic(double a, double b, string op)
        {
            double result=0; 
            switch (op)
            {
                case "add":
                    result = a + b;
                    return result;
                    
                case "subtract":
                    result = a - b;
                    return result;
                  
                case "multiply":
                    result = a * b;
                    return result;
                  
                case "divide":
                    result = a / b;
                    return result;
                 
                default:
                    return result;
            }
            
        }
    }
}
