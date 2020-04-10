using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz030
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan a = new TimeSpan(17, 0, 0);
            TimeSpan b = new TimeSpan(19, 0, 0);
            TimeSpan c = new TimeSpan(18, 0, 0);
            TimeSpan d = new TimeSpan(20, 0, 0);
            Console.WriteLine(DurationChecker(a, b, c, d));
        }

        public static TimeSpan DurationChecker(TimeSpan t1, TimeSpan t2, TimeSpan t3, TimeSpan t4)
        {
            TimeSpan none = new TimeSpan(0, 0, 0);

            if ((t1 >= t3) && (t1 <= t4))
            {
                return t4 - t1;
            }
            else if ((t3 >= t1) && (t3 <= t2))
            {
                return t2 - t3;
            }
            else
            {
                return none;
            }
        }
    }



}
