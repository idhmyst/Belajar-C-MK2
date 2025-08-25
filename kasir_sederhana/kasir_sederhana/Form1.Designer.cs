namespace kasir_sederhana
{
    partial class bground
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            makanan = new GroupBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            hargateh = new TextBox();
            hargaudang = new TextBox();
            label3 = new Label();
            nama_kasir = new TextBox();
            TOTAL = new Label();
            BAYAR = new Label();
            KEMBALI = new Label();
            Ttotal = new TextBox();
            Tbayar = new TextBox();
            Tkembali = new TextBox();
            CLEAR = new Button();
            PROSES = new Button();
            makanan.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // makanan
            // 
            makanan.Controls.Add(comboBox2);
            makanan.Controls.Add(comboBox1);
            makanan.Controls.Add(label2);
            makanan.Controls.Add(label1);
            makanan.Location = new Point(30, 29);
            makanan.Name = "makanan";
            makanan.Size = new Size(341, 150);
            makanan.TabIndex = 0;
            makanan.TabStop = false;
            makanan.Text = "makanan";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(144, 99);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 2;
            comboBox2.Text = "ES TEH";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(144, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "UDANG BAKAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 99);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 1;
            label2.Text = "Pilih Minuman";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 46);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 0;
            label1.Text = "Pilih Makanan";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(hargateh);
            groupBox1.Controls.Add(hargaudang);
            groupBox1.Location = new Point(407, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(341, 150);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Harga";
            // 
            // hargateh
            // 
            hargateh.Location = new Point(34, 99);
            hargateh.Name = "hargateh";
            hargateh.Size = new Size(150, 31);
            hargateh.TabIndex = 1;
            hargateh.Text = "5.000";
            // 
            // hargaudang
            // 
            hargaudang.Location = new Point(34, 43);
            hargaudang.Name = "hargaudang";
            hargaudang.Size = new Size(150, 31);
            hargaudang.TabIndex = 0;
            hargaudang.Text = "80.000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 219);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 2;
            label3.Text = "NAMA KASIR";
            // 
            // nama_kasir
            // 
            nama_kasir.Location = new Point(30, 262);
            nama_kasir.Name = "nama_kasir";
            nama_kasir.Size = new Size(150, 31);
            nama_kasir.TabIndex = 2;
            nama_kasir.Text = "IDHAM";
            // 
            // TOTAL
            // 
            TOTAL.AutoSize = true;
            TOTAL.Location = new Point(359, 219);
            TOTAL.Name = "TOTAL";
            TOTAL.Size = new Size(61, 25);
            TOTAL.TabIndex = 4;
            TOTAL.Text = "TOTAL";
            // 
            // BAYAR
            // 
            BAYAR.AutoSize = true;
            BAYAR.Location = new Point(359, 268);
            BAYAR.Name = "BAYAR";
            BAYAR.Size = new Size(65, 25);
            BAYAR.TabIndex = 5;
            BAYAR.Text = "BAYAR";
            BAYAR.Click += BAYAR_Click;
            // 
            // KEMBALI
            // 
            KEMBALI.AutoSize = true;
            KEMBALI.Location = new Point(359, 312);
            KEMBALI.Name = "KEMBALI";
            KEMBALI.Size = new Size(82, 25);
            KEMBALI.TabIndex = 6;
            KEMBALI.Text = "KEMBALI";
            // 
            // Ttotal
            // 
            Ttotal.Location = new Point(469, 213);
            Ttotal.Name = "Ttotal";
            Ttotal.Size = new Size(150, 31);
            Ttotal.TabIndex = 2;
            Ttotal.Text = "85.000";
            Ttotal.TextChanged += textBox1_TextChanged;
            // 
            // Tbayar
            // 
            Tbayar.Location = new Point(469, 268);
            Tbayar.Name = "Tbayar";
            Tbayar.Size = new Size(150, 31);
            Tbayar.TabIndex = 7;
            Tbayar.Text = "100.000";
            // 
            // Tkembali
            // 
            Tkembali.Location = new Point(469, 312);
            Tkembali.Name = "Tkembali";
            Tkembali.Size = new Size(150, 31);
            Tkembali.TabIndex = 8;
            Tkembali.Text = "bayar_total";
            // 
            // CLEAR
            // 
            CLEAR.Location = new Point(30, 340);
            CLEAR.Name = "CLEAR";
            CLEAR.Size = new Size(112, 34);
            CLEAR.TabIndex = 9;
            CLEAR.Text = "CLEAR";
            CLEAR.UseVisualStyleBackColor = true;
            // 
            // PROSES
            // 
            PROSES.Location = new Point(174, 340);
            PROSES.Name = "PROSES";
            PROSES.Size = new Size(112, 34);
            PROSES.TabIndex = 10;
            PROSES.Text = "PROSES";
            PROSES.UseVisualStyleBackColor = true;
            PROSES.Click += PROSES_Click;
            // 
            // bground
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(PROSES);
            Controls.Add(CLEAR);
            Controls.Add(Tkembali);
            Controls.Add(Tbayar);
            Controls.Add(Ttotal);
            Controls.Add(KEMBALI);
            Controls.Add(BAYAR);
            Controls.Add(TOTAL);
            Controls.Add(nama_kasir);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(makanan);
            Name = "bground";
            Text = "kasir_sederhana";
            makanan.ResumeLayout(false);
            makanan.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox makanan;
        private Label label1;
        private Label label2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private TextBox hargateh;
        private TextBox hargaudang;
        private Label label3;
        private TextBox nama_kasir;
        private Label TOTAL;
        private Label BAYAR;
        private Label KEMBALI;
        private TextBox Ttotal;
        private TextBox Tbayar;
        private TextBox Tkembali;
        private Button CLEAR;
        private Button PROSES;
    }
}
