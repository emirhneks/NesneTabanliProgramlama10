namespace EAPersonelTakipSistemi
{
    partial class GirisSecimPaneli
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisSecimPaneli));
            this.gorselListesi1 = new System.Windows.Forms.ImageList(this.components);
            this.btnPersonelGirisi = new System.Windows.Forms.Button();
            this.btnYoneticiGirisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gorselListesi1
            // 
            this.gorselListesi1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("gorselListesi1.ImageStream")));
            this.gorselListesi1.TransparentColor = System.Drawing.Color.Transparent;
            this.gorselListesi1.Images.SetKeyName(0, "Yönetici.png");
            this.gorselListesi1.Images.SetKeyName(1, "Personel.png");
            // 
            // btnPersonelGirisi
            // 
            this.btnPersonelGirisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonelGirisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonelGirisi.ImageKey = "Personel.png";
            this.btnPersonelGirisi.ImageList = this.gorselListesi1;
            this.btnPersonelGirisi.Location = new System.Drawing.Point(12, 138);
            this.btnPersonelGirisi.Name = "btnPersonelGirisi";
            this.btnPersonelGirisi.Size = new System.Drawing.Size(360, 120);
            this.btnPersonelGirisi.TabIndex = 1;
            this.btnPersonelGirisi.Text = "Personel Girişi";
            this.btnPersonelGirisi.UseVisualStyleBackColor = true;
            this.btnPersonelGirisi.Click += new System.EventHandler(this.btnPersonelGirisi_Click);
            // 
            // btnYoneticiGirisi
            // 
            this.btnYoneticiGirisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYoneticiGirisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYoneticiGirisi.ImageKey = "Yönetici.png";
            this.btnYoneticiGirisi.ImageList = this.gorselListesi1;
            this.btnYoneticiGirisi.Location = new System.Drawing.Point(12, 12);
            this.btnYoneticiGirisi.Name = "btnYoneticiGirisi";
            this.btnYoneticiGirisi.Size = new System.Drawing.Size(360, 120);
            this.btnYoneticiGirisi.TabIndex = 0;
            this.btnYoneticiGirisi.Text = "Yönetici Girişi";
            this.btnYoneticiGirisi.UseVisualStyleBackColor = true;
            this.btnYoneticiGirisi.Click += new System.EventHandler(this.btnYoneticiGirisi_Click);
            // 
            // GirisSecimiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(392, 273);
            this.Controls.Add(this.btnPersonelGirisi);
            this.Controls.Add(this.btnYoneticiGirisi);
            this.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GirisSecimiPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Profili Seçiniz!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GirisSecimPaneli_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYoneticiGirisi;
        private System.Windows.Forms.ImageList gorselListesi1;
        private System.Windows.Forms.Button btnPersonelGirisi;
    }
}

