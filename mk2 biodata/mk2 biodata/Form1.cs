namespace mk2_biodata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string tampilData =
                " Nama Saya : " + txtBoxNama.Text +
                "\n alamat Saya : " + txtBoxAlamat.Text +
                "\n Kelas Saya : " + txtBoxKelas.Text;

            if (rbLaki.Checked)
                tampilData += " \n Jenis Kelamin = Laki - Laki";
            else if (rbWanita.Checked)
                tampilData += " \n Jenis Kelamin = Perempuan";
            else
                tampilData += " \n Silahkan Isi jenis kelamin";

            tampildata.Text = tampilData;

            string hoby = " ";
            if (cbRenang.Checked)
                hoby += "hoby: renang";
            if (cbLari.Checked)
                hoby += "\n hoby: lari";

            if (!string.IsNullOrEmpty(hoby))
                tampilData += "\n " + hoby.TrimEnd(',', ',');
            else
                tampilData += "\n hoby belum dipilih!";

            tampildata.Text = tampilData;
        }
    }
}
