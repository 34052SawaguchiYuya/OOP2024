namespace Exercise01 {
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
            btEx8_1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            btEx8_3 = new Button();
            SuspendLayout();
            // 
            // btEx8_1
            // 
            btEx8_1.Location = new Point(131, 316);
            btEx8_1.Multiline = true;
            btEx8_1.Name = "btEx8_1";
            btEx8_1.Size = new Size(201, 93);
            btEx8_1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button1.Location = new Point(45, 35);
            button1.Name = "button1";
            button1.Size = new Size(123, 61);
            button1.TabIndex = 1;
            button1.Text = "問題8.1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button2.Location = new Point(45, 116);
            button2.Name = "button2";
            button2.Size = new Size(123, 61);
            button2.TabIndex = 2;
            button2.Text = "問題8.2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btEx8_3
            // 
            btEx8_3.Font = new Font("Yu Gothic UI", 18F);
            btEx8_3.Location = new Point(184, 35);
            btEx8_3.Name = "btEx8_3";
            btEx8_3.Size = new Size(123, 61);
            btEx8_3.TabIndex = 3;
            btEx8_3.Text = "問題8.3";
            btEx8_3.UseVisualStyleBackColor = true;
            btEx8_3.Click += btEx8_3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btEx8_3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btEx8_1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox btEx8_1;
        private Button button1;
        private Button button2;
        private Button btEx8_3;
    }
}
