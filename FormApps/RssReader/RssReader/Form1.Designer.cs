namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.syutoku = new System.Windows.Forms.Button();
            this.touroku = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.listBox = new System.Windows.Forms.ListBox();
            this.cbRssUrl2 = new System.Windows.Forms.ComboBox();
            this.cbRssUrl = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // syutoku
            // 
            this.syutoku.Location = new System.Drawing.Point(91, 23);
            this.syutoku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.syutoku.Name = "syutoku";
            this.syutoku.Size = new System.Drawing.Size(63, 25);
            this.syutoku.TabIndex = 0;
            this.syutoku.Text = "取得";
            this.syutoku.UseVisualStyleBackColor = true;
            this.syutoku.Click += new System.EventHandler(this.syutoku_Click);
            // 
            // touroku
            // 
            this.touroku.Location = new System.Drawing.Point(366, 23);
            this.touroku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.touroku.Name = "touroku";
            this.touroku.Size = new System.Drawing.Size(63, 25);
            this.touroku.TabIndex = 1;
            this.touroku.Text = "登録";
            this.touroku.UseVisualStyleBackColor = true;
            this.touroku.Click += new System.EventHandler(this.touroku_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(251, 106);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.webBrowser.MinimumSize = new System.Drawing.Size(13, 15);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(270, 363);
            this.webBrowser.TabIndex = 2;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 12;
            this.listBox.Location = new System.Drawing.Point(15, 106);
            this.listBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(204, 364);
            this.listBox.TabIndex = 3;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // cbRssUrl2
            // 
            this.cbRssUrl2.FormattingEnabled = true;
            this.cbRssUrl2.Location = new System.Drawing.Point(276, 52);
            this.cbRssUrl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbRssUrl2.Name = "cbRssUrl2";
            this.cbRssUrl2.Size = new System.Drawing.Size(239, 20);
            this.cbRssUrl2.TabIndex = 4;
            this.cbRssUrl2.SelectedIndexChanged += new System.EventHandler(this.cbRssUrl2_SelectedIndexChanged);
            // 
            // cbRssUrl
            // 
            this.cbRssUrl.FormattingEnabled = true;
            this.cbRssUrl.Location = new System.Drawing.Point(8, 52);
            this.cbRssUrl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbRssUrl.Name = "cbRssUrl";
            this.cbRssUrl.Size = new System.Drawing.Size(243, 20);
            this.cbRssUrl.TabIndex = 5;
            this.cbRssUrl.SelectedIndexChanged += new System.EventHandler(this.cbRssUrl_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(539, 478);
            this.Controls.Add(this.cbRssUrl);
            this.Controls.Add(this.cbRssUrl2);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.touroku);
            this.Controls.Add(this.syutoku);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button syutoku;
        private System.Windows.Forms.Button touroku;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ComboBox cbRssUrl2;
        private System.Windows.Forms.ComboBox cbRssUrl;
    }
}

