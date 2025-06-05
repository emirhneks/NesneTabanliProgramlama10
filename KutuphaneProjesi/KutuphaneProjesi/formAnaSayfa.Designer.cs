namespace KutuphaneProjesi
{
    partial class formAnaSayfa
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
            this.btnKitap = new System.Windows.Forms.Button();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnTur = new System.Windows.Forms.Button();
            this.btnOdunc = new System.Windows.Forms.Button();
            this.btnFabrikaAyarlari = new System.Windows.Forms.Button();
            this.OrnekVeriler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKitap
            // 
            this.btnKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitap.Location = new System.Drawing.Point(42, 44);
            this.btnKitap.Name = "btnKitap";
            this.btnKitap.Size = new System.Drawing.Size(170, 75);
            this.btnKitap.TabIndex = 0;
            this.btnKitap.Text = "Kitap İşlemleri";
            this.btnKitap.UseVisualStyleBackColor = true;
            this.btnKitap.Click += new System.EventHandler(this.btnKitap_Click_1);
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenci.Location = new System.Drawing.Point(220, 44);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(170, 75);
            this.btnOgrenci.TabIndex = 1;
            this.btnOgrenci.Text = "Öğrenci İşlemleri";
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // btnTur
            // 
            this.btnTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTur.Location = new System.Drawing.Point(42, 125);
            this.btnTur.Name = "btnTur";
            this.btnTur.Size = new System.Drawing.Size(170, 75);
            this.btnTur.TabIndex = 2;
            this.btnTur.Text = "Tür İşlemleri";
            this.btnTur.UseVisualStyleBackColor = true;
            this.btnTur.Click += new System.EventHandler(this.btnTur_Click);
            // 
            // btnOdunc
            // 
            this.btnOdunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdunc.Location = new System.Drawing.Point(220, 125);
            this.btnOdunc.Name = "btnOdunc";
            this.btnOdunc.Size = new System.Drawing.Size(170, 75);
            this.btnOdunc.TabIndex = 3;
            this.btnOdunc.Text = "Ödünç Kitap İşlemleri";
            this.btnOdunc.UseVisualStyleBackColor = true;
            this.btnOdunc.Click += new System.EventHandler(this.btnOdunc_Click);
            // 
            // btnFabrikaAyarlari
            // 
            this.btnFabrikaAyarlari.Location = new System.Drawing.Point(12, 216);
            this.btnFabrikaAyarlari.Name = "btnFabrikaAyarlari";
            this.btnFabrikaAyarlari.Size = new System.Drawing.Size(200, 50);
            this.btnFabrikaAyarlari.TabIndex = 4;
            this.btnFabrikaAyarlari.Text = "Fabrika Ayarlarına Dön";
            this.btnFabrikaAyarlari.UseVisualStyleBackColor = true;
            this.btnFabrikaAyarlari.Click += new System.EventHandler(this.btnFabrikaAyarlari_Click);
            // 
            // OrnekVeriler
            // 
            this.OrnekVeriler.Location = new System.Drawing.Point(220, 216);
            this.OrnekVeriler.Name = "OrnekVeriler";
            this.OrnekVeriler.Size = new System.Drawing.Size(200, 50);
            this.OrnekVeriler.TabIndex = 5;
            this.OrnekVeriler.Text = "Örnek Veriler Ekle";
            this.OrnekVeriler.UseVisualStyleBackColor = true;
            this.OrnekVeriler.Click += new System.EventHandler(this.OrnekVeriler_Click);
            // 
            // formAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 278);
            this.Controls.Add(this.OrnekVeriler);
            this.Controls.Add(this.btnFabrikaAyarlari);
            this.Controls.Add(this.btnOdunc);
            this.Controls.Add(this.btnTur);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.btnKitap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Projesi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formAnaSayfa_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKitap;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnTur;
        private System.Windows.Forms.Button btnOdunc;
        private System.Windows.Forms.Button btnFabrikaAyarlari;
        private System.Windows.Forms.Button OrnekVeriler;
    }
}

