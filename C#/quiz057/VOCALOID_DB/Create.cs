using DBAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBAccsess
{
    public partial class Create : Form
    {
        Dao dao = new Dao();

        public Create()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            // 曲名を取得
            string song = songTextBox.Text;

            // VOCALOID_IDを取得
            List<int> vocaloids = new List<int>();
            foreach(var item in vocaloidCheckedListBox.CheckedItems)
            {
                vocaloids.Add((int)((DataRowView)item)["id"]);
            }

            // 作曲者名を取得
            string producer = producerTextBox.Text;

            // 再生数を取得
            string views = viewsTextBox.Text;

            //　発表日を取得（登録しない場合はnull(まだ未実装)）
            /* MODIFY BELOW CODE /CHECK*/
            DateTime? publishAt = publishAtDateTimePicker.Value;
            if (notRegisterPublishAtCheckBox.Checked)
            {
                publishAt = null;
            }
             
            

            // エラー処理
            /* INSERT YOUR CODE /Done*/
            if ((views != "" ) && Convert.ToInt32(views) < 0)
            {
                errorLabel.Text = "エラー";
            }
            else if((views != "") && int.TryParse(views, out var x))
            {
                errorLabel.Text = "エラー";
            }
            else if(song == "")
            {
                song = null;
                errorLabel.Text = "エラー";
            }else if(producer == "")
            {
                producer = null;
                errorLabel.Text = "エラー";
            }
            else
            {
                // 登録処理
                dao.CreateSong(song, producer, vocaloids, views, publishAt);
            }

           
        }

        private void Create_Load(object sender, EventArgs e)
        {
            // エラーラベルを初期化
            errorLabel.Text = string.Empty;

            // VOCALOID名リストボックス初期表示
            vocaloidCheckedListBox.DataSource = dao.FetchVocaloids();
            vocaloidCheckedListBox.ValueMember = "id";
            vocaloidCheckedListBox.DisplayMember = "name";
        }

        private void notRegisterPublishAtCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // 発表日を登録しないにチェックを入れると、発表日DatePickerを非活性にする
            publishAtDateTimePicker.Enabled = notRegisterPublishAtCheckBox.Checked ? false : true ;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
