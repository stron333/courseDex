using System;
using System.Linq;

namespace TestIQueryable
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoPark autoPark = new AutoPark();
            for (int i = 0; i < 100; i++)
            {
                autoPark.AddRandom();
            }
            var selectedTeamsArray = autoPark.Automobiles.Where(t => t.GodVipuska >= 2000)
                                                         .OrderByDescending(t => t.GodVipuska)
                                                         .ToList();

            Console.WriteLine("Марка           Год    Тех. осмотр");
            foreach (AutoPark.Automobile s in selectedTeamsArray)
            {
                Console.WriteLine("{0}      {1}     {2}", MarkaProbeli(s.Marka), 
                                                          s.GodVipuska, 
                                                          s.TehOsmotr);
            }
            Console.ReadLine();
        }

        public static string MarkaProbeli (string marka)
        {
            while (marka.Length != 10)
            {
                marka += " ";
            }
            return marka;
        }
    }
}
