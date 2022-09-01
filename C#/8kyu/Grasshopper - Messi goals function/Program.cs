using System;

namespace Grasshopper___Messi_goals_function
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.GetGoals(1, 4, 5));
        }
    }

    public class Kata
    {
        public static int GetGoals(int laLigaGoals, int copaDelReyGoals, int championsLeagueGoals)
        {
            return laLigaGoals + copaDelReyGoals + championsLeagueGoals;
        }
    }
}
