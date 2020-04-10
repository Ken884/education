using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace quiz040
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new List<string>(){"animation",
                                           "civilization",
                                           "occupation",
                                           "normalization",
                                           "extention",
                                           "activation",
                                           "calculation",
                                           "linearization"
                                           };
            
            
            var test = words.Where(s => s.Length >= 10).Select(s => s.Substring(0,1) + (s.Length - 2).ToString() + s.Substring((s.Length - 1), 1));
            Console.WriteLine(string.Join(" ", test));

        }
    }
}
