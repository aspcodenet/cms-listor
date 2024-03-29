﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemosCms
{
    class Program
    {
        static double CalculateAverage(List<int> allaTal)
        {
            int summaAllaTal = 0;
            foreach (var i in allaTal)
            {
                summaAllaTal += i;
            }
            return Convert.ToDouble(summaAllaTal) /
                Convert.ToDouble(allaTal.Count);
        }

        static void Main(string[] args)
        {
            var listaMedTal = new List<int>();

            while(true)
            {
                Console.WriteLine("Mata in ett tal");
                var tal = Convert.ToInt32(Console.ReadLine());
                if (tal == 0) break;

                listaMedTal.Add(tal);

                var medel = CalculateAverage(listaMedTal);
                Console.WriteLine($"Medel på alla är {medel}");

                var treSistaList = new List<int>();

                for (int i = listaMedTal.Count - 1; i >= 0; i--)
                {
                    treSistaList.Add(listaMedTal[i]);
                    if (treSistaList.Count == 3) break;
                }
                var medel3Sista = CalculateAverage(treSistaList);
                Console.WriteLine($"Medel på 3 sista är {medel3Sista}");

            }
        }
    }
}
