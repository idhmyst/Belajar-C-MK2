namespace mk2_biodata
{
    partial class Form1
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
            nm = new Label();
            kls = new Label();
            almt = new Label();
            label4 = new Label();
            txtBoxNama = new TextBox();
            txtBoxKelas = new TextBox();
            txtBoxAlamat = new TextBox();
            rbLaki = new RadioButton();
            rbWanita = new RadioButton();
            cbRenang = new CheckBox();
            hoby = new Label();
            cbLari = new CheckBox();
            tampildata = new GroupBox();
            btnOk = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // nm
            // 
            nm.AutoSize = true;
            nm.Location = new Point(115, 50);
            nm.Name = "nm";
            nm.Size = new Size(68, 25);
            nm.TabIndex = 0;
            nm.Text = "Nama :";
            // 
            // kls
            // 
            kls.AutoSize = true;
            kls.Location = new Point(115, 102);
            kls.Name = "kls";
            kls.Size = new Size(61, 25);
            kls.TabIndex = 1;
            kls.Text = "Kelas :";
            kls.Click += label2_Click;
            // 
            // almt
            // 
            almt.AutoSize = true;
            almt.Location = new Point(115, 149);
            almt.Name = "almt";
            almt.Size = new Size(77, 25);
            almt.TabIndex = 2;
            almt.Text = "Alamat :";
            almt.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 228);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 3;
            label4.Text = "Gender :";
            // 
            // txtBoxNama
            // 
            txtBoxNama.Location = new Point(226, 50);
            txtBoxNama.Name = "txtBoxNama";
            txtBoxNama.Size = new Size(150, 31);
            txtBoxNama.TabIndex = 4;
            // 
            // txtBoxKelas
            // 
            txtBoxKelas.Location = new Point(226, 102);
            txtBoxKelas.Name = "txtBoxKelas";
            txtBoxKelas.Size = new Size(150, 31);
            txtBoxKelas.TabIndex = 5;
            // 
            // txtBoxAlamat
            // 
            txtBoxAlamat.Location = new Point(226, 149);
            txtBoxAlamat.Multiline = true;
            txtBoxAlamat.Name = "txtBoxAlamat";
            txtBoxAlamat.Size = new Size(150, 72);
            txtBoxAlamat.TabIndex = 6;
            // 
            // rbLaki
            // 
            rbLaki.AutoSize = true;
            rbLaki.Location = new Point(122, 266);
            rbLaki.Name = "rbLaki";
            rbLaki.Size = new Size(67, 29);
            rbLaki.TabIndex = 7;
            rbLaki.TabStop = true;
            rbLaki.Text = "Laki";
            rbLaki.UseVisualStyleBackColor = true;
            // 
            // rbWanita
            // 
            rbWanita.AutoSize = true;
            rbWanita.Location = new Point(122, 317);
            rbWanita.Name = "rbWanita";
            rbWanita.Size = new Size(91, 29);
            rbWanita.TabIndex = 8;
            rbWanita.TabStop = true;
            rbWanita.Text = "Wanita";
            rbWanita.UseVisualStyleBackColor = true;
            rbWanita.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // cbRenang
            // 
            cbRenang.AutoSize = true;
            cbRenang.Location = new Point(328, 267);
            cbRenang.Name = "cbRenang";
            cbRenang.Size = new Size(97, 29);
            cbRenang.TabIndex = 9;
            cbRenang.Text = "Renang";
            cbRenang.UseVisualStyleBackColor = true;
            // 
            // hoby
            // 
            hoby.AutoSize = true;
            hoby.Location = new Point(310, 228);
            hoby.Name = "hoby";
            hoby.Size = new Size(65, 25);
            hoby.TabIndex = 10;
            hoby.Text = "Hoby :";
            // 
            // cbLari
            // 
            cbLari.AutoSize = true;
            cbLari.Location = new Point(328, 318);
            cbLari.Name = "cbLari";
            cbLari.Size = new Size(65, 29);
            cbLari.TabIndex = 11;
            cbLari.Text = "Lari";
            cbLari.UseVisualStyleBackColor = true;
            // 
            // tampildata
            // 
            tampildata.Location = new Point(415, 109);
            tampildata.Name = "tampildata";
            tampildata.Size = new Size(300, 150);
            tampildata.TabIndex = 12;
            tampildata.TabStop = false;
            tampildata.Text = "tampildata";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(439, 345);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(112, 34);
            btnOk.TabIndex = 13;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(585, 345);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 14;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnOk);
            Controls.Add(tampildata);
            Controls.Add(cbLari);
            Controls.Add(hoby);
            Controls.Add(cbRenang);
            Controls.Add(rbWanita);
            Controls.Add(rbLaki);
            Controls.Add(txtBoxAlamat);
            Controls.Add(txtBoxKelas);
            Controls.Add(txtBoxNama);
            Controls.Add(label4);
            Controls.Add(almt);
            Controls.Add(kls);
            Controls.Add(nm);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nm;
        private Label kls;
        private Label almt;
        private Label label4;
        private TextBox txtBoxNama;
        private TextBox txtBoxKelas;
        private TextBox txtBoxAlamat;
        private RadioButton rbLaki;
        private RadioButton rbWanita;
        private CheckBox cbRenang;
        private Label hoby;
        private CheckBox cbLari;
        private GroupBox tampildata;
        private Button btnOk;
        private Button btnClear;
    }
}
