using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using DBAccsess;

namespace DBAccess
{
    public partial class SearchResult : Form
    {
        Dao dao = new Dao();

        public SearchResult()
        {
            InitializeComponent();
            
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            // VOCALOIDコンボボックスのデータの初期表示
            vocaloidComboBox.DataSource = dao.FetchVocaloids();
            vocaloidComboBox.ValueMember = "id";
            vocaloidComboBox.DisplayMember = "name";

            // VOCALOIDコンボボックスを最初は未選択にしておく
            vocaloidComboBox.Text = null;

            // 発表年コンボボックスに値を初期表示（2007年から13年間）
            publishYearComboBox.Items.AddRange(Enumerable.Range(2007, 13).Select(x => x.ToString()).ToArray());
            
            // 検索結果表示
            SearchSongs();
        }

        private void SearchSongs()
        {
            // 曲名、作曲者名、VOCALOIDID、発表年取得
            string song = songTextBox.Text;
            int? vocaloidId = (int?)vocaloidComboBox.SelectedValue;
            string producer = producerTextBox.Text;
            string publishYear = publishYearComboBox.Text;
            DataTable dt = dao.SearchSongs(song, vocaloidId, producer, publishYear);

            // データ表示
            searchResultDataGridView.DataSource = dt;

            // 検索結果グリッドビューカラム幅固定
            searchResultDataGridView.Columns[0].Width = 200;
            searchResultDataGridView.Columns[1].Width = 200;
            searchResultDataGridView.Columns[2].Width = 100;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchSongs();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            // 登録フォーム呼び出し
            var createForm = new Create();
            createForm.ShowDialog(this);
        }
    }
}

