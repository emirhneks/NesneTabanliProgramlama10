using System;
using System.Windows.Forms;

namespace BilisimSinavi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int fiyat;

        int oto1fiyat = 150;
        int oto2fiyat = 200;
        int manuel1fiyat = 200;
        int manuel2fiyat = 250;

        private void Form2_Load(object sender, EventArgs e)
        {
            rtxtSiparisOzeti.AppendText("Sayın ");
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Binding binding = new Binding("Text", txtAdSoyad, "Text");
            vbAdSoyad.DataBindings.Add(binding);
            Binding binding1 = new Binding("Text", mtxtCepNo, "Text");
            vbCepNo.DataBindings.Add(binding1);
            Binding binding2 = new Binding("Text", mtxtDogumTarihi, "Text");
            vbDogumTarihi.DataBindings.Add(binding2);
            Binding binding3 = new Binding("Text", mtxtEhliyetVerilisTarihi, "Text");
            vbEhliyetVerilisTarihi.DataBindings.Add(binding3);

            gbBilgileriniz.Visible = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Bilgileriniz kaydediliyor... Onaylıyor musunuz?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(
                    "Bilgileriniz başarıyla kaydedildi!",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                rtxtSiparisOzeti.AppendText(
                    txtAdSoyad.Text + ",\nCep No: " + mtxtCepNo.Text + "\n\n"
                );
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (oto1.Checked || oto2.Checked)
            {
                manuel1.Checked = false;
                manuel2.Checked = false;

                if (oto1.Checked)
                {
                    rtxtSiparisOzeti.AppendText(
                        "• Oto Araç 1 - "
                            + oto1fiyat * Convert.ToInt32(cbKiraGunSayisi.Text)
                            + " TL\n"
                    );
                    fiyat += oto1fiyat * Convert.ToInt32(cbKiraGunSayisi.Text);
                }
                if (oto2.Checked)
                {
                    rtxtSiparisOzeti.AppendText(
                        "• Oto Araç 2 - "
                            + oto2fiyat * Convert.ToInt32(cbKiraGunSayisi.Text)
                            + " TL\n"
                    );
                    fiyat += oto2fiyat * Convert.ToInt32(cbKiraGunSayisi.Text);
                    ;
                }
            }
        }

        private void btnOnayla1_Click(object sender, EventArgs e)
        {
            if (manuel1.Checked || manuel2.Checked)
            {
                oto1.Checked = false;
                oto2.Checked = false;

                if (manuel1.Checked)
                {
                    rtxtSiparisOzeti.AppendText(
                        "• Manuel Araç 1 - "
                            + manuel1fiyat * Convert.ToInt32(cbKiraGunSayisi.Text)
                            + " TL\n"
                    );
                    fiyat += manuel1fiyat * Convert.ToInt32(cbKiraGunSayisi.Text);
                }
                if (manuel2.Checked)
                {
                    rtxtSiparisOzeti.AppendText(
                        "• Manuel Araç 2 - "
                            + manuel2fiyat * Convert.ToInt32(cbKiraGunSayisi.Text)
                            + " TL\n"
                    );
                    fiyat += manuel2fiyat * Convert.ToInt32(cbKiraGunSayisi.Text);
                }
            }
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                fiyat + " TL ödeme yapılacaktır... Onaylıyor musunuz?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(
                    "Kartınızdan " + fiyat + " TL işlem yapılmıştır.",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                btnYazdir.Visible = true;
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            Class1.RichTextBox = rtxtSiparisOzeti;

            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
