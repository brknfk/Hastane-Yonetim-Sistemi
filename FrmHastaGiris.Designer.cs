namespace Proje_Hastane
{
    partial class FrmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiris));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            MskTc = new MaskedTextBox();
            TxtSifre = new TextBox();
            LnkUyeOl = new LinkLabel();
            BtnGirisYap = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(197, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 128);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 18);
            label2.TabIndex = 1;
            label2.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(243, 186);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 18);
            label3.TabIndex = 2;
            label3.Text = "Şifre:";
            // 
            // MskTc
            // 
            MskTc.Location = new Point(301, 125);
            MskTc.Margin = new Padding(4);
            MskTc.Mask = "00000000000";
            MskTc.Name = "MskTc";
            MskTc.Size = new Size(149, 26);
            MskTc.TabIndex = 3;
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(301, 183);
            TxtSifre.Margin = new Padding(4);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(149, 26);
            TxtSifre.TabIndex = 4;
            TxtSifre.UseSystemPasswordChar = true;
            // 
            // LnkUyeOl
            // 
            LnkUyeOl.AutoSize = true;
            LnkUyeOl.Location = new Point(343, 277);
            LnkUyeOl.Margin = new Padding(4, 0, 4, 0);
            LnkUyeOl.Name = "LnkUyeOl";
            LnkUyeOl.Size = new Size(57, 18);
            LnkUyeOl.TabIndex = 5;
            LnkUyeOl.TabStop = true;
            LnkUyeOl.Text = "Üye Ol";
            LnkUyeOl.LinkClicked += LnkUyeOl_LinkClicked;
            // 
            // BtnGirisYap
            // 
            BtnGirisYap.Location = new Point(325, 225);
            BtnGirisYap.Margin = new Padding(4);
            BtnGirisYap.Name = "BtnGirisYap";
            BtnGirisYap.Size = new Size(96, 28);
            BtnGirisYap.TabIndex = 6;
            BtnGirisYap.Text = "Giriş Yap";
            BtnGirisYap.UseVisualStyleBackColor = true;
            BtnGirisYap.Click += BtnGirisYap_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(197, 9);
            label4.Name = "label4";
            label4.Size = new Size(334, 51);
            label4.TabIndex = 7;
            label4.Text = "Hasta Giris Paneli";
            // 
            // FrmHastaGiris
            // 
            AcceptButton = BtnGirisYap;
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(724, 397);
            Controls.Add(label4);
            Controls.Add(BtnGirisYap);
            Controls.Add(LnkUyeOl);
            Controls.Add(TxtSifre);
            Controls.Add(MskTc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FrmHastaGiris";
            Text = "FrmHastaGiris";
            Load += FrmHastaGiris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private MaskedTextBox MskTc;
        private TextBox TxtSifre;
        private LinkLabel LnkUyeOl;
        private Button BtnGirisYap;
        private Label label4;
    }
}