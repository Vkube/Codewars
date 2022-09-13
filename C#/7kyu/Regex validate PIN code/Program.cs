using System;
using System.Linq;

namespace Regex_validate_PIN_code
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata.ValidatePin("1");
        }
    }


    public class Kata
    {
        public static bool ValidatePin(string pin)
        {
            var condition = !string.IsNullOrEmpty(pin)
                            && (pin.Length == 4 || pin.Length == 6)
                            && pin.All(char.IsDigit);
            return condition;
        }
    }
}