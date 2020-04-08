using System;
using System.Collections.Generic;

namespace quiz015
{
    class Program
    {
        static void Main(string[] args)
        {
            var landArea = new List<string> {"Russia", "China", "USA", "Canada", "Brazil",};
            foreach(string country in landArea)
            {
                Console.WriteLine(country);
            }

            var populationMap = new Dictionary<string, int>();
            populationMap.Add("China", 1439323776);
            populationMap.Add("India", 1380004385);
            populationMap.Add("USA", 331002651);
            populationMap.Add("Indonesia", 273523615);
            populationMap.Add("Pakistan", 220892340);

            foreach(string countries in populationMap.Keys)
            {
                Console.WriteLine(countries);
            }

            foreach(int population in populationMap.Values)
            {
                Console.WriteLine(population);
            }

            foreach (KeyValuePair < string, int> contents in populationMap)
            {
                Console.WriteLine(contents);
            }

        }
    }
}
