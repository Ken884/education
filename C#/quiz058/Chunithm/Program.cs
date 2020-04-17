using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello world");
            for (int i = 1; i <= 5; i++)
            {
                //Console.WriteLine(CalculateRatingByOnlySql(i).Rows[0][0]);
                Console.WriteLine(i + " " + CalululateRatingByApplication(i));
            }
        }

        // 接続文字列
        private const string ConnectStatement =
            "userid=root; password=password; database=chunithm; Host=localhost";

        /* 条件に合う曲の一覧を返す */
        public static DataTable CalculateRatingByOnlySql(int userId)
        {
            // SQL検索クエリ
            string query = "";
            /* INSERT YOUR VERY CRAZY LONG LONG SQL CODE */

            // データを格納するテーブル作成
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(ConnectStatement))
            {
                conn.Open();

                // コマンド作成
                var cmd = new MySqlCommand(query, conn);

                // SQL文と接続情報を指定し、データアダプタを作成
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                // 検索を実行しDataTableに格納
                da.Fill(dt);
            }
            return dt;
        }

        public static double CalululateRatingByApplication(int userId)
        {
            // データを格納するテーブル作成
            DataTable dt = new DataTable();

            string query =
            "select song_id, name, constant, score, play_at " +
            "from chunithm.play " +
            "left join chunithm.song AS s on song_id = s.id " +
            "where user_id = " + userId;

            using (MySqlConnection conn = new MySqlConnection(ConnectStatement))
            {
                conn.Open();

                // コマンド作成
                var cmd = new MySqlCommand(query, conn);

                // SQL文と接続情報を指定し、データアダプタを作成
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                // 検索を実行しDataTableに格納
                da.Fill(dt);
            }

            /* INSERT YOUR CODE */
            //adding performance
            decimal performance;
            var ndt = new DataTable();
            ndt.Columns.Add("performance", typeof(decimal));
            ndt.Columns.Add("song_id", typeof(int));
            ndt.Columns.Add("play_at", typeof(DateTime));

            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32(dr["score"]) >= 1007500)
                {
                    performance = Convert.ToDecimal(dr["constant"]) + (decimal)2.0;
                }
                else if (Convert.ToInt32(dr["score"]) >= 1005000)
                {
                    performance = (Convert.ToDecimal(dr["constant"]) + (decimal)1.5 + Convert.ToDecimal((Convert.ToDouble(dr["score"]) - 1005000) / 5000));
                }
                else if (Convert.ToInt32(dr["score"]) >= 1000000)
                {
                    performance = Convert.ToDecimal(dr["constant"]) + (decimal)1.0 + Convert.ToDecimal((Convert.ToDouble(dr["score"]) - 1000000) / 10000);
                }
                else if ((Convert.ToInt32(dr["score"]) >= 975000))
                {
                    performance = Convert.ToDecimal(dr["constant"]) + Convert.ToDecimal((Convert.ToDouble(dr["score"]) -975000) / 25000);
                }
                else
                {
                    performance = Convert.ToDecimal(dr["constant"]) - Convert.ToDecimal((975000 - Convert.ToDouble(dr["score"])) / 16666);
                }
                
                ndt.Rows.Add(performance, Convert.ToInt32(dr["song_id"]), Convert.ToDateTime(dr["play_at"]));
                
            }
            var list = new List<double>();

            var best = ndt.AsEnumerable().GroupBy(row => row.Field<int>("song_id"))
                .Select(x => x.Max(y => y.Field<decimal>("performance")))
                .OrderByDescending(x => x).ToArray();

            for (int i = 0; i < 30; i++)
                {
                    double b = Convert.ToDouble(best[i]);
                    list.Add(b);
                //Console.WriteLine(b);
            }

            var recent = ndt.AsEnumerable().OrderByDescending(x => x.Field<DateTime>("play_at")).ToArray();
            var recents40 = new List<DataRow>();
            for (int i = 0; i < 40; i++)
            {
                recents40.Add(recent[i]);
                
            }

            var recent2 = recents40.OrderByDescending(x => x.Field<decimal>("performance")).ToList();
            var recents10 = new List<DataRow>();
            for(int i =0; i < 10; i++ )
            {
                recents10.Add(recent2[i]);
            }

            foreach(DataRow row in recents10)
            {
                double r = Convert.ToDouble(row["performance"]);
                list.Add(r);
                
            }

            

            return Math.Round(list.Average(),2,MidpointRounding.AwayFromZero);
            

        }


        private static List<double> BestPerforrmances(int userId)
        {

            string searchBestPerforamanceQuery =
                "SELECT MAX(CASE WHEN p.score >= 1007500 THEN s.constant + 2 " +
                "WHEN p.score >= 1005000 THEN s.constant + 1.5 + ((p.score - 1005000) / 5000) " +
                "WHEN p.score >= 1000000 THEN s.constant + 1 + ((p.score - 1000000) / 10000) " +
                "WHEN p.score >= 975000 THEN s.constant + ((p.score - 975000) / 25000) " +
                "WHEN p.score < 975000 THEN  s.constant - ((975000 - p.score) / 16666) END) AS performance " +
                "FROM chunithm.play as p " +
                "JOIN chunithm.song as s " +
                "ON p.song_id = s.id " +
                "WHERE p.user_id =" + userId +
                " GROUP BY p.song_id " +
                "ORDER BY performance DESC LIMIT 30";

            using (MySqlConnection conn = new MySqlConnection(ConnectStatement))
            {
                conn.Open();
                var bestPerformances = new List<double>();
                var searchBestPerformancecmd = new MySqlCommand(searchBestPerforamanceQuery, conn);
                var reader = searchBestPerformancecmd.ExecuteReader();
                while (reader.Read())
                {
                    bestPerformances.Add(Convert.ToDouble(reader.GetValue(0)));
                }
                return bestPerformances;
            }

        }

        private static List<double> RecentPerforrmances(int userId)
        {

            string searchRecentPerforamanceQuery =
                "SELECT x.performance " +
                "FROM ( SELECT (CASE WHEN p.score >= 1007500 THEN s.constant + 2 " +
                "WHEN p.score >= 1005000 THEN s.constant + 1.5 + ((p.score - 1005000) / 5000) " +
                "WHEN p.score >= 1000000 THEN s.constant + 1 + ((p.score - 1000000) / 10000) " +
                "WHEN p.score >= 975000 THEN s.constant + ((p.score - 975000) / 25000) " +
                "WHEN p.score < 975000 THEN s.constant - ((975000 - p.score) / 16666) END) AS performance " +
                "FROM chunithm.play as p " +
                "JOIN chunithm.song as s " +
                "ON p.song_id = s.id " +
                "WHERE p.user_id =" + userId +
                " ORDER BY p.play_at DESC LIMIT 40 ) AS x " +
                "ORDER BY x.performance DESC LIMIT 10";

            using (MySqlConnection conn = new MySqlConnection(ConnectStatement))
            {
                conn.Open();
                var RecentPerformances = new List<double>();
                var searchRecentPerformancecmd = new MySqlCommand(searchRecentPerforamanceQuery, conn);
                var reader = searchRecentPerformancecmd.ExecuteReader();
                while (reader.Read())
                {
                    RecentPerformances.Add(Convert.ToDouble(reader.GetValue(0)));
                }
                return RecentPerformances;
            }

        }
    }


    class Dto
    {
        /* YOU CAN USE INNNER DTO CLASS IF YOU WANT */
    }
}
