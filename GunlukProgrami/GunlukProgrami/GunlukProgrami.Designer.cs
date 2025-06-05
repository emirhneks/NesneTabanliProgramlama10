namespace GunlukProgrami
{
    partial class GunlukProgrami
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GunlukProgrami));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtGunluk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TarihSecici = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGunlukID = new System.Windows.Forms.TextBox();
            this.btnKontrolEt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Gunlukler = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gunlukler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnGonder);
            this.groupBox1.Controls.Add(this.txtGunluk);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TarihSecici);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 580);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Günlük bilgilerinizi giriniz:";
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.Black;
            this.btnGonder.Location = new System.Drawing.Point(110, 485);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(200, 75);
            this.btnGonder.TabIndex = 4;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // txtGunluk
            // 
            this.txtGunluk.Location = new System.Drawing.Point(12, 200);
            this.txtGunluk.Multiline = true;
            this.txtGunluk.Name = "txtGunluk";
            this.txtGunluk.Size = new System.Drawing.Size(382, 275);
            this.txtGunluk.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Günlük:";
            // 
            // TarihSecici
            // 
            this.TarihSecici.Location = new System.Drawing.Point(12, 82);
            this.TarihSecici.Name = "TarihSecici";
            this.TarihSecici.Size = new System.Drawing.Size(382, 40);
            this.TarihSecici.TabIndex = 1;
            this.TarihSecici.Value = new System.DateTime(2008, 7, 18, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtGunlukID);
            this.groupBox2.Controls.Add(this.btnKontrolEt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(419, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 220);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Günlük bilgi alma:";
            // 
            // txtGunlukID
            // 
            this.txtGunlukID.Location = new System.Drawing.Point(12, 83);
            this.txtGunlukID.Name = "txtGunlukID";
            this.txtGunlukID.Size = new System.Drawing.Size(274, 40);
            this.txtGunlukID.TabIndex = 5;
            // 
            // btnKontrolEt
            // 
            this.btnKontrolEt.BackColor = System.Drawing.Color.Black;
            this.btnKontrolEt.Location = new System.Drawing.Point(40, 129);
            this.btnKontrolEt.Name = "btnKontrolEt";
            this.btnKontrolEt.Size = new System.Drawing.Size(200, 75);
            this.btnKontrolEt.TabIndex = 4;
            this.btnKontrolEt.Text = "Kontrol Et";
            this.btnKontrolEt.UseVisualStyleBackColor = false;
            this.btnKontrolEt.Click += new System.EventHandler(this.btnKontrolEt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "Günlük ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.Gunlukler);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(419, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 354);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Günlükler:";
            // 
            // Gunlukler
            // 
            this.Gunlukler.AllowUserToAddRows = false;
            this.Gunlukler.AllowUserToDeleteRows = false;
            this.Gunlukler.AllowUserToResizeColumns = false;
            this.Gunlukler.AllowUserToResizeRows = false;
            this.Gunlukler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Gunlukler.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 16.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gunlukler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Gunlukler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 16.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gunlukler.DefaultCellStyle = dataGridViewCellStyle2;
            this.Gunlukler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gunlukler.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Gunlukler.GridColor = System.Drawing.Color.Black;
            this.Gunlukler.Location = new System.Drawing.Point(3, 36);
            this.Gunlukler.Name = "Gunlukler";
            this.Gunlukler.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 16.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gunlukler.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Gunlukler.RowHeadersVisible = false;
            this.Gunlukler.RowHeadersWidth = 51;
            this.Gunlukler.RowTemplate.Height = 24;
            this.Gunlukler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Gunlukler.Size = new System.Drawing.Size(286, 315);
            this.Gunlukler.TabIndex = 5;
            // 
            // GunlukProgrami
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GunlukProgrami.Properties.Resources.ArkaPlan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(722, 603);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 16.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "GunlukProgrami";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Günlük Programı";
            this.Load += new System.EventHandler(this.GunlukProgrami_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gunlukler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox txtGunluk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker TarihSecici;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKontrolEt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGunlukID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView Gunlukler;
    }
}