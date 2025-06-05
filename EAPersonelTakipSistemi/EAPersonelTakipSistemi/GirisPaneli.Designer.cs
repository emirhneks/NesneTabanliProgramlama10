namespace EAPersonelTakipSistemi
{
    partial class GirisPaneli
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
            this.gbGiris = new System.Windows.Forms.GroupBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKod = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGiris
            // 
            this.gbGiris.Controls.Add(this.btnGiris);
            this.gbGiris.Controls.Add(this.txtKod);
            this.gbGiris.Controls.Add(this.label5);
            this.gbGiris.Controls.Add(this.label4);
            this.gbGiris.Controls.Add(this.lblKod);
            this.gbGiris.Controls.Add(this.txtSifre);
            this.gbGiris.Controls.Add(this.label2);
            this.gbGiris.Controls.Add(this.txtKullaniciAdi);
            this.gbGiris.Controls.Add(this.label1);
            this.gbGiris.Location = new System.Drawing.Point(12, 12);
            this.gbGiris.Name = "gbGiris";
            this.gbGiris.Size = new System.Drawing.Size(470, 320);
            this.gbGiris.TabIndex = 0;
            this.gbGiris.TabStop = false;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(12, 238);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(445, 55);
            this.btnGiris.TabIndex = 8;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(197, 175);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(260, 38);
            this.txtKod.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kodu Yazınız:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Doğrulama Kodu:";
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Font = new System.Drawing.Font("Ink Free", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKod.Location = new System.Drawing.Point(248, 138);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(0, 34);
            this.lblKod.TabIndex = 4;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(197, 75);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(260, 38);
            this.txtSifre.TabIndex = 3;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(197, 31);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(260, 38);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // GirisPaneli
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(492, 373);
            this.Controls.Add(this.gbGiris);
            this.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GirisPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgileri Doldurunuz!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GirisPaneli_FormClosed);
            this.Load += new System.EventHandler(this.GirisPaneli_Load);
            this.gbGiris.ResumeLayout(false);
            this.gbGiris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Label label5;
    }
}