using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KutuphaneProjesi
{
    public partial class formAnaSayfa : Form
    {
        public formAnaSayfa()
        {
            InitializeComponent();
        }

        VeriTabaniIslemleri vtIslemleri = new VeriTabaniIslemleri();
        SqlConnection baglanti;
        SqlCommand komut;

        private void btnKitap_Click_1(object sender, EventArgs e)
        {
            formKitap kitap = new formKitap();
            kitap.Show();

            this.Hide();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            formOgrenci ogrenci = new formOgrenci();
            ogrenci.Show();

            this.Hide();
        }

        private void btnTur_Click(object sender, EventArgs e)
        {
            formKitapTur kitapTur = new formKitapTur();
            kitapTur.Show();

            this.Hide();
        }

        private void btnOdunc_Click(object sender, EventArgs e)
        {
            formOduncKitap odunckitap = new formOduncKitap();
            odunckitap.Show();

            this.Hide();
        }

        private void btnFabrikaAyarlari_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = vtIslemleri.baglan();
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();
                komut = new SqlCommand(
                    "TRUNCATE TABLE kitap_turleri;"
                        + "TRUNCATE TABLE kitaplar;"
                        + "TRUNCATE TABLE odunc_kitaplar;"
                        + "TRUNCATE TABLE ogrenciler;",
                    baglanti
                );
                komut.ExecuteNonQuery();
                baglanti.Close();
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

        private void OrnekVeriler_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = vtIslemleri.baglan();
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();
                komut = new SqlCommand(
                    "INSERT INTO kitap_turleri VALUES ('Roman'), ('Hikaye'), ('Şiir'), ('Gezi'), ('Çocuk'), ('Kişisel Gelişim'), ('Sağlık'), ('Dergi');"
                        + "INSERT INTO kitaplar VALUES (1, 'Kuyucaklı Yusuf', 'Sabahattin Ali', 'Deneme', 221), (1, 'Suç ve Ceza', 'Dostoyevski', 'İnkilap', 687), (1, 'Beyaz Gemi', 'Cengiz Aytmatov', 'Yapı Kredi', 168), (1, 'Sinekli Bakkal', 'Halide Edip Adıvar', 'Can', 476), (1, 'Çalıkuşu', 'Reşat Nuri Güntekin', 'İş Bankası', 544), (1, 'Sefiller', 'Victor Hugo', 'İnkilap', 520), (2, 'Ömer Seyfettin Hikayeleri', 'Ömer Seyfettin', 'Can', 176), (1, 'Küçük Ağa', 'Tarık Buğra', 'Yapı Kredi', 477), (1, 'Yaban', 'Yakup Kadri Karaosmanoğlu', 'İş Bankası', 215), (1, 'Ölü Canlar', 'Gogol', 'Can', 484), (3, 'Otuz Beş Yaş', 'Cahit Sıtkı Tarancı', 'İnkilap', 120), (3, 'Safahat', 'Mehmet Akif Ersoy', 'Can', 560), (3, 'Çile', 'Necip Fazıl Kısakürek', 'İş Bankası', 512), (3, 'Bütün Şirrleri-Orhan Veli', 'Orhan Veli Kanık', 'İnkilap', 247), (4, 'Anadolu Notları', 'Reşat Nuri Güntekin', 'Yapı Kredi', 287), (4, 'Seyehatname', 'Evliya Çelebi', 'Can', 828);"
                        + "INSERT INTO odunc_kitaplar VALUES (145, 3, '2022-02-09', NULL, ''), (222, 2, '2022-02-09', NULL, ''), (336, 12, '2022-02-09', NULL, ''), (555, 11, '2022-02-16', NULL, ''), (985, 1, '2022-02-16', NULL, ''), (411, 6, '2022-02-16', NULL, ''), (99, 7, '2022-02-18', NULL, ''), (150, 10, '2022-02-24', NULL, ''), (344, 8, '2022-02-18', NULL, ''), (900, 4, '2022-02-18', NULL, '');"
                        + "INSERT INTO ogrenciler VALUES (99, 'Ayşe', 'Yılmaz', 9, 'Kız', '5054564545'), (145, 'Esat', 'Esmer', 11, 'Erkek', '5052331214'), (150, 'Emirhan', 'Çelik', 11, 'Erkek', '5054864543'), (188, 'Ali', 'Kır', 9, 'Erkek', '5054564549'), (222, 'Zeynep', 'Öz', 10, 'Kız', '5054564545'), (336, 'Murat', 'Temiz', 11, 'Erkek', '5054864542'), (344, 'Esra', 'Öz', 10, 'Kız', '5054564545'), (411, 'Samet', 'Kurt', 10, 'Erkek', '5054864543'), (460, 'Yakup', 'Bal', 11, 'Erkek', '5054564545'), (461, 'Serpil', 'Kemik', 9, 'Kız', '5054564345'), (555, 'Ayşe', 'Can', 11, 'Kız', '5054564345'), (763, 'Serhat', 'Emir', 12, 'Erkek', '5054764543'), (985, 'Mehmet', 'Demir', 12, 'Erkek', '5054564543');",
                    baglanti
                );
                komut.ExecuteNonQuery();
                baglanti.Close();
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

        private void formAnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
