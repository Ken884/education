using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz029
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan left = new TimeSpan(8, 50, 0);
            TimeSpan back = new TimeSpan(20, 0, 0);
            TimeSpan timeSpan = back - left;

            Console.WriteLine(timeSpan);
        }
    }
}