namespace DateTimeApp {
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
            生年月日 = new Label();
            dtpBirthday = new DateTimePicker();
            bt = new Button();
            tbDisp = new TextBox();
            numericUpDown1 = new NumericUpDown();
            btDayBefore = new Button();
            btDayAfter = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // 生年月日
            // 
            生年月日.AutoSize = true;
            生年月日.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            生年月日.Location = new Point(31, 59);
            生年月日.Name = "生年月日";
            生年月日.Size = new Size(62, 32);
            生年月日.TabIndex = 0;
            生年月日.Text = "日付";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpBirthday.Location = new Point(147, 62);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(150, 29);
            dtpBirthday.TabIndex = 1;
            // 
            // bt
            // 
            bt.Location = new Point(172, 118);
            bt.Name = "bt";
            bt.Size = new Size(125, 47);
            bt.TabIndex = 2;
            bt.Text = "今日までの日数";
            bt.UseVisualStyleBackColor = true;
            // 
            // tbDisp
            // 
            tbDisp.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbDisp.Location = new Point(31, 332);
            tbDisp.Name = "tbDisp";
            tbDisp.Size = new Size(266, 39);
            tbDisp.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(31, 195);
            numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(131, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // btDayBefore
            // 
            btDayBefore.Font = new Font("Yu Gothic UI", 18F);
            btDayBefore.Location = new Point(188, 183);
            btDayBefore.Name = "btDayBefore";
            btDayBefore.Size = new Size(75, 43);
            btDayBefore.TabIndex = 5;
            btDayBefore.Text = "日前";
            btDayBefore.UseVisualStyleBackColor = true;
            // 
            // btDayAfter
            // 
            btDayAfter.Font = new Font("Yu Gothic UI", 18F);
            btDayAfter.Location = new Point(188, 232);
            btDayAfter.Name = "btDayAfter";
            btDayAfter.Size = new Size(75, 43);
            btDayAfter.TabIndex = 6;
            btDayAfter.Text = "日後";
            btDayAfter.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 18F);
            button1.Location = new Point(269, 183);
            button1.Name = "button1";
            button1.Size = new Size(75, 43);
            button1.TabIndex = 7;
            button1.Text = "年齢";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 482);
            Controls.Add(button1);
            Controls.Add(btDayAfter);
            Controls.Add(btDayBefore);
            Controls.Add(numericUpDown1);
            Controls.Add(tbDisp);
            Controls.Add(bt);
            Controls.Add(dtpBirthday);
            Controls.Add(生年月日);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label 生年月日;
        private DateTimePicker dtpBirthday;
        private Button bt;
        private TextBox tbDisp;
        private NumericUpDown numericUpDown1;
        private Button btDayBefore;
        private Button btDayAfter;
        private Button button1;
    }
}
