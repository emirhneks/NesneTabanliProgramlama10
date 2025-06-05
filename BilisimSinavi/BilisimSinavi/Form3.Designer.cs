namespace BilisimSinavi
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtxtYazdir = new System.Windows.Forms.RichTextBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.belge = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // rtxtYazdir
            // 
            this.rtxtYazdir.Enabled = false;
            this.rtxtYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtxtYazdir.Location = new System.Drawing.Point(12, 12);
            this.rtxtYazdir.Name = "rtxtYazdir";
            this.rtxtYazdir.Size = new System.Drawing.Size(958, 308);
            this.rtxtYazdir.TabIndex = 0;
            this.rtxtYazdir.Text = "";
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.Red;
            this.btnYazdir.ForeColor = System.Drawing.Color.White;
            this.btnYazdir.Location = new System.Drawing.Point(281, 341);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(450, 100);
            this.btnYazdir.TabIndex = 8;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // belge
            // 
            this.belge.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.belge_PrintPage);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.rtxtYazdir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtYazdir;
        private System.Windows.Forms.Button btnYazdir;
        private System.Drawing.Printing.PrintDocument belge;
    }
}