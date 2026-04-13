namespace Proje_Hastane
{
    partial class FrmDoktorPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorPaneli));
            TxtAd = new TextBox();
            label5 = new Label();
            CmbBrans = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            MskTC = new MaskedTextBox();
            TxtSoyad = new TextBox();
            TxtSifre = new TextBox();
            dataGridView1 = new DataGridView();
            BtnEkle = new Button();
            BtnSil = new Button();
            BtnGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(93, 24);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(133, 31);
            TxtAd.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 27);
            label5.Name = "label5";
            label5.Size = new Size(37, 23);
            label5.TabIndex = 9;
            label5.Text = "Ad:";
            // 
            // CmbBrans
            // 
            CmbBrans.FormattingEnabled = true;
            CmbBrans.Location = new Point(93, 109);
            CmbBrans.Name = "CmbBrans";
            CmbBrans.Size = new Size(133, 31);
            CmbBrans.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 12;
            label1.Text = "Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 109);
            label2.Name = "label2";
            label2.Size = new Size(59, 23);
            label2.TabIndex = 13;
            label2.Text = "Branş:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 149);
            label3.Name = "label3";
            label3.Size = new Size(37, 23);
            label3.TabIndex = 14;
            label3.Text = "TC:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 193);
            label4.Name = "label4";
            label4.Size = new Size(50, 23);
            label4.TabIndex = 15;
            label4.Text = "Şifre:";
            // 
            // MskTC
            // 
            MskTC.Location = new Point(93, 149);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(133, 31);
            MskTC.TabIndex = 4;
            MskTC.ValidatingType = typeof(int);
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(93, 66);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(133, 31);
            TxtSoyad.TabIndex = 2;
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(93, 193);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(133, 31);
            TxtSifre.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(249, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(775, 272);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // BtnEkle
            // 
            BtnEkle.Location = new Point(93, 230);
            BtnEkle.Name = "BtnEkle";
            BtnEkle.Size = new Size(63, 30);
            BtnEkle.TabIndex = 20;
            BtnEkle.Text = "Ekle";
            BtnEkle.UseVisualStyleBackColor = true;
            BtnEkle.Click += BtnEkle_Click;
            // 
            // BtnSil
            // 
            BtnSil.Location = new Point(162, 230);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(63, 30);
            BtnSil.TabIndex = 21;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = true;
            BtnSil.Click += BtnSil_Click;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Location = new Point(93, 266);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(133, 30);
            BtnGuncelle.TabIndex = 22;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // FrmDoktorPaneli
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(1036, 334);
            Controls.Add(BtnGuncelle);
            Controls.Add(BtnSil);
            Controls.Add(BtnEkle);
            Controls.Add(dataGridView1);
            Controls.Add(TxtSifre);
            Controls.Add(TxtSoyad);
            Controls.Add(MskTC);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CmbBrans);
            Controls.Add(TxtAd);
            Controls.Add(label5);
            Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MinimizeBox = false;
            Name = "FrmDoktorPaneli";
            Text = "Doktor Paneli";
            Load += FrmDoktorPaneli_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtAd;
        private Label label5;
        private ComboBox CmbBrans;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox MskTC;
        private TextBox TxtSoyad;
        private TextBox TxtSifre;
        private DataGridView dataGridView1;
        private Button BtnEkle;
        private Button BtnSil;
        private Button BtnGuncelle;
    }
}