namespace Proje_Hastane
{
    partial class FrmSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDetay));
            groupBox1 = new GroupBox();
            LblAdSoyad = new Label();
            LblTC = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            BtnDuyuruOlustur = new Button();
            RchDuyuru = new RichTextBox();
            groupBox3 = new GroupBox();
            BtnRandevuKaydet = new Button();
            ChkDurum = new CheckBox();
            MskTC = new MaskedTextBox();
            CmbDoktor = new ComboBox();
            CmbBrans = new ComboBox();
            MskSaat = new MaskedTextBox();
            MskTarih = new MaskedTextBox();
            Txtid = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox5 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox6 = new GroupBox();
            BtnRandevuListe = new Button();
            BtnBransPaneli = new Button();
            BtnDoktorPaneli = new Button();
            BtnDuyurular = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LblAdSoyad);
            groupBox1.Controls.Add(LblTC);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(304, 161);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sekreter Bilgi";
            // 
            // LblAdSoyad
            // 
            LblAdSoyad.AutoSize = true;
            LblAdSoyad.Location = new Point(111, 85);
            LblAdSoyad.Name = "LblAdSoyad";
            LblAdSoyad.Size = new Size(76, 23);
            LblAdSoyad.TabIndex = 3;
            LblAdSoyad.Text = "Null Null";
            // 
            // LblTC
            // 
            LblTC.AutoSize = true;
            LblTC.Location = new Point(111, 37);
            LblTC.Name = "LblTC";
            LblTC.Size = new Size(120, 23);
            LblTC.TabIndex = 2;
            LblTC.Text = "00000000000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 85);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 1;
            label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 37);
            label1.Name = "label1";
            label1.Size = new Size(68, 23);
            label1.TabIndex = 0;
            label1.Text = "TC NO:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnDuyuruOlustur);
            groupBox2.Controls.Add(RchDuyuru);
            groupBox2.Location = new Point(12, 179);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(304, 176);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Duyuru Oluştur";
            // 
            // BtnDuyuruOlustur
            // 
            BtnDuyuruOlustur.Location = new Point(6, 132);
            BtnDuyuruOlustur.Name = "BtnDuyuruOlustur";
            BtnDuyuruOlustur.Size = new Size(292, 38);
            BtnDuyuruOlustur.TabIndex = 1;
            BtnDuyuruOlustur.Text = "Oluştur";
            BtnDuyuruOlustur.UseVisualStyleBackColor = true;
            BtnDuyuruOlustur.Click += BtnDuyuruOlustur_Click;
            // 
            // RchDuyuru
            // 
            RchDuyuru.Location = new Point(6, 30);
            RchDuyuru.Name = "RchDuyuru";
            RchDuyuru.Size = new Size(292, 96);
            RchDuyuru.TabIndex = 0;
            RchDuyuru.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnRandevuKaydet);
            groupBox3.Controls.Add(ChkDurum);
            groupBox3.Controls.Add(MskTC);
            groupBox3.Controls.Add(CmbDoktor);
            groupBox3.Controls.Add(CmbBrans);
            groupBox3.Controls.Add(MskSaat);
            groupBox3.Controls.Add(MskTarih);
            groupBox3.Controls.Add(Txtid);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(322, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(304, 393);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Paneli";
            // 
            // BtnRandevuKaydet
            // 
            BtnRandevuKaydet.Location = new Point(6, 288);
            BtnRandevuKaydet.Name = "BtnRandevuKaydet";
            BtnRandevuKaydet.Size = new Size(292, 38);
            BtnRandevuKaydet.TabIndex = 16;
            BtnRandevuKaydet.Text = "Kaydet";
            BtnRandevuKaydet.UseVisualStyleBackColor = true;
            BtnRandevuKaydet.Click += BtnRandevuKaydet_Click;
            // 
            // ChkDurum
            // 
            ChkDurum.AutoSize = true;
            ChkDurum.Location = new Point(83, 255);
            ChkDurum.Name = "ChkDurum";
            ChkDurum.Size = new Size(84, 27);
            ChkDurum.TabIndex = 14;
            ChkDurum.Text = "Durum";
            ChkDurum.UseVisualStyleBackColor = true;
            // 
            // MskTC
            // 
            MskTC.Location = new Point(83, 218);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(133, 31);
            MskTC.TabIndex = 13;
            MskTC.ValidatingType = typeof(int);
            // 
            // CmbDoktor
            // 
            CmbDoktor.FormattingEnabled = true;
            CmbDoktor.Location = new Point(83, 181);
            CmbDoktor.Name = "CmbDoktor";
            CmbDoktor.Size = new Size(133, 31);
            CmbDoktor.TabIndex = 12;
            // 
            // CmbBrans
            // 
            CmbBrans.FormattingEnabled = true;
            CmbBrans.Location = new Point(83, 145);
            CmbBrans.Name = "CmbBrans";
            CmbBrans.Size = new Size(133, 31);
            CmbBrans.TabIndex = 11;
            CmbBrans.SelectedIndexChanged += CmbBrans_SelectedIndexChanged;
            // 
            // MskSaat
            // 
            MskSaat.Location = new Point(83, 108);
            MskSaat.Mask = "00:00";
            MskSaat.Name = "MskSaat";
            MskSaat.Size = new Size(133, 31);
            MskSaat.TabIndex = 10;
            MskSaat.ValidatingType = typeof(DateTime);
            // 
            // MskTarih
            // 
            MskTarih.Location = new Point(83, 71);
            MskTarih.Mask = "00/00/0000";
            MskTarih.Name = "MskTarih";
            MskTarih.Size = new Size(133, 31);
            MskTarih.TabIndex = 9;
            MskTarih.ValidatingType = typeof(DateTime);
            // 
            // Txtid
            // 
            Txtid.Location = new Point(83, 34);
            Txtid.Name = "Txtid";
            Txtid.Size = new Size(133, 31);
            Txtid.TabIndex = 8;
            Txtid.TextChanged += textBox1_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(40, 221);
            label10.Name = "label10";
            label10.Size = new Size(37, 23);
            label10.TabIndex = 6;
            label10.Text = "TC:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 184);
            label9.Name = "label9";
            label9.Size = new Size(70, 23);
            label9.TabIndex = 5;
            label9.Text = "Doktor:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 148);
            label8.Name = "label8";
            label8.Size = new Size(59, 23);
            label8.TabIndex = 4;
            label8.Text = "Branş:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 111);
            label7.Name = "label7";
            label7.Size = new Size(50, 23);
            label7.TabIndex = 3;
            label7.Text = "Saat:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 74);
            label6.Name = "label6";
            label6.Size = new Size(54, 23);
            label6.TabIndex = 2;
            label6.Text = "Tarih:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 34);
            label5.Name = "label5";
            label5.Size = new Size(29, 23);
            label5.TabIndex = 1;
            label5.Text = "id:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(632, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(375, 232);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(369, 202);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridView2);
            groupBox5.Location = new Point(635, 255);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(375, 294);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 27);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(369, 264);
            dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(BtnDuyurular);
            groupBox6.Controls.Add(BtnRandevuListe);
            groupBox6.Controls.Add(BtnBransPaneli);
            groupBox6.Controls.Add(BtnDoktorPaneli);
            groupBox6.Location = new Point(12, 361);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(312, 188);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "Hızlı Erişim";
            // 
            // BtnRandevuListe
            // 
            BtnRandevuListe.Location = new Point(6, 99);
            BtnRandevuListe.Name = "BtnRandevuListe";
            BtnRandevuListe.Size = new Size(292, 34);
            BtnRandevuListe.TabIndex = 2;
            BtnRandevuListe.Text = "Randevu Liste";
            BtnRandevuListe.UseVisualStyleBackColor = true;
            BtnRandevuListe.Click += BtnRandevuListe_Click;
            // 
            // BtnBransPaneli
            // 
            BtnBransPaneli.Location = new Point(6, 61);
            BtnBransPaneli.Name = "BtnBransPaneli";
            BtnBransPaneli.Size = new Size(292, 34);
            BtnBransPaneli.TabIndex = 1;
            BtnBransPaneli.Text = "Branş Paneli";
            BtnBransPaneli.UseVisualStyleBackColor = true;
            BtnBransPaneli.Click += BtnBransPaneli_Click;
            // 
            // BtnDoktorPaneli
            // 
            BtnDoktorPaneli.Location = new Point(6, 21);
            BtnDoktorPaneli.Name = "BtnDoktorPaneli";
            BtnDoktorPaneli.Size = new Size(292, 34);
            BtnDoktorPaneli.TabIndex = 0;
            BtnDoktorPaneli.Text = "Doktor Paneli";
            BtnDoktorPaneli.UseVisualStyleBackColor = true;
            BtnDoktorPaneli.Click += BtnDoktorPaneli_Click;
            // 
            // BtnDuyurular
            // 
            BtnDuyurular.Location = new Point(6, 139);
            BtnDuyurular.Name = "BtnDuyurular";
            BtnDuyurular.Size = new Size(292, 34);
            BtnDuyurular.TabIndex = 3;
            BtnDuyurular.Text = "Duyurular";
            BtnDuyurular.UseVisualStyleBackColor = true;
            BtnDuyurular.Click += BtnDuyurular_Click;
            // 
            // FrmSekreterDetay
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(1019, 587);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FrmSekreterDetay";
            Text = "Sekreter Detay";
            Load += FrmSekreterDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label LblTC;
        private Label label2;
        private Label label1;
        private Label LblAdSoyad;
        private GroupBox groupBox2;
        private Button BtnDuyuruOlustur;
        private RichTextBox RchDuyuru;
        private GroupBox groupBox3;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private MaskedTextBox MskTarih;
        private TextBox Txtid;
        private Button BtnRandevuKaydet;
        private CheckBox ChkDurum;
        private MaskedTextBox MskTC;
        private ComboBox CmbDoktor;
        private ComboBox CmbBrans;
        private MaskedTextBox MskSaat;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private GroupBox groupBox5;
        private DataGridView dataGridView2;
        private GroupBox groupBox6;
        private Button BtnBransPaneli;
        private Button BtnDoktorPaneli;
        private Button BtnRandevuListe;
        private Button BtnDuyurular;
    }
}