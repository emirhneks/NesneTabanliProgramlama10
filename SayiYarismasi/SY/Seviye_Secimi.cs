using System;
using System.Windows.Forms;

namespace SY
{
    public partial class Seviye_Secimi : Form
    {
        public Seviye_Secimi()
        {
            InitializeComponent();
        }

        public void SureyiAktar(int sure)
        {
            SY sy = new SY();
            sy.ayarlananSure.Text = sure.ToString();
            sy.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SureyiAktar(7);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SureyiAktar(3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SureyiAktar(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
