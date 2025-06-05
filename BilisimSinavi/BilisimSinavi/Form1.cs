using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilisimSinavi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciadi,
                sifre;
            kullaniciadi = txtKullaniciAdi.Text;
            sifre = txtSifre.Text;
            for (int i = 0; i < 10; i++)
            {
                progressBar1.Value += 10;
                await Task.Delay(100);
            }
            if (kullaniciadi == "Admin" && sifre == "1234")
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Kullanıcı adı veya şifre hatalı!",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                progressBar1.Value = 0;
            }
        }
    }
}
