using System;

namespace quiz010
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            for(int x = 1; x <= 300; x++)
            {
                for (int y = 1; y <= 300; y++)
                {
                    for(int z = 1; z <= 300; z++)
                    {
                        if(Math.Pow(x,n) + Math.Pow(y,n) == Math.Pow(z, n)){
                            Console.WriteLine("Miracle");
                        }
                        else
                        {
                            Console.WriteLine("Never happens");
                        }
                    }
                }
            }
            

        }
    }
}
