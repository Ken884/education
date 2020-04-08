using System;
using System.Collections.Generic;
using System.Linq;

namespace quiz018
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CollatzCount(21));
 
        }

        public static int CollatzCount(int n)
        {
            var array = new List<int>();
            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;

                }
                else
                {
                    n = n * 3 + 1;

                }
                array.Add(n);
            }
            return array.Count();

        }
    }
}
