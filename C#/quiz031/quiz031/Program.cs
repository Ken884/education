using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz031
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RideTime(25));
        }

        public static TimeSpan RideTime(double distance, bool express = true)
        {
            TimeSpan rideTime = new TimeSpan(0, 0, 0);
            if(distance < 100)
            {
                express = false;
            }
            if(express == false)
            {
                return rideTime = TimeSpan.FromHours(distance / 50.0);
            }else
            {
                return rideTime = TimeSpan.FromHours(distance / 150.0);
            }
        }
    }
}
