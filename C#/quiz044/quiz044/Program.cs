using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz044
{
    class Program
    {
        static void Main(string[] args)
        {
            var beers = new List<Beer>(){
                 new Beer("のどごし生", BeerType.BeerLike, "キリンビール"),
                 new Beer("アサヒスーパードライ", BeerType.Traditional, "アサヒビール"),
                 new Beer("金麦", BeerType.BeerLike, "サントリー"),
                 new Beer("クリアアサヒ", BeerType.BeerLike, "アサヒビール"),
                 new Beer("一番搾り", BeerType.Traditional, "キリンビール"),
                 new Beer("淡麗グリーンラベル", BeerType.LowMalt, "キリンビール"),
                 new Beer("麦とホップ", BeerType.BeerLike, "サッポロビール"),
                 new Beer("金麦　糖質75％オフ", BeerType.BeerLike, "サントリー"),
                 new Beer("淡麗　極上", BeerType.LowMalt, "キリンビール"),
                 new Beer("アサヒスタイルフリー", BeerType.LowMalt, "アサヒビール"),
            };

            var beerGroups = beers.GroupBy(x => x.Maker);

            foreach (var beerGroup in beerGroups)
            {
                Console.WriteLine(beerGroup.Key);
                foreach (var beer in beerGroup)
                {
                    Console.WriteLine($"商品名:{beer.Name}、メーカー:{beer.Maker}");
                }
            }
        }
    }

    class Beer
    {
        public string Name { get; set; }
        public BeerType BeerType { get; set; }
        public string Maker { get; set; }

        public Beer(string name, BeerType beerType, string maker)
        {
            this.Name = name;
            this.BeerType = beerType;
            this.Maker = maker;
        }
    }

    enum BeerType { Traditional, LowMalt, BeerLike }
}
