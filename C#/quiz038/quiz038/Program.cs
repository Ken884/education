using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz038
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 2, 48, 12, 5, 31, 19, 22, 32 };
            var selectNums = nums.Select(x => x - 3);
            Console.WriteLine(string.Join(" ", selectNums));

            var doubleNums = nums.Select(x => x * 2);
            Console.WriteLine(string.Join(" ", doubleNums));
        }
    }
}
