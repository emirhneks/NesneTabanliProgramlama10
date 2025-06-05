using System;
using System.Windows.Forms;

namespace VeriGirisiDogrulama
{
    public partial class VeriGirisiDogrulama1 : Form
    {
        public VeriGirisiDogrulama1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                if (string.IsNullOrEmpty(txtKullaniciAdi.Text))
                {
                    MessageBox.Show(
                        "Kullanıcı adını giriniz.",
                        "Uyarı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }

                if (string.IsNullOrEmpty(txtSifre.Text))
                {
                    MessageBox.Show(
                        "Şifreyi giriniz.",
                        "Uyarı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            else
            {
                this.Hide();
                VeriGirisiDogrulama2 veriGirisiDogrulama2 = new VeriGirisiDogrulama2();
                veriGirisiDogrulama2.Show();
            }
        }
    }
}
