namespace GunlukProgrami
{
    partial class GirisPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisPaneli));
            this.label1 = new System.Windows.Forms.Label();
            this.gbBilgiGiris = new System.Windows.Forms.GroupBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.GostermeDurumu = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtGunlukSifresi = new System.Windows.Forms.MaskedTextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.gbBilgiGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GostermeDurumu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // gbBilgiGiris
            // 
            this.gbBilgiGiris.BackColor = System.Drawing.Color.Transparent;
            this.gbBilgiGiris.Controls.Add(this.btnKayitOl);
            this.gbBilgiGiris.Controls.Add(this.btnGirisYap);
            this.gbBilgiGiris.Controls.Add(this.GostermeDurumu);
            this.gbBilgiGiris.Controls.Add(this.label2);
            this.gbBilgiGiris.Controls.Add(this.mtxtGunlukSifresi);
            this.gbBilgiGiris.Controls.Add(this.txtKullaniciAdi);
            this.gbBilgiGiris.Controls.Add(this.label1);
            this.gbBilgiGiris.ForeColor = System.Drawing.Color.White;
            this.gbBilgiGiris.Location = new System.Drawing.Point(13, 13);
            this.gbBilgiGiris.Name = "gbBilgiGiris";
            this.gbBilgiGiris.Size = new System.Drawing.Size(520, 260);
            this.gbBilgiGiris.TabIndex = 1;
            this.gbBilgiGiris.TabStop = false;
            this.gbBilgiGiris.Text = "Lütfen bilgilerinizi giriniz:";
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.Black;
            this.btnKayitOl.ForeColor = System.Drawing.Color.White;
            this.btnKayitOl.Location = new System.Drawing.Point(270, 164);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(200, 75);
            this.btnKayitOl.TabIndex = 6;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.Black;
            this.btnGirisYap.ForeColor = System.Drawing.Color.White;
            this.btnGirisYap.Location = new System.Drawing.Point(64, 164);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(200, 75);
            this.btnGirisYap.TabIndex = 5;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // GostermeDurumu
            // 
            this.GostermeDurumu.Image = global::GunlukProgrami.Properties.Resources.Gizli;
            this.GostermeDurumu.Location = new System.Drawing.Point(430, 100);
            this.GostermeDurumu.Name = "GostermeDurumu";
            this.GostermeDurumu.Size = new System.Drawing.Size(40, 40);
            this.GostermeDurumu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GostermeDurumu.TabIndex = 4;
            this.GostermeDurumu.TabStop = false;
            this.GostermeDurumu.Click += new System.EventHandler(this.GostermeDurumu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Günlük Şifresi:";
            // 
            // mtxtGunlukSifresi
            // 
            this.mtxtGunlukSifresi.Location = new System.Drawing.Point(210, 100);
            this.mtxtGunlukSifresi.Mask = "000000";
            this.mtxtGunlukSifresi.Name = "mtxtGunlukSifresi";
            this.mtxtGunlukSifresi.Size = new System.Drawing.Size(200, 40);
            this.mtxtGunlukSifresi.TabIndex = 2;
            this.mtxtGunlukSifresi.UseSystemPasswordChar = true;
            this.mtxtGunlukSifresi.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtGunlukSifresi_Validating);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(210, 54);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(200, 40);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // GirisPaneli
            // 
            this.AcceptButton = this.btnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GunlukProgrami.Properties.Resources.ArkaPlan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(540, 291);
            this.Controls.Add(this.gbBilgiGiris);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GirisPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Günlük Programı";
            this.gbBilgiGiris.ResumeLayout(false);
            this.gbBilgiGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GostermeDurumu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbBilgiGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtGunlukSifresi;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.PictureBox GostermeDurumu;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Button btnKayitOl;
    }
}

