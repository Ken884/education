using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz034
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime hoge = new DateTime(2011, 3, 2);
            Console.WriteLine(DateParse(null));
            
        }

        public static string DateParse(DateTime? date)
        {
            //DateTime?は厳密にはnullではないので左辺がそのまま通る
            //return date.ToString() ?? DateTime.Today.ToString();
            
            //こっちは右辺の結果を反映する
             string result;
             return result = (date.ToString() == null) ? date.ToString() : DateTime.Today.ToString();
        }
    }
}
