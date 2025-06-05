using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KSGKutuphane
{
    public partial class formKitap : Form
    {
        public formKitap()
        {
            InitializeComponent();
        }

        VeriTabaniIslemleri vtIslemleri = new VeriTabaniIslemleri();
        SqlConnection baglanti;
        SqlCommand komut;
        string komutSatiri;

        private void formKitap_Load(object sender, EventArgs e)
        {
            KitapTurYukle();
            KitapListele();
        }

        private void txtKitapAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();
                komutSatiri =
                    "SELECT kitap_id, tur_adi, kitap_adi, yazar, yayinevi, sayfa_sayisi FROM kitaplar, kitap_turleri WHERE kitaplar.tur_id = kitap_turleri.tur_id AND kitap_adi LIKE '"
                    + txtKitapAra.Text
                    + "%';";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                baglanti.Close();
                gridKitap.DataSource = dataTable;
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();
                komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText =
                    "INSERT INTO kitaplar (tur_id, kitap_adi, yazar, yayinevi, sayfa_sayisi) VALUES (@tur_id, @kitap_adi, @yazar, @yayinevi, @sayfa_sayisi);";
                komut.Parameters.AddWithValue(
                    "@tur_id",
                    int.Parse(comboKitapTur.SelectedValue.ToString())
                );
                komut.Parameters.AddWithValue("@kitap_adi", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@yazar", txtYazar.Text);
                komut.Parameters.AddWithValue("@yayinevi", txtYayinEvi.Text);
                komut.Parameters.AddWithValue("@sayfa_sayisi", int.Parse(txtSayfaSayisi.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show(
                    "İşlem başarılı",
                    "Mesaj",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                );
                KitapListele();
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
                komut.CommandText = "DELETE FROM kitaplar WHERE kitap_id = @kitap_id;";
                komut.Parameters.AddWithValue(
                    "@kitap_id",
                    gridKitap.CurrentRow.Cells["kitap_id"].Value.ToString()
                );
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show(
                    "İşlem başarılı",
                    "Mesaj",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                );
                KitapListele();
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
                    "UPDATE kitaplar SET tur_id = @tur_id, kitap_adi = @kitap_adi, yazar = @yazar, yayinevi = @yayinevi, sayfa_sayisi = @sayfa_sayisi WHERE kitap_id = @kitap_id;";
                komut.Parameters.AddWithValue(
                    "@kitap_id",
                    int.Parse(gridKitap.CurrentRow.Cells["kitap_id"].Value.ToString())
                );
                komut.Parameters.AddWithValue(
                    "@tur_id",
                    int.Parse(comboKitapTur.SelectedValue.ToString())
                );
                komut.Parameters.AddWithValue("@kitap_adi", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@yazar", txtYazar.Text);
                komut.Parameters.AddWithValue("@yayinevi", txtYayinEvi.Text);
                komut.Parameters.AddWithValue("@sayfa_sayisi", int.Parse(txtSayfaSayisi.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show(
                    "İşlem başarılı",
                    "Mesaj",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                );
                KitapListele();
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

        private void gridKitap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtKitapAdi.Text = gridKitap.CurrentRow.Cells["kitap_adi"].Value.ToString();
                txtSayfaSayisi.Text = gridKitap.CurrentRow.Cells["sayfa_sayisi"].Value.ToString();
                txtYayinEvi.Text = gridKitap.CurrentRow.Cells["yayinevi"].Value.ToString();
                txtYazar.Text = gridKitap.CurrentRow.Cells["yazar"].Value.ToString();
                comboKitapTur.Text = gridKitap.CurrentRow.Cells["tur_adi"].Value.ToString();
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

        private void formKitap_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAnaSayfa anaSayfa = new formAnaSayfa();
            anaSayfa.Show();

            this.Hide();
        }

        public void KitapTurYukle()
        {
            try
            {
                baglanti = vtIslemleri.baglan();
                komutSatiri = "SELECT * FROM kitap_turleri;";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                comboKitapTur.DataSource = dataTable;
                comboKitapTur.ValueMember = "tur_id";
                comboKitapTur.DisplayMember = "tur_adi";
                comboKitapTur.ResetText();
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

        public void KitapListele()
        {
            try
            {
                baglanti = vtIslemleri.baglan();
                komutSatiri =
                    "SELECT kitap_id, tur_adi, kitap_adi, yazar, yayinevi, sayfa_sayisi FROM kitaplar, kitap_turleri WHERE kitaplar.tur_id = kitap_turleri.tur_id;";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                gridKitap.DataSource = dataTable;
                gridKitap.Columns["kitap_id"].HeaderText = "ID";
                gridKitap.Columns["kitap_id"].Width = 20;
                gridKitap.Columns["tur_adi"].HeaderText = "Tür";
                gridKitap.Columns["tur_adi"].Width = 60;
                gridKitap.Columns["kitap_adi"].HeaderText = "Ada";
                gridKitap.Columns["kitap_adi"].Width = 90;
                gridKitap.Columns["yazar"].HeaderText = "Yazar";
                gridKitap.Columns["yazar"].Width = 120;
                gridKitap.Columns["yayinevi"].HeaderText = "Yayınevi";
                gridKitap.Columns["yayinevi"].Width = 80;
                gridKitap.Columns["sayfa_sayisi"].HeaderText = "Sayfa Sayısı";
                gridKitap.Columns["sayfa_sayisi"].Width = 50;
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

        public void Temizle()
        {
            txtKitapAdi.Clear();
            txtYazar.Clear();
            txtYayinEvi.Clear();
            comboKitapTur.ResetText();
            txtSayfaSayisi.Clear();
        }
    }
}
