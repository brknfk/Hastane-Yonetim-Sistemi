namespace Proje_Hastane
{
    partial class FrmBrans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBrans));
            BtnGuncelle = new Button();
            BtnSil = new Button();
            BtnEkle = new Button();
            dataGridView1 = new DataGridView();
            TxtBransAd = new TextBox();
            label1 = new Label();
            Txtid = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Location = new Point(92, 174);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(133, 30);
            BtnGuncelle.TabIndex = 36;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // BtnSil
            // 
            BtnSil.Location = new Point(161, 138);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(63, 30);
            BtnSil.TabIndex = 35;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = true;
            BtnSil.Click += BtnSil_Click;
            // 
            // BtnEkle
            // 
            BtnEkle.Location = new Point(92, 138);
            BtnEkle.Name = "BtnEkle";
            BtnEkle.Size = new Size(63, 30);
            BtnEkle.TabIndex = 34;
            BtnEkle.Text = "Ekle";
            BtnEkle.UseVisualStyleBackColor = true;
            BtnEkle.Click += BtnEkle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(251, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(335, 156);
            dataGridView1.TabIndex = 33;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // TxtBransAd
            // 
            TxtBransAd.Location = new Point(92, 90);
            TxtBransAd.Name = "TxtBransAd";
            TxtBransAd.Size = new Size(133, 31);
            TxtBransAd.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 90);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 26;
            label1.Text = "Branş Ad:";
            // 
            // Txtid
            // 
            Txtid.Location = new Point(92, 48);
            Txtid.Name = "Txtid";
            Txtid.Size = new Size(133, 31);
            Txtid.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 51);
            label5.Name = "label5";
            label5.Size = new Size(78, 23);
            label5.TabIndex = 23;
            label5.Text = "Brans İd:";
            // 
            // FrmBrans
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(626, 233);
            Controls.Add(BtnGuncelle);
            Controls.Add(BtnSil);
            Controls.Add(BtnEkle);
            Controls.Add(dataGridView1);
            Controls.Add(TxtBransAd);
            Controls.Add(label1);
            Controls.Add(Txtid);
            Controls.Add(label5);
            Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FrmBrans";
            Text = "Brans Paneli";
            Load += FrmBrans_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGuncelle;
        private Button BtnSil;
        private Button BtnEkle;
        private DataGridView dataGridView1;
        private TextBox TxtBransAd;
        private Label label1;
        private TextBox Txtid;
        private Label label5;
    }
}