using System;
using System.Collections.Generic;

namespace quiz014
{
    class Program
    {
        static void Main(string[] args)
        {
           var robertMember = new List<string> ();
            robertMember.Add("山本");
            robertMember.Add("秋山");
            robertMember.Add("馬場");
           var ostrichMember = new List<string> { "上島", "寺門", "上島" };
           var neptuneMember = new List<string> { "名倉", "原田", "堀内" };
           var circusMember = new List<string> { "安田", "黒川", "HIRO" };

            var torio = new Dictionary<string, List<string>> { };
            torio.Add("ロバート", robertMember);
            torio.Add("ダチョウ俱楽部", ostrichMember);
            torio.Add("ネプチューン", neptuneMember);
            torio.Add("安田大サーカス", circusMember);

            foreach(List<string> hoge in torio.Values)
            {
                foreach(string hige in hoge)
                {
                    Console.WriteLine(hige);
                }
            }

            
        }
    }
}
