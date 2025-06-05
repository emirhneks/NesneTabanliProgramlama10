using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAPersonelTakipSistemi
{
    public partial class GirisSecimPaneli : Form
    {
        public GirisSecimPaneli()
        {
            InitializeComponent();
        }

        private void btnYoneticiGirisi_Click(object sender, EventArgs e)
        {
            GirisYonlendirme(true);
        }

        private void btnPersonelGirisi_Click(object sender, EventArgs e)
        {
            GirisYonlendirme(false);
        }

        private void GirisSecimPaneli_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        internal void GirisYonlendirme(bool Yonetici)
        {
            MessageBox.Show(
                "Yönlendiriliyorsunuz...",
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            GirisPaneli girisPaneli = new GirisPaneli();
            if (Yonetici == true)
                girisPaneli.Yonetici = true;
            else
                girisPaneli.Yonetici = false;
            girisPaneli.Show();
            this.Hide();
        }
    }
}
