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
using GunlukProgrami.Properties;

namespace GunlukProgrami
{
    public partial class GirisPaneli : Form
    {
        public GirisPaneli()
        {
            InitializeComponent();
        }

        ErrorProvider ep = new ErrorProvider();

        SqlConnection connection = new SqlConnection(
            "Data Source=DESKTOP-LDME0PG;Initial Catalog=GunlukVeriTabani;Integrated Security=True;MultipleActiveResultSets=True;"
        );

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string KullaniciAdi,
                GunlukSifresi;
            KullaniciAdi = txtKullaniciAdi.Text;
            GunlukSifresi = mtxtGunlukSifresi.Text;

            if (string.IsNullOrEmpty(KullaniciAdi) && string.IsNullOrEmpty(GunlukSifresi))
            {
                MessageBox.Show(
                    "Lütfen kullanıcı adı ve günlük şifrenizi girin!",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM KullaniciTBL WHERE kullaniciadi=@kullaniciadi AND sifre=@sifre;",
                    connection
                );
                cmd.Parameters.AddWithValue("kullaniciadi", txtKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("sifre", mtxtGunlukSifresi.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    GunlukProgrami gunlukProgrami = new GunlukProgrami();
                    gunlukProgrami.ID = Convert.ToInt32(reader[0]);
                    gunlukProgrami.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Kullanıcı adı veya günlük şifresi hatalı!\nLütfen tekrar deneyin.",
                        "Hata",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }

                connection.Close();
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string KullaniciAdi,
                GunlukSifresi;
            KullaniciAdi = txtKullaniciAdi.Text;
            GunlukSifresi = mtxtGunlukSifresi.Text;

            if (string.IsNullOrEmpty(KullaniciAdi) && string.IsNullOrEmpty(GunlukSifresi))
            {
                MessageBox.Show(
                    "Lütfen kullanıcı adı ve günlük şifrenizi girin!",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM KullaniciTBL WHERE kullaniciadi=@kullaniciadi AND sifre=@sifre;",
                    connection
                );
                cmd.Parameters.AddWithValue("kullaniciadi", txtKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("sifre", mtxtGunlukSifresi.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show(
                        "Kullanıcı adı ve günlük şifresi zaten kayıtlı!\nLütfen giriş yapmayı deneyin.",
                        "Hata",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                else
                {
                    SqlCommand command = new SqlCommand(
                        "INSERT INTO KullaniciTBL (kullaniciadi, sifre) VALUES (@kullaniciadi, @sifre);",
                        connection
                    );
                    command.Parameters.AddWithValue("kullaniciadi", txtKullaniciAdi.Text);
                    command.Parameters.AddWithValue("sifre", mtxtGunlukSifresi.Text);
                    command.ExecuteNonQuery();

                    MessageBox.Show(
                        "İşleminiz başarıyla gerçekleştirildi!\nBilgilerinizi kullanarak giriş yapabilirsiniz.",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }

                connection.Close();
            }
        }

        private void mtxtGunlukSifresi_Validating(object sender, CancelEventArgs e)
        {
            if (mtxtGunlukSifresi.Text.Length == 6)
            {
                ep.SetError(mtxtGunlukSifresi, "");
            }
            else
            {
                e.Cancel = true;
                ep.SetError(mtxtGunlukSifresi, "Günlük şifreniz 6 haneli bir sayı olmalıdır!");
            }

            if (int.TryParse(mtxtGunlukSifresi.Text, out int sonuc))
            {
                ep.SetError(mtxtGunlukSifresi, "");
            }
            else
            {
                e.Cancel = true;
                ep.SetError(mtxtGunlukSifresi, "Günlük şifreniz 6 haneli bir sayı olmalıdır!");
            }
        }

        private void GostermeDurumu_Click(object sender, EventArgs e)
        {
            if (mtxtGunlukSifresi.UseSystemPasswordChar == true)
            {
                mtxtGunlukSifresi.UseSystemPasswordChar = false;
                GostermeDurumu.Image = Resources.GizliDegil;
            }
            else
            {
                mtxtGunlukSifresi.UseSystemPasswordChar = true;
                GostermeDurumu.Image = Resources.Gizli;
            }
        }
    }
}
