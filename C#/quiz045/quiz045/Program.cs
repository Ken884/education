using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz045
{
    class Program
    {
        static void Main(string[] args)
        {
            var characters = new List<Character>()
            {
                new Character(){Name = "山岸エレン", Gender = "女", Age = 38, Workname = "EREN the Sauthpaw"},
                new Character(){Name = "岸あかり", Gender = "女", Age = 34, Workname = "EREN the Sauthpaw"},
                new Character(){Name = "朝倉光一", Gender = "男", Age = 38, Workname = "EREN the Sauthpaw"},
                new Character(){Name = "日向翔陽", Gender = "男", Age = 22, Workname = "ハイキュー！！"},
                new Character(){Name = "宮侑", Gender = "男", Age = 23, Workname = "ハイキュー！！"},
                new Character(){Name = "西谷夕", Gender = "男", Age = 23, Workname = "ハイキュー！！"},
                new Character(){Name = "Mike Ross", Gender = "男", Age = 39, Workname = "Suits"},
                new Character(){Name = "Harvey Specter", Gender = "男", Age = 48, Workname = "Suits"},
                new Character(){Name = "Rachel Zane", Gender = "女", Age = 39, Workname = "Suits"}
            };

            var characterGroup1 = characters.GroupBy(x => x.Workname);
            

            foreach(var characterGroup in characterGroup1)
            {
                Console.Write($"{characterGroup.Key}:");
                Console.Write(string.Join(",", characterGroup.Select(x => x.Name)));

                
                Console.WriteLine();
            }

            var characterGroup2 = characters.GroupBy(x => x.Gender);


            foreach (var characterGroup in characterGroup2)
            {
                Console.Write($"{characterGroup.Key}:");
                Console.Write(string.Join(",", characterGroup.Select(x => x.Name + "(" + x.Age+ ")")));
                
                Console.WriteLine();
            }
        }
    }

    class Character
    {
        public string Name { get; set; }
        public string Gender { get; set; }

        public int? Age {get; set; }
        public string Workname { get; set; }
    }
}
