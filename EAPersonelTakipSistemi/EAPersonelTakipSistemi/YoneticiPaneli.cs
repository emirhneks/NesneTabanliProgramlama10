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
    public partial class YoneticiPaneli : Form
    {
        public YoneticiPaneli()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(
            "Data Source=DESKTOP-LDME0PG;Initial Catalog=EAPersonelTakipVeriTabani;Integrated Security=True"
        );

        public int ID;

        private void YoneticiPaneli_Load(object sender, EventArgs e)
        {
            this.personelTBLTableAdapter.Fill(this.EAPersonelTakipVeriTabaniDataSet.PersonelTBL);
        }

        private void btnEkle_Click(object sender, EventArgs e)
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
                    "INSERT INTO PersonelTBL (KullaniciAdi, Ad, Soyad, Departman, Maas, Sifre, Durum) VALUES (@KullaniciAdi, @Ad, @Soyad, @Departman, @Maas, @Sifre, 1)",
                    connection
                );
                cmd.Parameters.AddWithValue("KullaniciAdi", txtKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("Ad", txtAd.Text);
                cmd.Parameters.AddWithValue("Soyad", txtSoyad.Text);
                cmd.Parameters.AddWithValue("Departman", cbDepartman.Text);
                cmd.Parameters.AddWithValue("Maas", Convert.ToInt32(nudMaas.Value));
                cmd.Parameters.AddWithValue("Sifre", txtSifre.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(
                    "İşleminiz başarıyla gerçekleştirildi!",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.personelTBLTableAdapter.Fill(
                    this.EAPersonelTakipVeriTabaniDataSet.PersonelTBL
                );
            }
        }

        private void btnCikart_Click(object sender, EventArgs e)
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
                    "UPDATE PersonelTBL SET Durum=0 WHERE ID=@ID",
                    connection
                );
                cmd.Parameters.AddWithValue("ID", ID);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(
                    "İşleminiz başarıyla gerçekleştirildi!",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.personelTBLTableAdapter.Fill(
                    this.EAPersonelTakipVeriTabaniDataSet.PersonelTBL
                );
            }
        }

        private void btnGeriAl_Click(object sender, EventArgs e)
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
                    "UPDATE PersonelTBL SET Durum=1 WHERE ID=@ID",
                    connection
                );
                cmd.Parameters.AddWithValue("ID", ID);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(
                    "İşleminiz başarıyla gerçekleştirildi!",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.personelTBLTableAdapter.Fill(
                    this.EAPersonelTakipVeriTabaniDataSet.PersonelTBL
                );
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
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
                SqlCommand cmd = new SqlCommand("DELETE FROM PersonelTBL WHERE ID=@ID", connection);
                cmd.Parameters.AddWithValue("ID", ID);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(
                    "İşleminiz başarıyla gerçekleştirildi!",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.personelTBLTableAdapter.Fill(
                    this.EAPersonelTakipVeriTabaniDataSet.PersonelTBL
                );
            }
        }

        private void PersonelListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = PersonelListesi.SelectedCells[0].RowIndex;
            ID = Convert.ToInt32(PersonelListesi.Rows[secilen].Cells[0].Value.ToString());
            txtKullaniciAdi.Text = PersonelListesi.Rows[secilen].Cells[1].Value.ToString();
            txtAd.Text = PersonelListesi.Rows[secilen].Cells[2].Value.ToString();
            txtSoyad.Text = PersonelListesi.Rows[secilen].Cells[3].Value.ToString();
            cbDepartman.Text = PersonelListesi.Rows[secilen].Cells[4].Value.ToString();
            nudMaas.Value = Convert.ToDecimal(PersonelListesi.Rows[secilen].Cells[5].Value);
            txtSifre.Text = PersonelListesi.Rows[secilen].Cells[6].Value.ToString();
        }

        private void YoneticiPaneli_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
