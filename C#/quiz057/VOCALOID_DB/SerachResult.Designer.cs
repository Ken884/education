namespace DBAccess
{
    partial class SearchResult
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.songLabel = new System.Windows.Forms.Label();
            this.producerLabel = new System.Windows.Forms.Label();
            this.vocaloidLabel = new System.Windows.Forms.Label();
            this.publishYearLabel = new System.Windows.Forms.Label();
            this.songTextBox = new System.Windows.Forms.TextBox();
            this.producerTextBox = new System.Windows.Forms.TextBox();
            this.vocaloidComboBox = new System.Windows.Forms.ComboBox();
            this.publishYearComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchResultDataGridView = new System.Windows.Forms.DataGridView();
            this.createButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // songLabel
            // 
            this.songLabel.AutoSize = true;
            this.songLabel.Location = new System.Drawing.Point(21, 26);
            this.songLabel.Name = "songLabel";
            this.songLabel.Size = new System.Drawing.Size(37, 15);
            this.songLabel.TabIndex = 0;
            this.songLabel.Text = "曲名";
            // 
            // producerLabel
            // 
            this.producerLabel.AutoSize = true;
            this.producerLabel.Location = new System.Drawing.Point(361, 27);
            this.producerLabel.Name = "producerLabel";
            this.producerLabel.Size = new System.Drawing.Size(67, 15);
            this.producerLabel.TabIndex = 1;
            this.producerLabel.Text = "作曲者名";
            // 
            // vocaloidLabel
            // 
            this.vocaloidLabel.AutoSize = true;
            this.vocaloidLabel.Location = new System.Drawing.Point(21, 66);
            this.vocaloidLabel.Name = "vocaloidLabel";
            this.vocaloidLabel.Size = new System.Drawing.Size(79, 15);
            this.vocaloidLabel.TabIndex = 2;
            this.vocaloidLabel.Text = "VOCALOID";
            // 
            // publishYearLabel
            // 
            this.publishYearLabel.AutoSize = true;
            this.publishYearLabel.Location = new System.Drawing.Point(361, 68);
            this.publishYearLabel.Name = "publishYearLabel";
            this.publishYearLabel.Size = new System.Drawing.Size(52, 15);
            this.publishYearLabel.TabIndex = 3;
            this.publishYearLabel.Text = "発表年";
            // 
            // songTextBox
            // 
            this.songTextBox.Location = new System.Drawing.Point(107, 23);
            this.songTextBox.Name = "songTextBox";
            this.songTextBox.Size = new System.Drawing.Size(240, 22);
            this.songTextBox.TabIndex = 4;
            // 
            // producerTextBox
            // 
            this.producerTextBox.Location = new System.Drawing.Point(447, 23);
            this.producerTextBox.Name = "producerTextBox";
            this.producerTextBox.Size = new System.Drawing.Size(240, 22);
            this.producerTextBox.TabIndex = 5;
            // 
            // vocaloidComboBox
            // 
            this.vocaloidComboBox.FormattingEnabled = true;
            this.vocaloidComboBox.Location = new System.Drawing.Point(107, 61);
            this.vocaloidComboBox.Name = "vocaloidComboBox";
            this.vocaloidComboBox.Size = new System.Drawing.Size(240, 23);
            this.vocaloidComboBox.TabIndex = 8;
            // 
            // publishYearComboBox
            // 
            this.publishYearComboBox.FormattingEnabled = true;
            this.publishYearComboBox.Location = new System.Drawing.Point(447, 63);
            this.publishYearComboBox.Name = "publishYearComboBox";
            this.publishYearComboBox.Size = new System.Drawing.Size(240, 23);
            this.publishYearComboBox.TabIndex = 9;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(732, 36);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 42);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "検索";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchResultDataGridView
            // 
            this.searchResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResultDataGridView.Location = new System.Drawing.Point(37, 118);
            this.searchResultDataGridView.Name = "searchResultDataGridView";
            this.searchResultDataGridView.RowTemplate.Height = 24;
            this.searchResultDataGridView.Size = new System.Drawing.Size(965, 420);
            this.searchResultDataGridView.TabIndex = 11;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(837, 36);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(165, 42);
            this.createButton.TabIndex = 12;
            this.createButton.Text = "新規登録";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // SearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 574);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.searchResultDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.publishYearComboBox);
            this.Controls.Add(this.vocaloidComboBox);
            this.Controls.Add(this.producerTextBox);
            this.Controls.Add(this.songTextBox);
            this.Controls.Add(this.publishYearLabel);
            this.Controls.Add(this.vocaloidLabel);
            this.Controls.Add(this.producerLabel);
            this.Controls.Add(this.songLabel);
            this.Name = "SearchResult";
            this.Text = "VOCALOID曲データベース";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchResultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label songLabel;
        private System.Windows.Forms.Label producerLabel;
        private System.Windows.Forms.Label vocaloidLabel;
        private System.Windows.Forms.Label publishYearLabel;
        private System.Windows.Forms.TextBox songTextBox;
        private System.Windows.Forms.TextBox producerTextBox;
        private System.Windows.Forms.ComboBox vocaloidComboBox;
        private System.Windows.Forms.ComboBox publishYearComboBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView searchResultDataGridView;
        private System.Windows.Forms.Button createButton;
    }
}

