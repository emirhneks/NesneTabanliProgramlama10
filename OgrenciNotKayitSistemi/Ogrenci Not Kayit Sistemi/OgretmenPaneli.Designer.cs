namespace Ogrenci_Not_Kayit_Sistemi
{
    partial class OgretmenPaneli
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.mskNumara = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.mskSinav1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mskSinav2 = new System.Windows.Forms.MaskedTextBox();
            this.mskSinav3 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelKS = new System.Windows.Forms.Label();
            this.labelGS = new System.Windows.Forms.Label();
            this.labelOrt = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.notKayitVeriTabaniDataSet = new Ogrenci_Not_Kayit_Sistemi.NotKayitVeriTabaniDataSet();
            this.dersTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dersTBLTableAdapter = new Ogrenci_Not_Kayit_Sistemi.NotKayitVeriTabaniDataSetTableAdapters.DersTBLTableAdapter();
            this.ogrIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrNumaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSinav1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSinav2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSinav3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrOrtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notKayitVeriTabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.mskNumara);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(218, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Ekle";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(19, 136);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Öğrenci Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(112, 96);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(76, 30);
            this.txtSoyad.TabIndex = 6;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(112, 60);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(76, 30);
            this.txtAd.TabIndex = 5;
            // 
            // mskNumara
            // 
            this.mskNumara.Location = new System.Drawing.Point(112, 26);
            this.mskNumara.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskNumara.Mask = "0000";
            this.mskNumara.Name = "mskNumara";
            this.mskNumara.Size = new System.Drawing.Size(76, 30);
            this.mskNumara.TabIndex = 4;
            this.mskNumara.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelOrt);
            this.groupBox2.Controls.Add(this.labelGS);
            this.groupBox2.Controls.Add(this.labelKS);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.mskSinav3);
            this.groupBox2.Controls.Add(this.mskSinav2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.mskSinav1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(237, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(442, 201);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sınav Notları";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(22, 136);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mskSinav1
            // 
            this.mskSinav1.Location = new System.Drawing.Point(116, 26);
            this.mskSinav1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskSinav1.Mask = "000";
            this.mskSinav1.Name = "mskSinav1";
            this.mskSinav1.Size = new System.Drawing.Size(76, 30);
            this.mskSinav1.TabIndex = 4;
            this.mskSinav1.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sınav 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sınav 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sınav 1:";
            // 
            // mskSinav2
            // 
            this.mskSinav2.Location = new System.Drawing.Point(116, 60);
            this.mskSinav2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskSinav2.Mask = "000";
            this.mskSinav2.Name = "mskSinav2";
            this.mskSinav2.Size = new System.Drawing.Size(76, 30);
            this.mskSinav2.TabIndex = 8;
            this.mskSinav2.ValidatingType = typeof(int);
            // 
            // mskSinav3
            // 
            this.mskSinav3.Location = new System.Drawing.Point(116, 96);
            this.mskSinav3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskSinav3.Mask = "000";
            this.mskSinav3.Name = "mskSinav3";
            this.mskSinav3.Size = new System.Drawing.Size(76, 30);
            this.mskSinav3.TabIndex = 9;
            this.mskSinav3.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ortalama:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 90);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Geçen Sayısı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 121);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "Kalan Sayısı:";
            // 
            // labelKS
            // 
            this.labelKS.AutoSize = true;
            this.labelKS.Location = new System.Drawing.Point(368, 121);
            this.labelKS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKS.Name = "labelKS";
            this.labelKS.Size = new System.Drawing.Size(34, 24);
            this.labelKS.TabIndex = 13;
            this.labelKS.Text = "00";
            // 
            // labelGS
            // 
            this.labelGS.AutoSize = true;
            this.labelGS.Location = new System.Drawing.Point(368, 90);
            this.labelGS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGS.Name = "labelGS";
            this.labelGS.Size = new System.Drawing.Size(34, 24);
            this.labelGS.TabIndex = 14;
            this.labelGS.Text = "00";
            // 
            // labelOrt
            // 
            this.labelOrt.AutoSize = true;
            this.labelOrt.Location = new System.Drawing.Point(368, 59);
            this.labelOrt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrt.Name = "labelOrt";
            this.labelOrt.Size = new System.Drawing.Size(34, 24);
            this.labelOrt.TabIndex = 15;
            this.labelOrt.Text = "00";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(15, 221);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(664, 321);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrIDDataGridViewTextBoxColumn,
            this.ogrNumaraDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrSinav1DataGridViewTextBoxColumn,
            this.ogrSinav2DataGridViewTextBoxColumn,
            this.ogrSinav3DataGridViewTextBoxColumn,
            this.ogrOrtDataGridViewTextBoxColumn,
            this.ogrDurumDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.dersTBLBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(660, 294);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // notKayitVeriTabaniDataSet
            // 
            this.notKayitVeriTabaniDataSet.DataSetName = "NotKayitVeriTabaniDataSet";
            this.notKayitVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dersTBLBindingSource
            // 
            this.dersTBLBindingSource.DataMember = "DersTBL";
            this.dersTBLBindingSource.DataSource = this.notKayitVeriTabaniDataSet;
            // 
            // dersTBLTableAdapter
            // 
            this.dersTBLTableAdapter.ClearBeforeFill = true;
            // 
            // ogrIDDataGridViewTextBoxColumn
            // 
            this.ogrIDDataGridViewTextBoxColumn.DataPropertyName = "OgrID";
            this.ogrIDDataGridViewTextBoxColumn.HeaderText = "OgrID";
            this.ogrIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrIDDataGridViewTextBoxColumn.Name = "ogrIDDataGridViewTextBoxColumn";
            this.ogrIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrNumaraDataGridViewTextBoxColumn
            // 
            this.ogrNumaraDataGridViewTextBoxColumn.DataPropertyName = "OgrNumara";
            this.ogrNumaraDataGridViewTextBoxColumn.HeaderText = "OgrNumara";
            this.ogrNumaraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrNumaraDataGridViewTextBoxColumn.Name = "ogrNumaraDataGridViewTextBoxColumn";
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            // 
            // ogrSinav1DataGridViewTextBoxColumn
            // 
            this.ogrSinav1DataGridViewTextBoxColumn.DataPropertyName = "OgrSinav1";
            this.ogrSinav1DataGridViewTextBoxColumn.HeaderText = "OgrSinav1";
            this.ogrSinav1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrSinav1DataGridViewTextBoxColumn.Name = "ogrSinav1DataGridViewTextBoxColumn";
            // 
            // ogrSinav2DataGridViewTextBoxColumn
            // 
            this.ogrSinav2DataGridViewTextBoxColumn.DataPropertyName = "OgrSinav2";
            this.ogrSinav2DataGridViewTextBoxColumn.HeaderText = "OgrSinav2";
            this.ogrSinav2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrSinav2DataGridViewTextBoxColumn.Name = "ogrSinav2DataGridViewTextBoxColumn";
            // 
            // ogrSinav3DataGridViewTextBoxColumn
            // 
            this.ogrSinav3DataGridViewTextBoxColumn.DataPropertyName = "OgrSinav3";
            this.ogrSinav3DataGridViewTextBoxColumn.HeaderText = "OgrSinav3";
            this.ogrSinav3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrSinav3DataGridViewTextBoxColumn.Name = "ogrSinav3DataGridViewTextBoxColumn";
            // 
            // ogrOrtDataGridViewTextBoxColumn
            // 
            this.ogrOrtDataGridViewTextBoxColumn.DataPropertyName = "OgrOrt";
            this.ogrOrtDataGridViewTextBoxColumn.HeaderText = "OgrOrt";
            this.ogrOrtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrOrtDataGridViewTextBoxColumn.Name = "ogrOrtDataGridViewTextBoxColumn";
            // 
            // ogrDurumDataGridViewCheckBoxColumn
            // 
            this.ogrDurumDataGridViewCheckBoxColumn.DataPropertyName = "OgrDurum";
            this.ogrDurumDataGridViewCheckBoxColumn.HeaderText = "OgrDurum";
            this.ogrDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.ogrDurumDataGridViewCheckBoxColumn.Name = "ogrDurumDataGridViewCheckBoxColumn";
            // 
            // OgretmenPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(692, 552);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OgretmenPaneli";
            this.Text = "Öğretmen Paneli";
            this.Load += new System.EventHandler(this.OgretmenPaneli_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notKayitVeriTabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersTBLBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox mskNumara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox mskSinav1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskSinav3;
        private System.Windows.Forms.MaskedTextBox mskSinav2;
        private System.Windows.Forms.Label labelKS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelOrt;
        private System.Windows.Forms.Label labelGS;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NotKayitVeriTabaniDataSet notKayitVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource dersTBLBindingSource;
        private NotKayitVeriTabaniDataSetTableAdapters.DersTBLTableAdapter dersTBLTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrNumaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSinav1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSinav2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSinav3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrOrtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ogrDurumDataGridViewCheckBoxColumn;
    }
}