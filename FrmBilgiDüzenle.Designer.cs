namespace Proje_Hastane
{
    partial class FrmBilgiDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgiDüzenle));
            label6 = new Label();
            CmbCinsiyet = new ComboBox();
            MskTelefon = new MaskedTextBox();
            TxtSifre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            TxtSoyad = new TextBox();
            label1 = new Label();
            TxtAd = new TextBox();
            MskTc = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            BtnBilgiGüncelle = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(102, 266);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(77, 23);
            label6.TabIndex = 30;
            label6.Text = "Cinsiyet:";
            // 
            // CmbCinsiyet
            // 
            CmbCinsiyet.FormattingEnabled = true;
            CmbCinsiyet.ItemHeight = 23;
            CmbCinsiyet.Items.AddRange(new object[] { "ERKEK", "KADIN" });
            CmbCinsiyet.Location = new Point(187, 263);
            CmbCinsiyet.Name = "CmbCinsiyet";
            CmbCinsiyet.Size = new Size(149, 31);
            CmbCinsiyet.TabIndex = 6;
            // 
            // MskTelefon
            // 
            MskTelefon.Location = new Point(187, 186);
            MskTelefon.Margin = new Padding(4);
            MskTelefon.Mask = "(999) 000-0000";
            MskTelefon.Name = "MskTelefon";
            MskTelefon.Size = new Size(149, 31);
            MskTelefon.TabIndex = 4;
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(187, 225);
            TxtSifre.Margin = new Padding(4);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(149, 31);
            TxtSifre.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(129, 228);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 23);
            label5.TabIndex = 26;
            label5.Text = "Şifre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 186);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 23);
            label4.TabIndex = 25;
            label4.Text = "Telefon:";
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(187, 105);
            TxtSoyad.Margin = new Padding(4);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(149, 31);
            TxtSoyad.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 108);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 23;
            label1.Text = "Soyad:";
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(187, 66);
            TxtAd.Margin = new Padding(4);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(149, 31);
            TxtAd.TabIndex = 1;
            // 
            // MskTc
            // 
            MskTc.Location = new Point(187, 144);
            MskTc.Margin = new Padding(4);
            MskTc.Mask = "00000000000";
            MskTc.Name = "MskTc";
            MskTc.Size = new Size(149, 31);
            MskTc.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 69);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(37, 23);
            label3.TabIndex = 20;
            label3.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 147);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 23);
            label2.TabIndex = 19;
            label2.Text = "TC Kimlik No:";
            // 
            // BtnBilgiGüncelle
            // 
            BtnBilgiGüncelle.BackColor = Color.FromArgb(255, 128, 128);
            BtnBilgiGüncelle.Location = new Point(187, 300);
            BtnBilgiGüncelle.Name = "BtnBilgiGüncelle";
            BtnBilgiGüncelle.Size = new Size(149, 33);
            BtnBilgiGüncelle.TabIndex = 7;
            BtnBilgiGüncelle.Text = "Güncelle";
            BtnBilgiGüncelle.UseVisualStyleBackColor = false;
            BtnBilgiGüncelle.Click += BtnBilgiGüncelle_Click;
            // 
            // FrmBilgiDüzenle
            // 
            AcceptButton = BtnBilgiGüncelle;
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(497, 422);
            Controls.Add(BtnBilgiGüncelle);
            Controls.Add(label6);
            Controls.Add(CmbCinsiyet);
            Controls.Add(MskTelefon);
            Controls.Add(TxtSifre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TxtSoyad);
            Controls.Add(label1);
            Controls.Add(TxtAd);
            Controls.Add(MskTc);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FrmBilgiDüzenle";
            Text = "Bilgi Güncelleme";
            Load += FrmBilgiDüzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private ComboBox CmbCinsiyet;
        private MaskedTextBox MskTelefon;
        private TextBox TxtSifre;
        private Label label5;
        private Label label4;
        private TextBox TxtSoyad;
        private Label label1;
        private TextBox TxtAd;
        private MaskedTextBox MskTc;
        private Label label3;
        private Label label2;
        private Button BtnBilgiGüncelle;
    }
}