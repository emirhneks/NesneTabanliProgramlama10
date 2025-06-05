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
    public partial class PersonelPaneli : Form
    {
        public PersonelPaneli()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(
            "Data Source=DESKTOP-LDME0PG;Initial Catalog=EAPersonelTakipVeriTabani;Integrated Security=True"
        );

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(txtKullaniciAdi.Text)
                && string.IsNullOrEmpty(txtAd.Text)
                && string.IsNullOrEmpty(txtSoyad.Text)
                && string.IsNullOrEmpty(cbDepartman.Text)
                && string.IsNullOrEmpty(txtSifre.Text)
            )
            {
                MessageBox.Show(
                    "Lütfen bilgilerin doluluğunu kontrol edip tekrar deneyin!",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE PersonelTBL SET KullaniciAdi=@KullaniciAdi, Ad=@Ad, Soyad=@Soyad, Departman=@Departman, Sifre=@Sifre",
                    connection
                );
                cmd.Parameters.AddWithValue("KullaniciAdi", txtKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("Ad", txtAd.Text);
                cmd.Parameters.AddWithValue("Soyad", txtSoyad.Text);
                cmd.Parameters.AddWithValue("Departman", cbDepartman.Text);
                cmd.Parameters.AddWithValue("Sifre", txtSifre.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(
                    "İşleminiz başarıyla gerçekleştirildi!",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void PersonelPaneli_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
