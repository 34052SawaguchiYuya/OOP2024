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
            this.Syutoku = new System.Windows.Forms.Button();
            this.Touroku = new System.Windows.Forms.Button();
            this.WebBrowser = new System.Windows.Forms.WebBrowser();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.CbRssUrl2 = new System.Windows.Forms.ComboBox();
            this.CbRssUrl = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Syutoku
            // 
            this.Syutoku.Location = new System.Drawing.Point(91, 23);
            this.Syutoku.Margin = new System.Windows.Forms.Padding(2);
            this.Syutoku.Name = "Syutoku";
            this.Syutoku.Size = new System.Drawing.Size(63, 25);
            this.Syutoku.TabIndex = 0;
            this.Syutoku.Text = "取得";
            this.Syutoku.UseVisualStyleBackColor = true;
            this.Syutoku.Click += new System.EventHandler(this.Syutoku_Click);
            // 
            // Touroku
            // 
            this.Touroku.Location = new System.Drawing.Point(366, 23);
            this.Touroku.Margin = new System.Windows.Forms.Padding(2);
            this.Touroku.Name = "Touroku";
            this.Touroku.Size = new System.Drawing.Size(63, 25);
            this.Touroku.TabIndex = 1;
            this.Touroku.Text = "登録";
            this.Touroku.UseVisualStyleBackColor = true;
            this.Touroku.Click += new System.EventHandler(this.Touroku_Click);
            // 
            // WebBrowser
            // 
            this.WebBrowser.Location = new System.Drawing.Point(251, 106);
            this.WebBrowser.Margin = new System.Windows.Forms.Padding(2);
            this.WebBrowser.MinimumSize = new System.Drawing.Size(13, 15);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.Size = new System.Drawing.Size(270, 363);
            this.WebBrowser.TabIndex = 2;
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 12;
            this.ListBox.Location = new System.Drawing.Point(15, 106);
            this.ListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(204, 364);
            this.ListBox.TabIndex = 3;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // CbRssUrl2
            // 
            this.CbRssUrl2.FormattingEnabled = true;
            this.CbRssUrl2.Location = new System.Drawing.Point(276, 52);
            this.CbRssUrl2.Margin = new System.Windows.Forms.Padding(2);
            this.CbRssUrl2.Name = "CbRssUrl2";
            this.CbRssUrl2.Size = new System.Drawing.Size(239, 20);
            this.CbRssUrl2.TabIndex = 4;
            // 
            // CbRssUrl
            // 
            this.CbRssUrl.FormattingEnabled = true;
            this.CbRssUrl.Location = new System.Drawing.Point(8, 52);
            this.CbRssUrl.Margin = new System.Windows.Forms.Padding(2);
            this.CbRssUrl.Name = "CbRssUrl";
            this.CbRssUrl.Size = new System.Drawing.Size(243, 20);
            this.CbRssUrl.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(539, 478);
            this.Controls.Add(this.CbRssUrl);
            this.Controls.Add(this.CbRssUrl2);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.WebBrowser);
            this.Controls.Add(this.Touroku);
            this.Controls.Add(this.Syutoku);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Syutoku;
        private System.Windows.Forms.Button Touroku;
        private System.Windows.Forms.WebBrowser WebBrowser;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.ComboBox CbRssUrl2;
        private System.Windows.Forms.ComboBox CbRssUrl;
    }
}

