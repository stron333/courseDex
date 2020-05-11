using System;
using System.Collections.Generic;

namespace TestList
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(
                "Иванов Иван Иванович",
                new DateTime(1990, 6, 15),
                "Тирасполь",
                111111);

            Person person2 = new Person(
                "Иванов Иван Иванович",
                new DateTime(1990, 6, 15),
                "Тирасполь",
                222222);

            Person person3 = new Person(
                "Сидоров Сидр Сидорович",
                new DateTime(1985, 11, 1),
                "Бендеры",
                333333);
            
            Dictionary<string,Person> spravMestoRaboti = new Dictionary<string, Person>
            {
                {"Шериф", person1},
                {"Квинт", person2},
                {"Тираэт", person3}
            };

            foreach (var pair in spravMestoRaboti)
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value.ToString());
        }
    }
}
