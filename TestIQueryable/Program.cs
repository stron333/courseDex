using System;
using System.Linq;

namespace TestIQueryable
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] teams = { "Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона" };
            var selectedTeamsArray = teams.Where(t => t.ToUpper().StartsWith("Б")).OrderBy(t =>
            t).ToArray(); // выражение будет вычислено прямо здесь и один раз
            foreach (string s in selectedTeamsArray)
            {
                Console.WriteLine(s);
            }
            foreach (string s in selectedTeamsArray)
            {
                Console.WriteLine(s);
            }
        }
    }
}
