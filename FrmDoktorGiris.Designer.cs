namespace Proje_Hastane
{
    partial class FrmDoktorGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorGiris));
            label4 = new Label();
            BtnGirisYap = new Button();
            TxtSifre = new TextBox();
            MskTc = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightSeaGreen;
            label4.Font = new Font("Segoe Script", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(143, 64);
            label4.Name = "label4";
            label4.Size = new Size(357, 51);
            label4.TabIndex = 15;
            label4.Text = "Doktor Giris Paneli";
            // 
            // BtnGirisYap
            // 
            BtnGirisYap.Location = new Point(271, 280);
            BtnGirisYap.Margin = new Padding(4);
            BtnGirisYap.Name = "BtnGirisYap";
            BtnGirisYap.Size = new Size(98, 34);
            BtnGirisYap.TabIndex = 14;
            BtnGirisYap.Text = "Giriş Yap";
            BtnGirisYap.UseVisualStyleBackColor = true;
            BtnGirisYap.Click += BtnGirisYap_Click;
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(247, 238);
            TxtSifre.Margin = new Padding(4);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(149, 31);
            TxtSifre.TabIndex = 12;
            TxtSifre.Text = "11111";
            TxtSifre.UseSystemPasswordChar = true;
            // 
            // MskTc
            // 
            MskTc.Location = new Point(247, 180);
            MskTc.Margin = new Padding(4);
            MskTc.Mask = "00000000000";
            MskTc.Name = "MskTc";
            MskTc.Size = new Size(149, 31);
            MskTc.TabIndex = 11;
            MskTc.Text = "11111111112";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 241);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 23);
            label3.TabIndex = 10;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 183);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 23);
            label2.TabIndex = 9;
            label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(143, 99);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 8;
            // 
            // FrmDoktorGiris
            // 
            AcceptButton = BtnGirisYap;
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(587, 350);
            Controls.Add(label4);
            Controls.Add(BtnGirisYap);
            Controls.Add(TxtSifre);
            Controls.Add(MskTc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FrmDoktorGiris";
            Text = "Doktor Giriş";
            Load += FrmDoktorGiris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button BtnGirisYap;
        private TextBox TxtSifre;
        private MaskedTextBox MskTc;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}