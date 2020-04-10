using System;

namespace quiz007
{
    class Program
    {
        static void Main(string[] args)
        {
            Program test = new Program();
            Console.WriteLine(test.temperatureName(12, 25.0));

        }
        
        public string temperatureName(double min, double max)
        {
            string winter = null;
            string summer = null;

            if(max <= 0)
            {
                winter = "真冬日";
            }else if(min <= 0)
            {
                winter = "冬日";
            }

            if(max >= 35)
            {
                summer = "猛暑日";
            }else if(max >= 30)
            {
                summer = "真夏日";
            }else if (max >= 25)
            {
                summer = "夏日";
            }

            return winter + summer;

        }
    }
}