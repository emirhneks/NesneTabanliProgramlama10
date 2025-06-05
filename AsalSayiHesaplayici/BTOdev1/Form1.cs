using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTOdev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ListeleButonu_Click(object sender, EventArgs e)
        {
            try
            {
                AsalSayilarListesi.Items.Clear();

                int sayi1,
                    sayi2;
                sayi1 = Convert.ToInt32(Sayi1.Text);
                sayi2 = Convert.ToInt32(Sayi2.Text);

                int sayi = sayi1;
                bool asal = true;

                while (sayi < sayi2)
                {
                    sayi++;
                    for (int i = 2; i < sayi; i++)
                    {
                        if (sayi % i == 0)
                        {
                            asal = false;
                        }
                    }
                    if (asal == true && sayi != 1)
                    {
                        AsalSayilarListesi.Items.Add(sayi.ToString());
                    }
                    asal = true;
                }
                Label2.Text =
                    "İki Sayı Arasında "
                    + AsalSayilarListesi.Items.Count.ToString()
                    + " Asal Sayı Vardır";
            }
            catch
            {
                DialogResult Sonuc = MessageBox.Show(
                    "Bir Sorun Oluştu!",
                    "Hata",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error
                );
                if (Sonuc == DialogResult.Cancel)
                    Application.Exit();
            }
        }

        private void TemizleButonu_Click(object sender, EventArgs e)
        {
            Sayi1.Clear();
            Sayi2.Clear();
            AsalSayilarListesi.Items.Clear();
            Label2.Text = "";
            Sayi1.Focus();
        }

        private void CikisYapButonu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
