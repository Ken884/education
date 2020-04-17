using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBAccess
{
    class Dao
    {
        // 接続文字列
        private const string ConnectStatement =
            "userid=root; password=password; database=vocaloid_songs; Host=localhost";
        // 可変長WHERE句を作りやすくするフレーズ
        private const string WhereTrueStatement = "where 1=1 ";

        /* 条件に合う曲の一覧を返す */
        // MODIFY BELOW CODE / CHECK
        public DataTable SearchSongs(string song, int? vocaloidId, string producer, string publishYear)
        {
            // SQL検索クエリ
            string searchSongQuery =
            "SELECT s.name AS 曲名, GROUP_CONCAT(v.name separator ', ') AS VOCALOID, p.name AS 作曲者, s.publish_at AS 発表日, s.views AS 再生数 "
            + "FROM vocaloid_songs.songs AS s " +
            "LEFT JOIN vocaloid_songs.song_vocaloid AS sv ON sv.song_id = s.id " +
            "LEFT JOIN vocaloid_songs.vocaloids AS v ON v.id = sv.vocaloid_id " +
            "LEFT JOIN vocaloid_songs.producers AS p ON p.id = s.producer_id";
            string searchSongQueryGroupBy = "GROUP BY s.name, s.publish_at";

            // データを格納するテーブル作成
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(ConnectStatement))
            {
                conn.Open();

                // SQL文を作成
                StringBuilder querySb = new StringBuilder();
                querySb.Append(" " + searchSongQuery);
                querySb.Append(" " + WhereTrueStatement);

                // SQL文のWhere句を作成
                StringBuilder where = new StringBuilder();
                if (!string.IsNullOrWhiteSpace(song))
                {
                    AppendWhere(where, "s.name like @SONG");
                }
                if (vocaloidId != null)
                {
                    AppendWhere(where, "s.id IN (SELECT song_id FROM vocaloid_songs.song_vocaloid WHERE vocaloid_id = @VOCALOID)");
                }
                if (!string.IsNullOrWhiteSpace(producer))
                {
                    AppendWhere(where, "p.name = @PRODUCER");
                }
                if (!string.IsNullOrWhiteSpace(publishYear))
                {
                    AppendWhere(where, "s.publish_at >= @PUBLISH_FROM AND publish_at <= @PUBLISH_END");
                }
                querySb.Append(where.ToString());

                // GROUP BY句を追加
                querySb.Append(searchSongQueryGroupBy);

                // パラメタ置換
                var songSearchCmd = new MySqlCommand(querySb.ToString(), conn);
                songSearchCmd.Parameters.Add(new MySqlParameter("@SONG", "%" + song + "%"));
                songSearchCmd.Parameters.Add(new MySqlParameter("@VOCALOID", vocaloidId));
                songSearchCmd.Parameters.Add(new MySqlParameter("@PRODUCER", producer));
                if (!string.IsNullOrWhiteSpace(publishYear))
                {
                    songSearchCmd.Parameters.Add(new MySqlParameter("@PUBLISH_FROM", new DateTime(int.Parse(publishYear), 1, 1)));
                    songSearchCmd.Parameters.Add(new MySqlParameter("@PUBLISH_END", new DateTime(int.Parse(publishYear), 12, 31)));
                }

                // SQL文と接続情報を指定し、データアダプタを作成
                MySqlDataAdapter da = new MySqlDataAdapter(songSearchCmd);

                // 検索を実行しDataTableに格納
                da.Fill(dt);
            }
            return dt;
        }

        /* VOCALOIDリストを取得する */
        public DataTable FetchVocaloids()
        {
            // SQL文を作成
            string fetchVocaloidsQuery = "SELECT id, name FROM vocaloid_songs.vocaloids";

            // データを格納するDataTableを作成
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(ConnectStatement))
            {
                conn.Open();

                // SQL文と接続情報を指定し、データアダプタを作成
                MySqlDataAdapter da = new MySqlDataAdapter(fetchVocaloidsQuery, conn);

                // 検索を実行しDataTableに格納
                da.Fill(dt);
            }
            return dt;
        }

        /* 曲を追加する。*/
        public void CreateSong(string song, string producer, IEnumerable<int> vocaloids, string views, DateTime? publishAt)
        {
            // 再生数null処理
            /* INSERT YOUR CODE /CHECK*/
            if(views == "")
            {
                views = null;
            }
            
             

            using (MySqlConnection conn = new MySqlConnection(ConnectStatement))
            {
                conn.Open();

                // 作曲者IDを取得
                int producerId = FindProducerIdAndIfNeededCreateProducer(producer);

                // 曲IDの最大値+1を取得
                int nextSongId = FindMaxSongId() + 1;

                // 曲を挿入するSQL文を作成
                string insertSongQuery = "INSERT INTO songs (id, name, producer_id, publish_at, views) " +
                    "VALUES (@ID, @NAME, @PRODUCER_ID, @PUBLISHAT, @VIEWS)";

                // パラメタ置換
                var insertSongCmd = new MySqlCommand(insertSongQuery, conn);
                /* INSERT YOUR CODE /CHECK*/
                insertSongCmd.Parameters.Add(new MySqlParameter("@ID", nextSongId));
                insertSongCmd.Parameters.Add(new MySqlParameter("@NAME", song));
                insertSongCmd.Parameters.Add(new MySqlParameter("@PRODUCER_ID", producerId));
                insertSongCmd.Parameters.Add(new MySqlParameter("@PUBLISHAT", publishAt));
                insertSongCmd.Parameters.Add(new MySqlParameter("@VIEWS", views));

                // SQL実行
                insertSongCmd.ExecuteNonQuery();

                // 曲-VOCALOID中間テーブルにデータを挿入する
                // SQL文を作成
                string insertSongVocaloidQuery =
                    "INSERT INTO song_vocaloid (song_id, vocaloid_id) " +
                    "VALUES(@SONG_ID, @VOCALOID_ID)";

                // 受け取ったVOCALOIDIDそれぞれに対して処理を行う
                /* INSERT YOUR CODE */
                
                foreach (var vocaloidId in vocaloids)
                {
                    var insertSongVocaloidCmd = new MySqlCommand(insertSongVocaloidQuery, conn);
                    insertSongVocaloidCmd.Parameters.Add(new MySqlParameter("@SONG_ID", nextSongId));
                    insertSongVocaloidCmd.Parameters.Add(new MySqlParameter("@VOCALOID_ID", vocaloidId));

                    insertSongVocaloidCmd.ExecuteNonQuery();
                }

                MessageBox.Show("登録しました");
            }
        }

        /* 作曲者IDを返す。
         * 存在しなければ作曲者を追加したうえで、その作曲者IDを返す。 */
        private int FindProducerIdAndIfNeededCreateProducer(string producer)
        {
            // SQL文作成
            string searchProducerQuery = "SELECT id FROM producers WHERE name = @PRODUCER";

            using (MySqlConnection conn = new MySqlConnection(ConnectStatement))
            {
                conn.Open();

                // パラメタ置換
                var cmd = new MySqlCommand(searchProducerQuery, conn);
                cmd.Parameters.Add(new MySqlParameter("@PRODUCER", producer));

                // SQL実行（なければnull）
                int? producerId = (int?)cmd.ExecuteScalar();

                // 作曲者IDが存在すれば、それを返す
                if (producerId != null)
                {
                    return (int)producerId;
                }
                // もしも作曲者が存在しなかった場合は、作曲者を追加しそのIDを返す
                else
                {
                    // INSERT用SQL文作成
                    /* INSERT YOUR CODE /DONE*/
                    string insertProducerQuery = "INSERT INTO producers (id, name) VALUES (@ID, @NAME)";

                    // 挿入するべき作曲者IDを取得
                    /* INSERT YOUR CODE /DONE*/
                    int nextProducerId = FindMaxProducerId() + 1;

                    // パラメタ置換
                    /* INSERT YOUR CODE /DONE*/
                    var insertProducerCmd = new MySqlCommand(insertProducerQuery, conn);
                    insertProducerCmd.Parameters.Add(new MySqlParameter("@ID", nextProducerId));
                    insertProducerCmd.Parameters.Add(new MySqlParameter("@NAME", producer));

                    // SQL実行
                    cmd.ExecuteNonQuery();

                    // 作曲者IDを返す
                    /* MODIFY BELOW CODE /DONE*/
                    return nextProducerId;
                }
            }
        }

        /* 曲IDの最大値を取得する */
        private int FindMaxSongId()
        {
            // SQL文作成
            string searchMaxSongIdQuery = "SELECT MAX(id) FROM songs ";

            using (MySqlConnection conn = new MySqlConnection(ConnectStatement))
            {
                conn.Open();

                var searchMaxSongIdcmd = new MySqlCommand(searchMaxSongIdQuery, conn);
                // SQL実行
                return (int)searchMaxSongIdcmd.ExecuteScalar();
            }
        }

        /* 作曲者IDの最大値を取得する */
        private int FindMaxProducerId()
        {
            /* INSERT YOUR CODE AND MODIFY BELOW CODE /DONE*/
            string searchMaxProducerIdQuery = "SELECT MAX(id) FROM producers ";

            using (MySqlConnection conn = new MySqlConnection(ConnectStatement))
            {
                conn.Open();

                var searchMaxProducerIdcmd = new MySqlCommand(searchMaxProducerIdQuery, conn);
                // SQL実行
                return (int)searchMaxProducerIdcmd.ExecuteScalar();
            }
            
        }

        /* 可変長WHERE句を生成する。
         * 渡されたStringBuilderにstringを連結する */
        public void AppendWhere(StringBuilder sb, string str)
        {
            sb.Append(" and " + str + " ");
        }
    }
}