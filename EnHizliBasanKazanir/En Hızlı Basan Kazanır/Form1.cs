using System;
using System.Windows.Forms;

namespace En_Hızlı_Basan_Kazanır
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int A;
        public static int D;

        public static int BitisSayisi = 50;

        public static bool Bitti = false;

        public void Sifirla(bool Durdur)
        {
            DialogResult result = MessageBox.Show(
                "Oyunu sıfırlamak istiyor musunuz?",
                "Sıfırlama",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                A = 0;
                Para1.Text = A.ToString();
                D = 0;
                Para2.Text = D.ToString();
                Bitti = false;
            }
            else if (Durdur)
                Bitti = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Bitti)
            {
                if (e.KeyCode == Keys.A)
                {
                    A++;
                    Para1.Text = A.ToString();
                    if (A == BitisSayisi)
                    {
                        MessageBox.Show("Klavye Tuşu (A) Kazandı!", "Kazanan...");
                        Sifirla(true);
                    }
                }

                if (e.KeyCode == Keys.D)
                {
                    D++;
                    Para2.Text = D.ToString();
                    if (D == BitisSayisi)
                    {
                        MessageBox.Show("Klavye Tuşu (D) Kazandı!", "Kazanan...");
                        Sifirla(true);
                    }
                }
            }
        }

        private void SifirlaTusu_Click(object sender, EventArgs e)
        {
            Sifirla(false);
        }

        private void KapatTusu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
