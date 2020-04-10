using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz047
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Dictionary<int, string> { };
            Console.WriteLine(test.GetValueOrDefault(1, "none"));
            
        }
    }

    static class DictionaryExtensions
    {
        public static TValue GetValueOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue = default(TValue))
        {
            if (dictionary.ContainsKey(key))
            {
                return dictionary[key];
            }
            else
            {
                return defaultValue;
            }

        }

     
    }
}
