namespace En_Hızlı_Basan_Kazanır
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Para1 = new System.Windows.Forms.Label();
            this.Para2 = new System.Windows.Forms.Label();
            this.SifirlaTusu = new System.Windows.Forms.PictureBox();
            this.KapatTusu = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SifirlaTusu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KapatTusu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Georgia", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(70, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "En Hızlı Basan Kazanır!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(70, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Klavye Tuşu (A)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(320, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Klavye Tuşu (D)";
            // 
            // Para1
            // 
            this.Para1.AutoSize = true;
            this.Para1.Location = new System.Drawing.Point(130, 170);
            this.Para1.Name = "Para1";
            this.Para1.Size = new System.Drawing.Size(31, 31);
            this.Para1.TabIndex = 5;
            this.Para1.Text = "0";
            // 
            // Para2
            // 
            this.Para2.AutoSize = true;
            this.Para2.Location = new System.Drawing.Point(380, 170);
            this.Para2.Name = "Para2";
            this.Para2.Size = new System.Drawing.Size(31, 31);
            this.Para2.TabIndex = 6;
            this.Para2.Text = "0";
            // 
            // SifirlaTusu
            // 
            this.SifirlaTusu.BackColor = System.Drawing.Color.White;
            this.SifirlaTusu.Image = ((System.Drawing.Image)(resources.GetObject("SifirlaTusu.Image")));
            this.SifirlaTusu.Location = new System.Drawing.Point(522, 12);
            this.SifirlaTusu.Name = "SifirlaTusu";
            this.SifirlaTusu.Size = new System.Drawing.Size(25, 25);
            this.SifirlaTusu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SifirlaTusu.TabIndex = 8;
            this.SifirlaTusu.TabStop = false;
            this.SifirlaTusu.Click += new System.EventHandler(this.SifirlaTusu_Click);
            // 
            // KapatTusu
            // 
            this.KapatTusu.BackColor = System.Drawing.Color.White;
            this.KapatTusu.Image = global::En_Hızlı_Basan_Kazanır.Properties.Resources.close;
            this.KapatTusu.Location = new System.Drawing.Point(553, 12);
            this.KapatTusu.Name = "KapatTusu";
            this.KapatTusu.Size = new System.Drawing.Size(25, 25);
            this.KapatTusu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.KapatTusu.TabIndex = 7;
            this.KapatTusu.TabStop = false;
            this.KapatTusu.Click += new System.EventHandler(this.KapatTusu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::En_Hızlı_Basan_Kazanır.Properties.Resources.coin;
            this.pictureBox2.Location = new System.Drawing.Point(320, 160);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::En_Hızlı_Basan_Kazanır.Properties.Resources.coin;
            this.pictureBox1.Location = new System.Drawing.Point(70, 160);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 260);
            this.Controls.Add(this.SifirlaTusu);
            this.Controls.Add(this.KapatTusu);
            this.Controls.Add(this.Para2);
            this.Controls.Add(this.Para1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EHBK";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.SifirlaTusu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KapatTusu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Para1;
        private System.Windows.Forms.Label Para2;
        private System.Windows.Forms.PictureBox KapatTusu;
        private System.Windows.Forms.PictureBox SifirlaTusu;
    }
}

