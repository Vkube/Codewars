using System;

namespace Beginner_Series__1_School_Paperwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Paper.Paperwork(5, 5));
        }
        
        
    }

    public class Paper
    {
        public static int Paperwork(int n, int m)
        {
            if(n < 0 || m < 0 ) return 0;
      
            int result = n * m;
            return result;
        }
    }
}
