using System;
using System.Collections.Generic;

namespace quiz017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OpenHours("月", "夜間"));
        }

        public static bool OpenHours(string day, string hour)
        {
            var days = new List<string> { "日", "月", "火", "水", "木", "金", "土" };


            //日曜日は休診日なのでfalse
            //火曜と木曜は終日開診なのでtrue
            if (day == days[0])
            {
                return false;
            }

            if (day == days[2] || day == days[4])
            {
                return true;
            }

            //月水金土の条件分岐
            //月　夜間休診
            if (day == days[1])
            {
                if (hour == "夜間")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            //水　夜間のみ開診
            if (day == days[3])
            {
                if(hour == "夜間")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            

            //金　午前休診
            if(day == days[5])
            {
                if(hour == "午前")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            //土　午後のみ開診
            if(day == days[6])
            {
                if (hour == "午後")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
    }
}
