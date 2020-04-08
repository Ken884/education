using System;

namespace quiz006
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i + " アホ");
                }
                else if (i % 10 == 3)
                {
                    Console.WriteLine(i + " アホ");
                }
                else if (i >= 31 && i <= 39)
                {
                    Console.WriteLine(i + " アホ");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
