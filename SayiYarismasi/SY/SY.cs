using System;
using System.Windows.Forms;

namespace SY
{
    public partial class SY : Form
    {
        public SY()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int olusturulanSayi;
        int sure;
        int skor;

        private void SY_Load(object sender, EventArgs e)
        {
            olusturulanSayi = rnd.Next(0, 10);
            label1.Text = olusturulanSayi.ToString();
            sure = Convert.ToInt32(ayarlananSure.Text);
            label2.Text = sure.ToString() + " sn.";
            zamanlayici1.Start();
        }

        public void SayiKontrol(int girilenSayi)
        {
            if (girilenSayi == olusturulanSayi)
            {
                skor++;
                Sifirla(false);
            }
            else
                Kaybetme();
        }

        public void Kaybetme()
        {
            zamanlayici1.Stop();
            DialogResult secim = MessageBox.Show(
                "Skorunuz: " + skor.ToString() + "\nNe yapmak istersiniz?",
                "Kaybetme!",
                MessageBoxButtons.RetryCancel
            );
            if (secim == DialogResult.Retry)
                Sifirla(true);
            else
            {
                Seviye_Secimi ss = new Seviye_Secimi();
                ss.Show();
                this.Hide();
            }
        }

        public void Sifirla(bool SkorIle)
        {
            zamanlayici1.Stop();
            olusturulanSayi = rnd.Next(0, 10);
            label1.Text = olusturulanSayi.ToString();
            sure = Convert.ToInt32(ayarlananSure.Text);
            label2.Text = sure.ToString() + " sn.";
            if (SkorIle)
                skor = 0;
            zamanlayici1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SayiKontrol(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SayiKontrol(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SayiKontrol(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SayiKontrol(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SayiKontrol(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SayiKontrol(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SayiKontrol(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SayiKontrol(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SayiKontrol(9);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            SayiKontrol(0);
        }

        private void buttonx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zamanlayici1_Tick(object sender, EventArgs e)
        {
            sure--;
            label2.Text = sure.ToString() + " sn.";
            if (sure == 0)
                Kaybetme();
        }
    }
}
