using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ogrenci_Not_Kayit_Sistemi
{
    public partial class GirisPaneli : Form
    {
        public GirisPaneli()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "0000")
            {
                OgretmenPaneli ogretmenPaneli = new OgretmenPaneli();
                ogretmenPaneli.Show();
            }
            else
            {
                OgrenciPaneli ogrenciPaneli = new OgrenciPaneli();
                ogrenciPaneli.numara = maskedTextBox1.Text;
                ogrenciPaneli.Show();
            }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "0000")
            {
                OgretmenPaneli ogretmenPaneli = new OgretmenPaneli();
                ogretmenPaneli.Show();
            }
        }
    }
}
