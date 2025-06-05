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

namespace GunlukProgrami
{
    public partial class GunlukProgrami : Form
    {
        public GunlukProgrami()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(
            "Data Source=DESKTOP-LDME0PG;Initial Catalog=GunlukVeriTabani;Integrated Security=True;MultipleActiveResultSets=True;"
        );

        public int ID;

        private void GunlukProgrami_Load(object sender, EventArgs e)
        {
            TarihSecici.Value = DateTime.Today;

            Listele();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO GunlukTBL (kullaniciid, tarih, gunluk) VALUES (@kullaniciid, @tarih, @gunluk); SELECT SCOPE_IDENTITY();",
                connection
            );
            cmd.Parameters.AddWithValue("kullaniciid", ID);
            cmd.Parameters.AddWithValue("tarih", TarihSecici.Value);
            cmd.Parameters.AddWithValue("gunluk", txtGunluk.Text);

            MessageBox.Show(
                "Günlük kaydınız başarıyla eklendi! Günlük ID: " + cmd.ExecuteScalar().ToString(),
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            connection.Close();

            TarihSecici.Value = DateTime.Today;
            txtGunluk.Clear();

            Listele();
        }

        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGunlukID.Text))
            {
                MessageBox.Show(
                    "Lütfen bir ID girin!",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtGunlukID.Focus();
            }
            else
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT tarih, gunluk FROM GunlukTBL WHERE id=@id AND kullaniciid=@kullaniciid;",
                    connection
                );
                cmd.Parameters.AddWithValue("id", txtGunlukID.Text);
                cmd.Parameters.AddWithValue("kullaniciid", ID);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show(
                        reader[1].ToString(),
                        Convert.ToDateTime(reader[0]).ToShortDateString()
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Lütfen doğru bir ID girin!",
                        "Hata",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    txtGunlukID.Clear();
                    txtGunlukID.Focus();
                }

                connection.Close();
            }
        }

        public void Listele()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(
                "SELECT id, tarih FROM GunlukTBL WHERE kullaniciid=@kullaniciid;",
                connection
            );
            adapter.SelectCommand.Parameters.AddWithValue("kullaniciid", ID);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Gunlukler.DataSource = table;
            Gunlukler.Columns["id"].HeaderText = "ID";
            Gunlukler.Columns["tarih"].HeaderText = "Tarih";
        }
    }
}
