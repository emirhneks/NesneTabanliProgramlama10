namespace BTOdev1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Sayi1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Sayi2 = new System.Windows.Forms.TextBox();
            this.AsalSayilarListesi = new System.Windows.Forms.ListBox();
            this.ListeleButonu = new System.Windows.Forms.Button();
            this.TemizleButonu = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.CikisYapButonu = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sayi1
            // 
            this.Sayi1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sayi1.Location = new System.Drawing.Point(12, 12);
            this.Sayi1.Name = "Sayi1";
            this.Sayi1.Size = new System.Drawing.Size(110, 33);
            this.Sayi1.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(55, 48);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(33, 26);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "ile";
            // 
            // Sayi2
            // 
            this.Sayi2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.Sayi2.Location = new System.Drawing.Point(12, 77);
            this.Sayi2.Name = "Sayi2";
            this.Sayi2.Size = new System.Drawing.Size(110, 33);
            this.Sayi2.TabIndex = 2;
            // 
            // AsalSayilarListesi
            // 
            this.AsalSayilarListesi.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AsalSayilarListesi.FormattingEnabled = true;
            this.AsalSayilarListesi.ItemHeight = 26;
            this.AsalSayilarListesi.Location = new System.Drawing.Point(128, 12);
            this.AsalSayilarListesi.Name = "AsalSayilarListesi";
            this.AsalSayilarListesi.Size = new System.Drawing.Size(124, 108);
            this.AsalSayilarListesi.TabIndex = 4;
            // 
            // ListeleButonu
            // 
            this.ListeleButonu.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.ListeleButonu.Location = new System.Drawing.Point(12, 123);
            this.ListeleButonu.Name = "ListeleButonu";
            this.ListeleButonu.Size = new System.Drawing.Size(110, 127);
            this.ListeleButonu.TabIndex = 3;
            this.ListeleButonu.Text = "arasındaki asal sayıları listele";
            this.ListeleButonu.UseVisualStyleBackColor = true;
            this.ListeleButonu.Click += new System.EventHandler(this.ListeleButonu_Click);
            // 
            // TemizleButonu
            // 
            this.TemizleButonu.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TemizleButonu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TemizleButonu.ImageKey = "supurge.png";
            this.TemizleButonu.ImageList = this.ımageList1;
            this.TemizleButonu.Location = new System.Drawing.Point(12, 256);
            this.TemizleButonu.Name = "TemizleButonu";
            this.TemizleButonu.Size = new System.Drawing.Size(240, 75);
            this.TemizleButonu.TabIndex = 5;
            this.TemizleButonu.Text = "Temizle";
            this.TemizleButonu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TemizleButonu.UseVisualStyleBackColor = true;
            this.TemizleButonu.Click += new System.EventHandler(this.TemizleButonu_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "supurge.png");
            this.ımageList1.Images.SetKeyName(1, "carpiisareti.png");
            // 
            // CikisYapButonu
            // 
            this.CikisYapButonu.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CikisYapButonu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CikisYapButonu.ImageKey = "carpiisareti.png";
            this.CikisYapButonu.ImageList = this.ımageList1;
            this.CikisYapButonu.Location = new System.Drawing.Point(12, 337);
            this.CikisYapButonu.Name = "CikisYapButonu";
            this.CikisYapButonu.Size = new System.Drawing.Size(240, 75);
            this.CikisYapButonu.TabIndex = 6;
            this.CikisYapButonu.Text = "Çıkış Yap";
            this.CikisYapButonu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CikisYapButonu.UseVisualStyleBackColor = true;
            this.CikisYapButonu.Click += new System.EventHandler(this.CikisYapButonu_Click);
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(128, 123);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(124, 127);
            this.Label2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(264, 421);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.CikisYapButonu);
            this.Controls.Add(this.TemizleButonu);
            this.Controls.Add(this.ListeleButonu);
            this.Controls.Add(this.AsalSayilarListesi);
            this.Controls.Add(this.Sayi2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Sayi1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Asal Sayı Hesaplayıcı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Sayi1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox Sayi2;
        private System.Windows.Forms.ListBox AsalSayilarListesi;
        private System.Windows.Forms.Button ListeleButonu;
        private System.Windows.Forms.Button TemizleButonu;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button CikisYapButonu;
        private System.Windows.Forms.Label Label2;
    }
}

