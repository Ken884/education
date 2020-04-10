using System;
using System.Collections.Generic;
namespace quiz011_012
{
    class Program
    {
        static void Main(string[] args)
        {
            var favoriteFoods = new List<string> { "pasta", "testa di maiale", "grillia" };
            for(int i = 0; i < favoriteFoods.Count; i++)
            {
                Console.WriteLine(favoriteFoods[i]);
            }
        }
    }
}
