﻿using System;
using System.Collections.Generic;

namespace TestIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<SomeFigure> someFigures = new List<SomeFigure>();
            for (int i = 0; i<10; i++)
            {
                someFigures.Add(new SomeFigure(rnd.Next(1, 10), rnd.Next(1, 10)));
            }

            foreach (var someFigure in someFigures)
            {
                Console.WriteLine("a = {0} b = {1} area = {2}",someFigure.A, someFigure.B, someFigure.Area);
            }
            Console.ReadLine();
        }
    }
}