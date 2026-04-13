namespace Proje_Hastane
{
    partial class FrmHastaKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayıt));
            TxtAd = new TextBox();
            MskTc = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            TxtSoyad = new TextBox();
            label1 = new Label();
            label4 = new Label();
            TxtSifre = new TextBox();
            label5 = new Label();
            MskTelefon = new MaskedTextBox();
            CmbCinsiyet = new ComboBox();
            label6 = new Label();
            BtnKayıtYap = new Button();
            SuspendLayout();
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(136, 79);
            TxtAd.Margin = new Padding(4);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(149, 31);
            TxtAd.TabIndex = 1;
            // 
            // MskTc
            // 
            MskTc.Location = new Point(136, 157);
            MskTc.Margin = new Padding(4);
            MskTc.Mask = "00000000000";
            MskTc.Name = "MskTc";
            MskTc.Size = new Size(149, 31);
            MskTc.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 82);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(37, 23);
            label3.TabIndex = 6;
            label3.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 160);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 23);
            label2.TabIndex = 5;
            label2.Text = "TC Kimlik No:";
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(136, 118);
            TxtSoyad.Margin = new Padding(4);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(149, 31);
            TxtSoyad.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 121);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 9;
            label1.Text = "Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 199);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 23);
            label4.TabIndex = 11;
            label4.Text = "Telefon:";
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(136, 238);
            TxtSifre.Margin = new Padding(4);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(149, 31);
            TxtSifre.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 241);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 23);
            label5.TabIndex = 13;
            label5.Text = "Şifre:";
            // 
            // MskTelefon
            // 
            MskTelefon.Location = new Point(136, 199);
            MskTelefon.Margin = new Padding(4);
            MskTelefon.Mask = "(999) 000-0000";
            MskTelefon.Name = "MskTelefon";
            MskTelefon.Size = new Size(149, 31);
            MskTelefon.TabIndex = 4;
            // 
            // CmbCinsiyet
            // 
            CmbCinsiyet.FormattingEnabled = true;
            CmbCinsiyet.Items.AddRange(new object[] { "ERKEK", "KADIN" });
            CmbCinsiyet.Location = new Point(136, 276);
            CmbCinsiyet.Name = "CmbCinsiyet";
            CmbCinsiyet.Size = new Size(149, 31);
            CmbCinsiyet.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 279);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(77, 23);
            label6.TabIndex = 17;
            label6.Text = "Cinsiyet:";
            // 
            // BtnKayıtYap
            // 
            BtnKayıtYap.BackColor = Color.FromArgb(128, 255, 128);
            BtnKayıtYap.Location = new Point(136, 313);
            BtnKayıtYap.Name = "BtnKayıtYap";
            BtnKayıtYap.Size = new Size(149, 33);
            BtnKayıtYap.TabIndex = 7;
            BtnKayıtYap.Text = "Kayıt Yap";
            BtnKayıtYap.UseVisualStyleBackColor = false;
            BtnKayıtYap.Click += BtnKayıtYap_Click;
            // 
            // FrmHastaKayıt
            // 
            AcceptButton = BtnKayıtYap;
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(353, 472);
            Controls.Add(BtnKayıtYap);
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
            Name = "FrmHastaKayıt";
            Text = "Hasta Kayıt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtAd;
        private MaskedTextBox MskTc;
        private Label label3;
        private Label label2;
        private TextBox TxtSoyad;
        private Label label1;
        private Label label4;
        private TextBox TxtSifre;
        private Label label5;
        private MaskedTextBox MskTelefon;
        private ComboBox CmbCinsiyet;
        private Label label6;
        private Button BtnKayıtYap;
    }
}