using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz041
{
    class General
    {
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public int DeadYear { get; set; }

        public General(string name, int birthYear, int deadYear)
        {
            this.Name = name;
            this.BirthYear = birthYear;
            this.DeadYear = deadYear;
        }
        public static void Main(String[] args)
        {
            var g1 = new General("伊達政宗", 1567, 1636);
            var g2 = new General("織田信長", 1534, 1582);
            var g3 = new General("真田幸村", 1567, 1615);
            var g4 = new General("真田昌幸", 1547, 1611);
            var g5 = new General("上杉謙信", 1530, 1578);
            var g6 = new General("毛利元就", 1497, 1571);
            var g7 = new General("立花宗茂", 1567, 1643);
            var g8 = new General("島津義弘", 1535, 1619);

            var generals = new List<General> { g1, g2, g3, g4, g5, g6, g7, g8 };

            var orderGenrals = generals.OrderBy(x => x.BirthYear);

            foreach(var general in orderGenrals)
            {
                Console.WriteLine($"{general.Name}, 生年:{general.BirthYear}年, 没年:{general.DeadYear}年");
            }
        }
    }
}
