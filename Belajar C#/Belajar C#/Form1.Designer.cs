namespace Belajar_C_
{
    partial class AplikasiBiodata
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            button3 = new Button();
            label5 = new Label();
            button4 = new Button();
            label6 = new Label();
            button5 = new Button();
            TampilData = new GroupBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(245, 83);
            button1.Name = "button1";
            button1.Size = new Size(266, 41);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(301, 22);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 1;
            label1.Text = "BIODATA SAYA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 91);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 2;
            label2.Text = "Nama :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(398, 127);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(245, 142);
            button2.Name = "button2";
            button2.Size = new Size(266, 41);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(139, 150);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 5;
            label4.Text = "NISN :";
            label4.Click += label4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(245, 205);
            button3.Name = "button3";
            button3.Size = new Size(266, 128);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(139, 205);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
            label5.TabIndex = 7;
            label5.Text = "Alamat : ";
            label5.Click += label5_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Location = new Point(245, 354);
            button4.Name = "button4";
            button4.Size = new Size(266, 55);
            button4.TabIndex = 8;
            button4.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(139, 354);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 9;
            label6.Text = "Pesan :";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Location = new Point(334, 426);
            button5.Name = "button5";
            button5.Size = new Size(83, 36);
            button5.TabIndex = 10;
            button5.Text = "OK";
            button5.UseVisualStyleBackColor = false;
            // 
            // TampilData
            // 
            TampilData.Location = new Point(211, 480);
            TampilData.Name = "TampilData";
            TampilData.Size = new Size(300, 150);
            TampilData.TabIndex = 11;
            TampilData.TabStop = false;
            TampilData.Text = "TampilData";
            TampilData.Enter += groupBox1_Enter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(608, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 12;
            // 
            // AplikasiBiodata
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(724, 663);
            Controls.Add(textBox1);
            Controls.Add(TampilData);
            Controls.Add(button5);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "AplikasiBiodata";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AplikasiBiodata";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Label label4;
        private Button button3;
        private Label label5;
        private Button button4;
        private Label label6;
        private Button button5;
        private GroupBox TampilData;
        private TextBox textBox1;
    }
}
