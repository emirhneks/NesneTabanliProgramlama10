using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAPersonelTakipSistemi
{
    public partial class GirisPaneli : Form
    {
        public GirisPaneli()
        {
            InitializeComponent();
        }

        public bool Yonetici;

        SqlConnection connection = new SqlConnection(
            "Data Source=DESKTOP-LDME0PG;Initial Catalog=EAPersonelTakipVeriTabani;Integrated Security=True"
        );

        private void GirisPaneli_Load(object sender, EventArgs e)
        {
            if (Yonetici == true)
                gbGiris.Text = "Yönetici Girişi";
            else
                gbGiris.Text = "Personel Girişi";

            Captcha();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKod.Text == lblKod.Text)
            {
                if (Yonetici == true)
                {
                    if (txtKullaniciAdi.Text == "Admin" && txtSifre.Text == "1234")
                    {
                        MessageBox.Show(
                            "Yönlendiriliyorsunuz...",
                            "",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                        YoneticiPaneli yoneticiPaneli = new YoneticiPaneli();
                        yoneticiPaneli.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Lütfen bilgilerinizi kontrol edip tekrar deneyin!",
                            "",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        Captcha();
                        txtKod.Clear();
                    }
                }
                else
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT * FROM PersonelTBL WHERE KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre",
                        connection
                    );
                    cmd.Parameters.AddWithValue("KullaniciAdi", txtKullaniciAdi.Text);
                    cmd.Parameters.AddWithValue("Sifre", txtSifre.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (Convert.ToInt16(reader[7]) == 1)
                        {
                            MessageBox.Show(
                                "Yönlendiriliyorsunuz...",
                                "",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                            PersonelPaneli personelPaneli = new PersonelPaneli();
                            personelPaneli.txtKullaniciAdi.Text = reader[1].ToString();
                            personelPaneli.txtAd.Text = reader[2].ToString();
                            personelPaneli.txtSoyad.Text = reader[3].ToString();
                            personelPaneli.cbDepartman.Text = reader[4].ToString();
                            personelPaneli.txtSifre.Text = reader[6].ToString();
                            personelPaneli.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Sistemdeki personel durumunuz pasif!\nLütfen yöneticinizle irtibata geçiniz!",
                                "",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                            Application.Exit();
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "Lütfen bilgilerinizi kontrol edip tekrar deneyin!",
                            "",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        Captcha();
                        txtKod.Clear();
                    }
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show(
                    "Lütfen doğrulama kodunu kontrol edip tekrar deneyin!",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                Captcha();
                txtKod.Clear();
                txtKod.Focus();
            }
        }

        private void GirisPaneli_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisSecimPaneli girisSecimPaneli = new GirisSecimPaneli();
            girisSecimPaneli.Show();
            this.Hide();
        }

        internal void Captcha()
        {
            Random rand = new Random();
            int num = rand.Next(6, 8);
            string captcha = "";
            int totl = 0;
            do
            {
                int chr = rand.Next(48, 123);
                if (
                    (chr >= 48 && chr <= 57)
                    || (chr >= 65 && chr <= 90)
                    || (chr >= 97 && chr <= 122)
                )
                {
                    captcha = captcha + (char)chr;
                    totl++;
                    if (totl == num)
                        break;
                    { }
                }
            } while (true);
            lblKod.Text = captcha;
        }
    }
}
