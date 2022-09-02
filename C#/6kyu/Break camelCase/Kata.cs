using System.Linq;

namespace Break_camelCase
{
    public class Kata
    {
        public static string BreakCamelCase(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;
            
            return string.Concat(str.Select(c => char.IsUpper(c) ? " " + c.ToString() : c.ToString()));
        }
    }
}