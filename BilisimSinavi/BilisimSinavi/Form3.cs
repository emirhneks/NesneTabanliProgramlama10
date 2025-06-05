using System;
using System.Drawing;
using System.Windows.Forms;

namespace BilisimSinavi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            rtxtYazdir.Text = Class1.RichTextBox.Text;
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                belge.Print();
            }
        }

        private void belge_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(
                rtxtYazdir.Text,
                rtxtYazdir.Font,
                Brushes.Black,
                new Point(100, 100)
            );
        }
    }
}
