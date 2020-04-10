using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz055
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Derivative(Test, 1));
        }

        static double Test(double hoge)
        {
            return Math.Sin(hoge) + Math.Cos(hoge);
        }

        static double Derivative(Func<double, double> f, double a)
        {
            double h = 0.000001;

            return (f(a + h) - f(a)) / ((a + h) - a);

        }
    }
}
