namespace DBAccsess
{
    partial class Create
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.producerTextBox = new System.Windows.Forms.TextBox();
            this.songTextBox = new System.Windows.Forms.TextBox();
            this.publishYearLabel = new System.Windows.Forms.Label();
            this.vocaloidLabel = new System.Windows.Forms.Label();
            this.producerLabel = new System.Windows.Forms.Label();
            this.songLabel = new System.Windows.Forms.Label();
            this.vocaloidCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.publishAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.notRegisterPublishAtCheckBox = new System.Windows.Forms.CheckBox();
            this.createButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.viewsLabel = new System.Windows.Forms.Label();
            this.viewsTextBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // producerTextBox
            // 
            this.producerTextBox.Location = new System.Drawing.Point(493, 27);
            this.producerTextBox.Name = "producerTextBox";
            this.producerTextBox.Size = new System.Drawing.Size(240, 22);
            this.producerTextBox.TabIndex = 15;
            // 
            // songTextBox
            // 
            this.songTextBox.Location = new System.Drawing.Point(163, 27);
            this.songTextBox.Name = "songTextBox";
            this.songTextBox.Size = new System.Drawing.Size(240, 22);
            this.songTextBox.TabIndex = 14;
            // 
            // publishYearLabel
            // 
            this.publishYearLabel.AutoSize = true;
            this.publishYearLabel.Location = new System.Drawing.Point(420, 92);
            this.publishYearLabel.Name = "publishYearLabel";
            this.publishYearLabel.Size = new System.Drawing.Size(52, 15);
            this.publishYearLabel.TabIndex = 13;
            this.publishYearLabel.Text = "発表日";
            // 
            // vocaloidLabel
            // 
            this.vocaloidLabel.AutoSize = true;
            this.vocaloidLabel.Location = new System.Drawing.Point(36, 62);
            this.vocaloidLabel.Name = "vocaloidLabel";
            this.vocaloidLabel.Size = new System.Drawing.Size(79, 15);
            this.vocaloidLabel.TabIndex = 12;
            this.vocaloidLabel.Text = "VOCALOID";
            // 
            // producerLabel
            // 
            this.producerLabel.AutoSize = true;
            this.producerLabel.Location = new System.Drawing.Point(420, 30);
            this.producerLabel.Name = "producerLabel";
            this.producerLabel.Size = new System.Drawing.Size(67, 15);
            this.producerLabel.TabIndex = 11;
            this.producerLabel.Text = "作曲者名";
            // 
            // songLabel
            // 
            this.songLabel.AutoSize = true;
            this.songLabel.Location = new System.Drawing.Point(36, 27);
            this.songLabel.Name = "songLabel";
            this.songLabel.Size = new System.Drawing.Size(37, 15);
            this.songLabel.TabIndex = 10;
            this.songLabel.Text = "曲名";
            // 
            // vocaloidCheckedListBox
            // 
            this.vocaloidCheckedListBox.FormattingEnabled = true;
            this.vocaloidCheckedListBox.Location = new System.Drawing.Point(163, 62);
            this.vocaloidCheckedListBox.Name = "vocaloidCheckedListBox";
            this.vocaloidCheckedListBox.Size = new System.Drawing.Size(240, 123);
            this.vocaloidCheckedListBox.TabIndex = 18;
            // 
            // publishAtDateTimePicker
            // 
            this.publishAtDateTimePicker.Location = new System.Drawing.Point(493, 92);
            this.publishAtDateTimePicker.Name = "publishAtDateTimePicker";
            this.publishAtDateTimePicker.Size = new System.Drawing.Size(240, 22);
            this.publishAtDateTimePicker.TabIndex = 19;
            // 
            // notRegisterPublishAtCheckBox
            // 
            this.notRegisterPublishAtCheckBox.AutoSize = true;
            this.notRegisterPublishAtCheckBox.Location = new System.Drawing.Point(493, 132);
            this.notRegisterPublishAtCheckBox.Name = "notRegisterPublishAtCheckBox";
            this.notRegisterPublishAtCheckBox.Size = new System.Drawing.Size(151, 19);
            this.notRegisterPublishAtCheckBox.TabIndex = 20;
            this.notRegisterPublishAtCheckBox.Text = "発表日を登録しない";
            this.notRegisterPublishAtCheckBox.UseVisualStyleBackColor = true;
            this.notRegisterPublishAtCheckBox.CheckedChanged += new System.EventHandler(this.notRegisterPublishAtCheckBox_CheckedChanged);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(462, 198);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(137, 39);
            this.createButton.TabIndex = 21;
            this.createButton.Text = "追加";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(620, 198);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(137, 39);
            this.closeButton.TabIndex = 22;
            this.closeButton.Text = "閉じる";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // viewsLabel
            // 
            this.viewsLabel.AutoSize = true;
            this.viewsLabel.Location = new System.Drawing.Point(420, 62);
            this.viewsLabel.Name = "viewsLabel";
            this.viewsLabel.Size = new System.Drawing.Size(52, 15);
            this.viewsLabel.TabIndex = 23;
            this.viewsLabel.Text = "再生数";
            // 
            // viewsTextBox
            // 
            this.viewsTextBox.Location = new System.Drawing.Point(493, 59);
            this.viewsTextBox.Name = "viewsTextBox";
            this.viewsTextBox.Size = new System.Drawing.Size(240, 22);
            this.viewsTextBox.TabIndex = 24;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(30, 222);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(40, 15);
            this.errorLabel.TabIndex = 25;
            this.errorLabel.Text = "エラー";
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 254);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.viewsTextBox);
            this.Controls.Add(this.viewsLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.notRegisterPublishAtCheckBox);
            this.Controls.Add(this.publishAtDateTimePicker);
            this.Controls.Add(this.vocaloidCheckedListBox);
            this.Controls.Add(this.producerTextBox);
            this.Controls.Add(this.songTextBox);
            this.Controls.Add(this.publishYearLabel);
            this.Controls.Add(this.vocaloidLabel);
            this.Controls.Add(this.producerLabel);
            this.Controls.Add(this.songLabel);
            this.Name = "Create";
            this.Text = "新しい曲の追加";
            this.Load += new System.EventHandler(this.Create_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox producerTextBox;
        private System.Windows.Forms.TextBox songTextBox;
        private System.Windows.Forms.Label publishYearLabel;
        private System.Windows.Forms.Label vocaloidLabel;
        private System.Windows.Forms.Label producerLabel;
        private System.Windows.Forms.Label songLabel;
        private System.Windows.Forms.CheckedListBox vocaloidCheckedListBox;
        private System.Windows.Forms.DateTimePicker publishAtDateTimePicker;
        private System.Windows.Forms.CheckBox notRegisterPublishAtCheckBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label viewsLabel;
        private System.Windows.Forms.TextBox viewsTextBox;
        private System.Windows.Forms.Label errorLabel;
    }
}