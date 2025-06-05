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
    public partial class OgrenciPaneli : Form
    {
        public OgrenciPaneli()
        {
            InitializeComponent();
        }

        public string numara;

        SqlConnection connection = new SqlConnection(
            @"Data Source=DESKTOP-LDME0PG;Initial Catalog=NotKayitVeriTabani;Integrated Security=True"
        );

        private void OgrenciPaneli_Load(object sender, EventArgs e)
        {
            labelNumara.Text = numara;

            connection.Open();
            SqlCommand command = new SqlCommand(
                @"select * from DersTBL where OgrNumara=@P1",
                connection
            );
            command.Parameters.AddWithValue("@P1", numara);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                labelAd.Text = dataReader[2].ToString();
                labelSoyad.Text = dataReader[3].ToString();
                labelSinav1.Text = dataReader[4].ToString();
                labelSinav2.Text = dataReader[5].ToString();
                labelSinav3.Text = dataReader[6].ToString();
                labelOrt.Text = dataReader[7].ToString();
                if (dataReader[8].ToString() == "True")
                {
                    labelDurum.Text = "Geçti";
                }
                else if (dataReader[8].ToString() == "False")
                {
                    labelDurum.Text = "Kaldı";
                }
                else
                {
                    labelDurum.Text = "";
                }
            }
            connection.Close();
        }
    }
}
