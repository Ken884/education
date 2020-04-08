using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz039
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 2, 48, 12, 5, 31, 19, 22, 32 };
            Console.WriteLine(nums.All(x => x < 100));
            Console.WriteLine(nums.Any(x => x >= 30));
            Console.WriteLine(nums.Contains(19));
        }
    }
}
