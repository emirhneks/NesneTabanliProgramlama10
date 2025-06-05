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

namespace Ogrenci_Not_Kayit_Sistemi
{
    public partial class OgretmenPaneli : Form
    {
        public OgretmenPaneli()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(
            @"Data Source=DESKTOP-LDME0PG;Initial Catalog=NotKayitVeriTabani;Integrated Security=True"
        );

        private void OgretmenPaneli_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'notKayitVeriTabaniDataSet.DersTBL' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dersTBLTableAdapter.Fill(this.notKayitVeriTabaniDataSet.DersTBL);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(
                "insert into DersTBL (OgrNumara,OgrAd,OgrSoyad) values (@P1, @P2, @P3)",
                connection
            );
            command.Parameters.AddWithValue("@P1", mskNumara.Text);
            command.Parameters.AddWithValue("@P2", txtAd.Text);
            command.Parameters.AddWithValue("@P3", txtSoyad.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show(
                "Öğrenci sisteme başarıyla eklendi!",
                "Öğrenci Ekle",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            this.dersTBLTableAdapter.Fill(this.notKayitVeriTabaniDataSet.DersTBL);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            mskNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskSinav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            mskSinav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            mskSinav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            labelOrt.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ort,
                s1,
                s2,
                s3;
            string durum;
            s1 = Convert.ToDouble(mskSinav1.Text);
            s2 = Convert.ToDouble(mskSinav2.Text);
            s3 = Convert.ToDouble(mskSinav3.Text);
            ort = (s1 + s2 + s3) / 3;
            labelOrt.Text = ort.ToString();
            if (ort >= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }
            connection.Open();
            SqlCommand command = new SqlCommand(
                "update DersTBL set OgrSinav1=@P1,OgrSinav2=@P2,OgrSinav3=@P3,OgrOrt=@P4,OgrDurum=@P5 where OgrNumara=@P6",
                connection
            );
            command.Parameters.AddWithValue("@P1", mskSinav1.Text);
            command.Parameters.AddWithValue("@P2", mskSinav2.Text);
            command.Parameters.AddWithValue("@P3", mskSinav3.Text);
            command.Parameters.AddWithValue("@P4", decimal.Parse(labelOrt.Text));
            command.Parameters.AddWithValue("@P5", durum);
            command.Parameters.AddWithValue("@P6", mskNumara.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show(
                "Sınav notları başarıyla güncellendi!",
                "Sınav Notları",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            this.dersTBLTableAdapter.Fill(this.notKayitVeriTabaniDataSet.DersTBL);
        }
    }
}
