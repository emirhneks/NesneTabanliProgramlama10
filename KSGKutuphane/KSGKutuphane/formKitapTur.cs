using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KSGKutuphane
{
    public partial class formKitapTur : Form
    {
        public formKitapTur()
        {
            InitializeComponent();
        }

        VeriTabaniIslemleri vtIslemleri = new VeriTabaniIslemleri();
        SqlConnection baglanti;
        SqlCommand komut;
        string komutSatiri;

        private void formKitapTur_Load(object sender, EventArgs e)
        {
            TurleriListele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();
                komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO kitap_turleri (tur_adi) VALUES (@tur_adi);";
                komut.Parameters.AddWithValue("@tur_adi", txtTurAdi.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                txtTurAdi.Clear();
                MessageBox.Show(
                    "İşlem başarılı",
                    "Mesaj",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                );
                TurleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Hata Oluştu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();
                komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "DELETE FROM kitap_turleri WHERE tur_id = @tur_id;";
                komut.Parameters.AddWithValue(
                    "@tur_id",
                    gridKitapTur.CurrentRow.Cells["tur_id"].Value.ToString()
                );
                komut.ExecuteNonQuery();
                baglanti.Close();
                txtTurAdi.Clear();
                MessageBox.Show(
                    "İşlem başarılı",
                    "Mesaj",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                );
                TurleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Hata Oluştu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();
                komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText =
                    "UPDATE kitap_turleri SET tur_adi = @tur_adi WHERE tur_id = @tur_id;";
                komut.Parameters.AddWithValue(
                    "@tur_id",
                    int.Parse(gridKitapTur.CurrentRow.Cells["tur_id"].Value.ToString())
                );
                komut.Parameters.AddWithValue("@tur_adi", txtTurAdi.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                txtTurAdi.Clear();
                MessageBox.Show(
                    "İşlem başarılı",
                    "Mesaj",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                );
                TurleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Hata Oluştu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void gridKitapTur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtTurAdi.Text = gridKitapTur.CurrentRow.Cells["tur_adi"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Hata Oluştu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void formKitapTur_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAnaSayfa anaSayfa = new formAnaSayfa();
            anaSayfa.Show();

            this.Hide();
        }

        public void TurleriListele()
        {
            try
            {
                baglanti = vtIslemleri.baglan();
                komutSatiri = "SELECT * FROM kitap_turleri;";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                gridKitapTur.DataSource = dataTable;
                gridKitapTur.Columns["tur_id"].HeaderText = "ID";
                gridKitapTur.Columns["tur_id"].Width = 50;
                gridKitapTur.Columns["tur_adi"].HeaderText = "Tür Adı";
                gridKitapTur.Columns["tur_adi"].Width = 150;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Hata Oluştu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
