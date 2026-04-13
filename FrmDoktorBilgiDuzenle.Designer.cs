namespace Proje_Hastane
{
    partial class FrmDoktorBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorBilgiDuzenle));
            TxtSifre = new TextBox();
            label5 = new Label();
            TxtSoyad = new TextBox();
            label1 = new Label();
            TxtAd = new TextBox();
            MskTc = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            CmbBrans = new ComboBox();
            label4 = new Label();
            BtnBilgiGüncelle = new Button();
            SuspendLayout();
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(129, 207);
            TxtSifre.Margin = new Padding(4);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(149, 31);
            TxtSifre.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 210);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 23);
            label5.TabIndex = 34;
            label5.Text = "Şifre:";
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(129, 87);
            TxtSoyad.Margin = new Padding(4);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(149, 31);
            TxtSoyad.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 90);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 32;
            label1.Text = "Soyad:";
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(129, 48);
            TxtAd.Margin = new Padding(4);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(149, 31);
            TxtAd.TabIndex = 31;
            // 
            // MskTc
            // 
            MskTc.Location = new Point(129, 126);
            MskTc.Margin = new Padding(4);
            MskTc.Mask = "00000000000";
            MskTc.Name = "MskTc";
            MskTc.Size = new Size(149, 31);
            MskTc.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 51);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(37, 23);
            label3.TabIndex = 29;
            label3.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 129);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 23);
            label2.TabIndex = 28;
            label2.Text = "TC Kimlik No:";
            // 
            // CmbBrans
            // 
            CmbBrans.FormattingEnabled = true;
            CmbBrans.Location = new Point(129, 164);
            CmbBrans.Name = "CmbBrans";
            CmbBrans.Size = new Size(149, 31);
            CmbBrans.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 172);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(59, 23);
            label4.TabIndex = 37;
            label4.Text = "Branş:";
            // 
            // BtnBilgiGüncelle
            // 
            BtnBilgiGüncelle.BackColor = Color.FromArgb(255, 128, 128);
            BtnBilgiGüncelle.Location = new Point(129, 245);
            BtnBilgiGüncelle.Name = "BtnBilgiGüncelle";
            BtnBilgiGüncelle.Size = new Size(149, 33);
            BtnBilgiGüncelle.TabIndex = 38;
            BtnBilgiGüncelle.Text = "Güncelle";
            BtnBilgiGüncelle.UseVisualStyleBackColor = false;
            BtnBilgiGüncelle.Click += BtnBilgiGüncelle_Click;
            // 
            // FrmDoktorBilgiDuzenle
            // 
            AcceptButton = BtnBilgiGüncelle;
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(343, 308);
            Controls.Add(BtnBilgiGüncelle);
            Controls.Add(label4);
            Controls.Add(CmbBrans);
            Controls.Add(TxtSifre);
            Controls.Add(label5);
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
            Name = "FrmDoktorBilgiDuzenle";
            Text = "Doktor Bilgi Güncelle";
            Load += FrmDoktorBilgiDuzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtSifre;
        private Label label5;
        private TextBox TxtSoyad;
        private Label label1;
        private TextBox TxtAd;
        private MaskedTextBox MskTc;
        private Label label3;
        private Label label2;
        private ComboBox CmbBrans;
        private Label label4;
        private Button BtnBilgiGüncelle;
    }
}