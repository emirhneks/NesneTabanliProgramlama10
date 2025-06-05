using System;
using System.Windows.Forms;

namespace KSGKutuphane
{
    public partial class formAnaSayfa : Form
    {
        public formAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnKitap_Click_1(object sender, EventArgs e)
        {
            formKitap kitap = new formKitap();
            kitap.Show();

            this.Hide();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            formOgrenci ogrenci = new formOgrenci();
            ogrenci.Show();

            this.Hide();
        }

        private void btnTur_Click(object sender, EventArgs e)
        {
            formKitapTur kitapTur = new formKitapTur();
            kitapTur.Show();

            this.Hide();
        }

        private void btnOdunc_Click(object sender, EventArgs e)
        {
            formOduncKitap odunckitap = new formOduncKitap();
            odunckitap.Show();

            this.Hide();
        }

        private void formAnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
