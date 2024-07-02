namespace CarReportSystem {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            cbAuthor = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbCarName = new ComboBox();
            groupBox1 = new GroupBox();
            rbOther = new RadioButton();
            rbToyota = new RadioButton();
            rbImport = new RadioButton();
            rbNissan = new RadioButton();
            rbSubaru = new RadioButton();
            rbHonda = new RadioButton();
            tbReport = new Button();
            label6 = new Label();
            pbPicture = new PictureBox();
            ofdPicFileOpen = new Button();
            btPicDelete = new Button();
            btAddReport = new Button();
            btModifyReport = new Button();
            btDeleteReport = new Button();
            label7 = new Label();
            dgvCarReport = new DataGridView();
            btReportSave = new Button();
            btReportOpen = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarReport).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 14F);
            label1.Location = new Point(39, 32);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(95, 26);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 33);
            dtpDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 14F);
            label2.Location = new Point(20, 74);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 2;
            label2.Text = "記録者";
            // 
            // cbAuthor
            // 
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(95, 76);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(236, 23);
            cbAuthor.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 14F);
            label3.Location = new Point(20, 124);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 4;
            label3.Text = "メーカー";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 14F);
            label4.Location = new Point(33, 174);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 5;
            label4.Text = "車名";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 14F);
            label5.Location = new Point(16, 215);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 6;
            label5.Text = "レポート";
            // 
            // cbCarName
            // 
            cbCarName.FormattingEnabled = true;
            cbCarName.Location = new Point(95, 174);
            cbCarName.Name = "cbCarName";
            cbCarName.Size = new Size(224, 23);
            cbCarName.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbOther);
            groupBox1.Controls.Add(rbToyota);
            groupBox1.Controls.Add(rbImport);
            groupBox1.Controls.Add(rbNissan);
            groupBox1.Controls.Add(rbSubaru);
            groupBox1.Controls.Add(rbHonda);
            groupBox1.Location = new Point(95, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 51);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Location = new Point(285, 19);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(56, 19);
            rbOther.TabIndex = 14;
            rbOther.TabStop = true;
            rbOther.Text = "その他";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            rbToyota.AutoSize = true;
            rbToyota.Location = new Point(6, 19);
            rbToyota.Name = "rbToyota";
            rbToyota.Size = new Size(50, 19);
            rbToyota.TabIndex = 9;
            rbToyota.TabStop = true;
            rbToyota.Text = "トヨタ";
            rbToyota.UseVisualStyleBackColor = true;
            // 
            // rbImport
            // 
            rbImport.AutoSize = true;
            rbImport.Location = new Point(227, 19);
            rbImport.Name = "rbImport";
            rbImport.Size = new Size(61, 19);
            rbImport.TabIndex = 13;
            rbImport.TabStop = true;
            rbImport.Text = "輸入車";
            rbImport.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            rbNissan.AutoSize = true;
            rbNissan.Location = new Point(56, 19);
            rbNissan.Name = "rbNissan";
            rbNissan.Size = new Size(49, 19);
            rbNissan.TabIndex = 10;
            rbNissan.TabStop = true;
            rbNissan.Text = "日差";
            rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            rbSubaru.AutoSize = true;
            rbSubaru.Location = new Point(167, 19);
            rbSubaru.Name = "rbSubaru";
            rbSubaru.Size = new Size(54, 19);
            rbSubaru.TabIndex = 12;
            rbSubaru.TabStop = true;
            rbSubaru.Text = "スバル";
            rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            rbHonda.AutoSize = true;
            rbHonda.Location = new Point(108, 19);
            rbHonda.Name = "rbHonda";
            rbHonda.Size = new Size(53, 19);
            rbHonda.TabIndex = 11;
            rbHonda.TabStop = true;
            rbHonda.Text = "ホンダ";
            rbHonda.UseVisualStyleBackColor = true;
            // 
            // tbReport
            // 
            tbReport.Location = new Point(95, 215);
            tbReport.Name = "tbReport";
            tbReport.Size = new Size(335, 96);
            tbReport.TabIndex = 9;
            tbReport.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 14F);
            label6.Location = new Point(468, 32);
            label6.Name = "label6";
            label6.Size = new Size(50, 25);
            label6.TabIndex = 10;
            label6.Text = "画像";
            // 
            // pbPicture
            // 
            pbPicture.BackColor = SystemColors.ActiveBorder;
            pbPicture.Location = new Point(468, 63);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(208, 195);
            pbPicture.SizeMode = PictureBoxSizeMode.Zoom;
            pbPicture.TabIndex = 11;
            pbPicture.TabStop = false;
            // 
            // ofdPicFileOpen
            // 
            ofdPicFileOpen.Location = new Point(541, 34);
            ofdPicFileOpen.Name = "ofdPicFileOpen";
            ofdPicFileOpen.Size = new Size(62, 23);
            ofdPicFileOpen.TabIndex = 12;
            ofdPicFileOpen.Text = "開く…";
            ofdPicFileOpen.UseVisualStyleBackColor = true;
            // 
            // btPicDelete
            // 
            btPicDelete.Location = new Point(614, 34);
            btPicDelete.Name = "btPicDelete";
            btPicDelete.Size = new Size(62, 23);
            btPicDelete.TabIndex = 13;
            btPicDelete.Text = "削除";
            btPicDelete.UseVisualStyleBackColor = true;
            btPicDelete.Click += btPicDelete_Click;
            // 
            // btAddReport
            // 
            btAddReport.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btAddReport.Location = new Point(468, 277);
            btAddReport.Name = "btAddReport";
            btAddReport.Size = new Size(62, 34);
            btAddReport.TabIndex = 14;
            btAddReport.Text = "追加";
            btAddReport.UseVisualStyleBackColor = true;
            btAddReport.Click += btAddReport_Click;
            // 
            // btModifyReport
            // 
            btModifyReport.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btModifyReport.Location = new Point(541, 277);
            btModifyReport.Name = "btModifyReport";
            btModifyReport.Size = new Size(62, 34);
            btModifyReport.TabIndex = 15;
            btModifyReport.Text = "修正";
            btModifyReport.UseVisualStyleBackColor = true;
            btModifyReport.Click += btModifyReport_Click;
            // 
            // btDeleteReport
            // 
            btDeleteReport.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDeleteReport.Location = new Point(614, 277);
            btDeleteReport.Name = "btDeleteReport";
            btDeleteReport.Size = new Size(62, 34);
            btDeleteReport.TabIndex = 16;
            btDeleteReport.Text = "削除";
            btDeleteReport.UseVisualStyleBackColor = true;
            btDeleteReport.Click += btDeleteReport_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 14F);
            label7.Location = new Point(33, 329);
            label7.Name = "label7";
            label7.Size = new Size(50, 25);
            label7.TabIndex = 17;
            label7.Text = "一覧";
            // 
            // dgvCarReport
            // 
            dgvCarReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarReport.Location = new Point(95, 329);
            dgvCarReport.Name = "dgvCarReport";
            dgvCarReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarReport.Size = new Size(581, 158);
            dgvCarReport.TabIndex = 18;
            // 
            // btReportSave
            // 
            btReportSave.Location = new Point(21, 451);
            btReportSave.Name = "btReportSave";
            btReportSave.Size = new Size(62, 36);
            btReportSave.TabIndex = 19;
            btReportSave.Text = "保存…";
            btReportSave.UseVisualStyleBackColor = true;
            // 
            // btReportOpen
            // 
            btReportOpen.Location = new Point(21, 406);
            btReportOpen.Name = "btReportOpen";
            btReportOpen.Size = new Size(62, 36);
            btReportOpen.TabIndex = 20;
            btReportOpen.Text = "開く…";
            btReportOpen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 499);
            Controls.Add(btReportOpen);
            Controls.Add(btReportSave);
            Controls.Add(dgvCarReport);
            Controls.Add(label7);
            Controls.Add(btDeleteReport);
            Controls.Add(btModifyReport);
            Controls.Add(btAddReport);
            Controls.Add(btPicDelete);
            Controls.Add(ofdPicFileOpen);
            Controls.Add(pbPicture);
            Controls.Add(label6);
            Controls.Add(tbReport);
            Controls.Add(groupBox1);
            Controls.Add(cbCarName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbAuthor);
            Controls.Add(label2);
            Controls.Add(dtpDate);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private Label label2;
        private ComboBox cbAuthor;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbCarName;
        private GroupBox groupBox1;
        private RadioButton rbOther;
        private RadioButton rbToyota;
        private RadioButton rbImport;
        private RadioButton rbNissan;
        private RadioButton rbSubaru;
        private RadioButton rbHonda;
        private Button tbReport;
        private Label label6;
        private PictureBox pbPicture;
        private Button ofdPicFileOpen;
        private Button btPicDelete;
        private Button btAddReport;
        private Button btModifyReport;
        private Button btDeleteReport;
        private Label label7;
        private DataGridView dgvCarReport;
        private Button btReportSave;
        private Button btReportOpen;
    }
}
