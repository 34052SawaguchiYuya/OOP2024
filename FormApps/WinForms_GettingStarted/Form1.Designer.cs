namespace WinForms_GettingStarted {
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
            this.btGet = new System.Windows.Forms.Button();
            this.tbRssUrl = new System.Windows.Forms.TextBox();
            this.cbRssUrl = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.webBrowser1 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.webBrowser1)).BeginInit();
            this.SuspendLayout();
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(295, 19);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(78, 23);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // tbRssUrl
            // 
            this.tbRssUrl.Location = new System.Drawing.Point(54, 48);
            this.tbRssUrl.Multiline = true;
            this.tbRssUrl.Name = "tbRssUrl";
            this.tbRssUrl.Size = new System.Drawing.Size(428, 19);
            this.tbRssUrl.TabIndex = 2;
            this.tbRssUrl.TextChanged += new System.EventHandler(this.tbRssUrl_TextChanged);
            // 
            // cbRssUrl
            // 
            this.cbRssUrl.Location = new System.Drawing.Point(584, 48);
            this.cbRssUrl.Name = "cbRssUrl";
            this.cbRssUrl.Size = new System.Drawing.Size(417, 19);
            this.cbRssUrl.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(808, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "登録";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(637, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(364, 556);
            this.listBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(147, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "URL又はお気に入り名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(706, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "お気に入り名称：";
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowExternalDrop = true;
            this.webBrowser1.CreationProperties = null;
            this.webBrowser1.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webBrowser1.Location = new System.Drawing.Point(12, 73);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(619, 553);
            this.webBrowser1.Source = new System.Uri("https://www.yahoo.co.jp/", System.UriKind.Absolute);
            this.webBrowser1.TabIndex = 8;
            this.webBrowser1.ZoomFactor = 1D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1038, 638);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbRssUrl);
            this.Controls.Add(this.tbRssUrl);
            this.Controls.Add(this.btGet);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.webBrowser1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.TextBox tbRssUrl;
        private System.Windows.Forms.TextBox cbRssUrl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Microsoft.Web.WebView2.WinForms.WebView2 webBrowser1;
    }
}

