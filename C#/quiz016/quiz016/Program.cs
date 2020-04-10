using System;
using System.Collections.Generic;
using System.Linq;

namespace quiz016
{
    class Program
    {
        static void Main(string[] args)
        {
            var recipe = new Dictionary<string, int>
            {
                { "カレールウ", 70 },
                { "ごはん" , 300 },
                { "たまねぎ", 50 },
                { "にんじん" , 80 },
                { "じゃがいも", 50 }
            };

            var stock = new Dictionary<string, int>
            {
                { "カレールウ" , 180 },
                { "ごはん", 50000 },
                { "たまねぎ", 150 },
                { "鶏肉", 2 },
                { "にんじん" , 500},
                { "じゃがいも" , 900}
            };

            Console.WriteLine(CalculateHowManyDishes(recipe, stock));
        }

        public static int CalculateHowManyDishes(Dictionary<string, int> recipe, Dictionary<string, int> stock)
        {
            int x;
            var dishCount = new List<int>();

            foreach(string key1 in recipe.Keys)
            {
                foreach(string key2 in stock.Keys)
                {
                    if(key1 == key2)
                    {
                        x = recipe[key1] / stock[key2];
                        dishCount.Add(x);
                    }
                }
            }
            int min = dishCount.Min();
            return min;
        }
    }
}
