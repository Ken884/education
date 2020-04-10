using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz033
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateParse(null));
        }

        public static string DateParse(DateTime? date)
        {
            if(date == null)
            {
                
                return DateTime.Today.ToString();
            }
            else
            {
                return date.ToString();
            }
        }
    }
}
