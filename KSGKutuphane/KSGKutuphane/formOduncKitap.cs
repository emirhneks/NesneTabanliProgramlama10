using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KSGKutuphane
{
    public partial class formOduncKitap : Form
    {
        public formOduncKitap()
        {
            InitializeComponent();
        }

        VeriTabaniIslemleri vtIslemleri = new VeriTabaniIslemleri();
        SqlConnection baglanti;
        SqlCommand komut;
        string komutSatiri;

        private void formOduncKitap_Load(object sender, EventArgs e)
        {
            Listele();
            KitapYukle();
        }

        private void txtAramaOgrenci_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();
                komutSatiri =
                    "SELECT id, ogrenci_no, ad, soyad, kitap_adi, verilis_tarihi, teslim_tarihi, aciklama FROM kitaplar, ogrenciler, odunc_kitaplar WHERE ogr_no = ogrenci_no AND kitaplar.kitap_id = odunc_kitaplar.kitap_id AND ad LIKE '"
                    + txtAramaOgrenci.Text
                    + "%';";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                gridOduncKitaplar.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Hata oluştu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnKitapVer_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();
                komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText =
                    "INSERT INTO odunc_kitaplar (ogr_no, kitap_id, verilis_tarihi, aciklama) VALUES (@ogr_no, @kitap_id, @verilis_tarihi, @aciklama);";
                komut.Parameters.AddWithValue("@ogr_no", int.Parse(txtNo.Text));
                komut.Parameters.AddWithValue(
                    "@kitap_id",
                    int.Parse(comboKitap.SelectedValue.ToString())
                );
                komut.Parameters.AddWithValue(
                    "@verilis_tarihi",
                    DateTime.Now.ToString("yyyy/MM/dd")
                );
                komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                KitapYukle();
                Listele();
                MessageBox.Show(
                    "İşlem başarılı",
                    "Mesaj",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Hata oluştu",
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
                komut.CommandText = "DELETE FROM odunc_kitaplar WHERE id = @id;";
                komut.Parameters.AddWithValue(
                    "@id",
                    gridOduncKitaplar.CurrentRow.Cells["id"].Value.ToString()
                );
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                KitapYukle();
                Listele();
                MessageBox.Show(
                    "İşlem başarılı",
                    "Mesaj",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Hata oluştu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnKitapAl_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    gridOduncKitaplar.CurrentRow.Cells["teslim_tarihi"].Value.ToString()
                    != String.Empty
                )
                {
                    MessageBox.Show(
                        "Bu kitap teslim alınmış",
                        "Uyarı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();
                komutSatiri =
                    "UPDATE odunc_kitaplar SET teslim_tarihi = @teslim_tarihi, aciklama = @aciklama WHERE id = @id;";
                komut = new SqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue(
                    "@id",
                    int.Parse(gridOduncKitaplar.CurrentRow.Cells["id"].Value.ToString())
                );
                komut.Parameters.AddWithValue(
                    "@teslim_tarihi",
                    DateTime.Now.ToString("yyyy/MM/dd")
                );
                komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                KitapYukle();
                Listele();
                MessageBox.Show(
                    "İşlem başarılı",
                    "Mesaj",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Hata oluştu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void gridOduncKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtAciklama.Text = gridOduncKitaplar.CurrentRow.Cells["aciklama"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Hata oluştu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void formOduncKitap_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAnaSayfa anaSayfa = new formAnaSayfa();
            anaSayfa.Show();

            this.Hide();
        }

        public void Listele()
        {
            try
            {
                baglanti = vtIslemleri.baglan();
                komutSatiri =
                    "SELECT id, ogrenci_no, ad, soyad, kitap_adi, verilis_tarihi, teslim_tarihi, aciklama FROM kitaplar, ogrenciler, odunc_kitaplar WHERE ogr_no = ogrenci_no AND kitaplar.kitap_id = odunc_kitaplar.kitap_id;";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                gridOduncKitaplar.DataSource = dataTable;
                gridOduncKitaplar.Columns["id"].HeaderText = "ID";
                gridOduncKitaplar.Columns["id"].Width = 30;
                gridOduncKitaplar.Columns["ogrenci_no"].HeaderText = "Öğrenci No";
                gridOduncKitaplar.Columns["ogrenci_no"].Width = 60;
                gridOduncKitaplar.Columns["ad"].HeaderText = "Ad";
                gridOduncKitaplar.Columns["ad"].Width = 70;
                gridOduncKitaplar.Columns["soyad"].HeaderText = "Soyad";
                gridOduncKitaplar.Columns["soyad"].Width = 70;
                gridOduncKitaplar.Columns["kitap_adi"].HeaderText = "Kitap Adı";
                gridOduncKitaplar.Columns["kitap_adi"].Width = 100;
                gridOduncKitaplar.Columns["verilis_tarihi"].HeaderText = "Veriliş Tarihi";
                gridOduncKitaplar.Columns["verilis_tarihi"].Width = 70;
                gridOduncKitaplar.Columns["teslim_tarihi"].HeaderText = "Teslim Tarihi";
                gridOduncKitaplar.Columns["teslim_tarihi"].Width = 70;
                gridOduncKitaplar.Columns["aciklama"].HeaderText = "Açıklama";
                gridOduncKitaplar.Columns["aciklama"].Width = 150;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Hata oluştu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        public void KitapYukle()
        {
            try
            {
                komutSatiri =
                    "SELECT * FROM kitaplar WHERE kitap_id NOT IN (SELECT kitap_id FROM odunc_kitaplar WHERE teslim_tarihi IS NULL);";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                comboKitap.DataSource = dataTable;
                comboKitap.ValueMember = "kitap_id";
                comboKitap.DisplayMember = "kitap_adi";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Hata oluştu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        public void Temizle()
        {
            txtNo.Clear();
            comboKitap.ResetText();
            txtAciklama.Clear();
        }
    }
}
