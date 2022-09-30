using System;

namespace Remove_anchor_from_URL
{
    class Program
    {
        static void Main(string[] args)
        {
            var result=Kata.RemoveUrlAnchor("www.codewars.com/katas/?page=1#about");
        }
    }
    
    
    

public static class Kata
{
  public static string RemoveUrlAnchor(string url)
  {
      if (url.Contains('#'))
      {
          int indexOfSymbol= url.IndexOf('#');
              string newUrl = url.Substring(0,indexOfSymbol);
              return newUrl;
      }

      return url;
  }
}
}
