using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çark_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int Kredi = 3000;
        public static int SRenk;
        public static int SKredi;
        Random rnd = new Random();
        public static int GRenk;

        private void Form1_Load(object sender, EventArgs e)
        {
            KrediMiktari.Text = Kredi.ToString();
        }

        public void RenkSecim(bool Acik)
        {
            if (Acik == true)
            {
                Secilebilir1.Enabled = true;
                Secilebilir2.Enabled = true;
                Secilebilir3.Enabled = true;
                Secilebilir4.Enabled = true;
                Secilebilir5.Enabled = true;
                Secilebilir6.Enabled = true;
                Secilebilir7.Enabled = true;
                Secilebilir8.Enabled = true;
                Secilebilir9.Enabled = true;
                Secilebilir10.Enabled = true;
                Secilebilir11.Enabled = true;
                Secilebilir12.Enabled = true;
                Secilebilir13.Enabled = true;
                Secilebilir14.Enabled = true;
                Secilebilir15.Enabled = true;
                Secilebilir16.Enabled = true;
            }
            else
            {
                Secilebilir1.Enabled = false;
                Secilebilir2.Enabled = false;
                Secilebilir3.Enabled = false;
                Secilebilir4.Enabled = false;
                Secilebilir5.Enabled = false;
                Secilebilir6.Enabled = false;
                Secilebilir7.Enabled = false;
                Secilebilir8.Enabled = false;
                Secilebilir9.Enabled = false;
                Secilebilir10.Enabled = false;
                Secilebilir11.Enabled = false;
                Secilebilir12.Enabled = false;
                Secilebilir13.Enabled = false;
                Secilebilir14.Enabled = false;
                Secilebilir15.Enabled = false;
                Secilebilir16.Enabled = false;
            }
        }

        public void KrediSecim(bool Acik)
        {
            if (Acik == true)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
            }
        }

        public void KoordinatDegistir(int Renk)
        {
            if (Renk == 1)
            {
                RenkSecici.Location = new Point(Renk1.Location.X, Renk1.Location.Y);
                RenkSecici.BackColor = Color.Silver;
            }
            if (Renk == 2)
            {
                RenkSecici.Location = new Point(Renk2.Location.X, Renk2.Location.Y);
                RenkSecici.BackColor = Color.Gray;
            }
            if (Renk == 3)
            {
                RenkSecici.Location = new Point(Renk3.Location.X, Renk3.Location.Y);
                RenkSecici.BackColor = Color.Black;
            }
            if (Renk == 4)
            {
                RenkSecici.Location = new Point(Renk4.Location.X, Renk4.Location.Y);
                RenkSecici.BackColor = Color.Red;
            }
            if (Renk == 5)
            {
                RenkSecici.Location = new Point(Renk5.Location.X, Renk5.Location.Y);
                RenkSecici.BackColor = Color.Maroon;
            }
            if (Renk == 6)
            {
                RenkSecici.Location = new Point(Renk6.Location.X, Renk6.Location.Y);
                RenkSecici.BackColor = Color.Yellow;
            }
            if (Renk == 7)
            {
                RenkSecici.Location = new Point(Renk7.Location.X, Renk7.Location.Y);
                RenkSecici.BackColor = Color.Olive;
            }
            if (Renk == 8)
            {
                RenkSecici.Location = new Point(Renk8.Location.X, Renk8.Location.Y);
                RenkSecici.BackColor = Color.Lime;
            }
            if (Renk == 9)
            {
                RenkSecici.Location = new Point(Renk9.Location.X, Renk9.Location.Y);
                RenkSecici.BackColor = Color.Green;
            }
            if (Renk == 10)
            {
                RenkSecici.Location = new Point(Renk10.Location.X, Renk10.Location.Y);
                RenkSecici.BackColor = Color.Cyan;
            }
            if (Renk == 11)
            {
                RenkSecici.Location = new Point(Renk11.Location.X, Renk11.Location.Y);
                RenkSecici.BackColor = Color.Teal;
            }
            if (Renk == 12)
            {
                RenkSecici.Location = new Point(Renk12.Location.X, Renk12.Location.Y);
                RenkSecici.BackColor = Color.Blue;
            }
            if (Renk == 13)
            {
                RenkSecici.Location = new Point(Renk13.Location.X, Renk13.Location.Y);
                RenkSecici.BackColor = Color.Navy;
            }
            if (Renk == 14)
            {
                RenkSecici.Location = new Point(Renk14.Location.X, Renk14.Location.Y);
                RenkSecici.BackColor = Color.Fuchsia;
            }
            if (Renk == 15)
            {
                RenkSecici.Location = new Point(Renk15.Location.X, Renk15.Location.Y);
                RenkSecici.BackColor = Color.Purple;
            }
            if (Renk == 16)
            {
                RenkSecici.Location = new Point(Renk16.Location.X, Renk16.Location.Y);
                RenkSecici.BackColor = Color.White;
            }
        }

        private void Secilebilir1_Click(object sender, EventArgs e)
        {
            SRenk = 1;
            SecilenRenk.Text = "Gümüş";
            KrediSecim(true);
        }

        private void Secilebilir2_Click(object sender, EventArgs e)
        {
            SRenk = 2;
            SecilenRenk.Text = "Gri";
            KrediSecim(true);
        }

        private void Secilebilir3_Click(object sender, EventArgs e)
        {
            SRenk = 3;
            SecilenRenk.Text = "Siyah";
            KrediSecim(true);
        }

        private void Secilebilir4_Click(object sender, EventArgs e)
        {
            SRenk = 4;
            SecilenRenk.Text = "Kırmızı";
            KrediSecim(true);
        }

        private void Secilebilir5_Click(object sender, EventArgs e)
        {
            SRenk = 5;
            SecilenRenk.Text = "Bordo";
            KrediSecim(true);
        }

        private void Secilebilir6_Click(object sender, EventArgs e)
        {
            SRenk = 6;
            SecilenRenk.Text = "Sarı";
            KrediSecim(true);
        }

        private void Secilebilir7_Click(object sender, EventArgs e)
        {
            SRenk = 7;
            SecilenRenk.Text = "Zeytin";
            KrediSecim(true);
        }

        private void Secilebilir8_Click(object sender, EventArgs e)
        {
            SRenk = 8;
            SecilenRenk.Text = "Limon Yeşili";
            KrediSecim(true);
        }

        private void Secilebilir9_Click(object sender, EventArgs e)
        {
            SRenk = 9;
            SecilenRenk.Text = "Yeşil";
            KrediSecim(true);
        }

        private void Secilebilir10_Click(object sender, EventArgs e)
        {
            SRenk = 10;
            SecilenRenk.Text = "Camgöbeği";
            KrediSecim(true);
        }

        private void Secilebilir11_Click(object sender, EventArgs e)
        {
            SRenk = 11;
            SecilenRenk.Text = "Turkuaz";
            KrediSecim(true);
        }

        private void Secilebilir12_Click(object sender, EventArgs e)
        {
            SRenk = 12;
            SecilenRenk.Text = "Mavi";
            KrediSecim(true);
        }

        private void Secilebilir13_Click(object sender, EventArgs e)
        {
            SRenk = 13;
            SecilenRenk.Text = "Lacivert";
            KrediSecim(true);
        }

        private void Secilebilir14_Click(object sender, EventArgs e)
        {
            SRenk = 14;
            SecilenRenk.Text = "Fuşya";
            KrediSecim(true);
        }

        private void Secilebilir15_Click(object sender, EventArgs e)
        {
            SRenk = 15;
            SecilenRenk.Text = "Mor";
            KrediSecim(true);
        }

        private void Secilebilir16_Click(object sender, EventArgs e)
        {
            SRenk = 16;
            SecilenRenk.Text = "Beyaz";
            KrediSecim(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SKredi = 100;
            SecilenKredi.Text = SKredi.ToString();
            CarkCevir.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SKredi = 200;
            SecilenKredi.Text = SKredi.ToString();
            CarkCevir.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SKredi = 300;
            SecilenKredi.Text = SKredi.ToString();
            CarkCevir.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SKredi = 400;
            SecilenKredi.Text = SKredi.ToString();
            CarkCevir.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SKredi = 500;
            SecilenKredi.Text = SKredi.ToString();
            CarkCevir.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SKredi = 600;
            SecilenKredi.Text = SKredi.ToString();
            CarkCevir.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SKredi = 700;
            SecilenKredi.Text = SKredi.ToString();
            CarkCevir.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SKredi = 800;
            SecilenKredi.Text = SKredi.ToString();
            CarkCevir.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SKredi = 900;
            SecilenKredi.Text = SKredi.ToString();
            CarkCevir.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SKredi = 1000;
            SecilenKredi.Text = SKredi.ToString();
            CarkCevir.Enabled = true;
        }

        private async void CarkCevir_Click(object sender, EventArgs e)
        {
            if (Kredi < SKredi)
            {
                MessageBox.Show(
                    "Kredi miktarınız yetersiz!",
                    "Kredi Durumu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                RenkSecici.Visible = true;
                RenkSecim(false);
                KrediSecim(false);
                CarkCevir.Enabled = false;
                GRenk = rnd.Next(1, 17);
                int TurSayisi = 0;
                int ArtanSayi = 1;
                for (int i = 1; i <= GRenk; )
                {
                    if (TurSayisi < 3)
                    {
                        KoordinatDegistir(ArtanSayi);
                        ArtanSayi++;
                        if (ArtanSayi > 16)
                        {
                            TurSayisi++;
                            ArtanSayi = 1;
                        }
                    }
                    else
                    {
                        KoordinatDegistir(i);
                        i++;
                    }
                    await Task.Delay(100);
                }
                if (SRenk != GRenk)
                {
                    MessageBox.Show(
                        "-" + SKredi.ToString() + " kredi kaybettiniz!",
                        "Kredi Durumu",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    KrediDurum.Visible = true;
                    KrediDurum.ForeColor = Color.Red;
                    KrediDurum.Text = "-" + SKredi.ToString();
                    await Task.Delay(1000);
                    KrediDurum.Visible = false;
                    Kredi -= SKredi;
                    KrediMiktari.Text = Kredi.ToString();
                }
                else
                {
                    MessageBox.Show(
                        "+" + SKredi.ToString() + " kredi kazandınız!",
                        "Kredi Durumu",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    KrediDurum.Visible = true;
                    KrediDurum.ForeColor = Color.Green;
                    KrediDurum.Text = "+" + SKredi.ToString();
                    await Task.Delay(1000);
                    KrediDurum.Visible = false;
                    Kredi += SKredi;
                    KrediMiktari.Text = Kredi.ToString();
                }
                RenkSecici.Visible = false;
                RenkSecim(true);
                SecilenRenk.Text = "?";
                KrediSecim(false);
                SecilenKredi.Text = "?";
                CarkCevir.Enabled = false;
                GRenk = rnd.Next(1, 17);
            }
        }

        private void KapatTusu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
