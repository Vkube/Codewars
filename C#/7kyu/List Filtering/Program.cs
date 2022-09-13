using System;
using System.Collections.Generic;

namespace List_Filtering
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<object>(){1,"a","b",0,15};
           var result= ListFilterer.GetIntegersFromList(list);
           foreach (var item in result)
           {
               Console.WriteLine(item);
           }
        }
    }
}
