using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz037
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 2, 48, 12, 5, 31, 19, 22, 32 };
            var whereNums = nums.Where(x => x % 2 == 0);
            Console.WriteLine(string.Join(" ", whereNums));

            var morethan25 = nums.Where(x => x > 25);
            Console.WriteLine(string.Join(" ", morethan25));
        }
    }
}
