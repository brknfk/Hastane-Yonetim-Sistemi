namespace Proje_Hastane
{
    partial class FrmGirisler
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            BtnHastaGiris = new Button();
            BtnDoktorGiris = new Button();
            BtnSekreterGiris = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnHastaGiris
            // 
            BtnHastaGiris.BackgroundImage = (Image)resources.GetObject("BtnHastaGiris.BackgroundImage");
            BtnHastaGiris.BackgroundImageLayout = ImageLayout.Stretch;
            BtnHastaGiris.Location = new Point(33, 285);
            BtnHastaGiris.Name = "BtnHastaGiris";
            BtnHastaGiris.Size = new Size(157, 131);
            BtnHastaGiris.TabIndex = 0;
            BtnHastaGiris.UseVisualStyleBackColor = true;
            BtnHastaGiris.Click += BtnHastaGiris_Click;
            // 
            // BtnDoktorGiris
            // 
            BtnDoktorGiris.BackgroundImage = (Image)resources.GetObject("BtnDoktorGiris.BackgroundImage");
            BtnDoktorGiris.BackgroundImageLayout = ImageLayout.Stretch;
            BtnDoktorGiris.Location = new Point(245, 285);
            BtnDoktorGiris.Name = "BtnDoktorGiris";
            BtnDoktorGiris.Size = new Size(159, 131);
            BtnDoktorGiris.TabIndex = 1;
            BtnDoktorGiris.UseVisualStyleBackColor = true;
            BtnDoktorGiris.Click += BtnDoktorGiris_Click;
            // 
            // BtnSekreterGiris
            // 
            BtnSekreterGiris.BackgroundImage = (Image)resources.GetObject("BtnSekreterGiris.BackgroundImage");
            BtnSekreterGiris.BackgroundImageLayout = ImageLayout.Stretch;
            BtnSekreterGiris.Location = new Point(458, 285);
            BtnSekreterGiris.Name = "BtnSekreterGiris";
            BtnSekreterGiris.Size = new Size(161, 131);
            BtnSekreterGiris.TabIndex = 2;
            BtnSekreterGiris.UseVisualStyleBackColor = true;
            BtnSekreterGiris.Click += BtnSekreterGiris_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 419);
            label1.Name = "label1";
            label1.Size = new Size(49, 18);
            label1.TabIndex = 3;
            label1.Text = "Hasta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 419);
            label2.Name = "label2";
            label2.Size = new Size(57, 18);
            label2.TabIndex = 4;
            label2.Text = "Doktor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(505, 419);
            label3.Name = "label3";
            label3.Size = new Size(70, 18);
            label3.TabIndex = 5;
            label3.Text = "Sekreter";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(210, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Wide Latin", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(187, 31);
            label4.Name = "label4";
            label4.Size = new Size(272, 33);
            label4.TabIndex = 7;
            label4.Text = "HASTANE";
            // 
            // FrmGirisler
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(658, 540);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnSekreterGiris);
            Controls.Add(BtnDoktorGiris);
            Controls.Add(BtnHastaGiris);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimizeBox = false;
            Name = "FrmGirisler";
            Text = "Hastane Giriş";
            Load += FrmGirisler_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnHastaGiris;
        private Button BtnDoktorGiris;
        private Button BtnSekreterGiris;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
    }
}
