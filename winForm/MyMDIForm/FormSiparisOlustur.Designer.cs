
namespace MyMDIForm
{
    partial class FormSiparisOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSiparisOlustur));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoyutlar = new System.Windows.Forms.GroupBox();
            this.rdoBüyük = new System.Windows.Forms.RadioButton();
            this.rdoOrta = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxSiparisler = new System.Windows.Forms.ListBox();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.btnSiparisiTamamla = new System.Windows.Forms.Button();
            this.flpMalzemeler = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.cmbMenüler = new System.Windows.Forms.ComboBox();
            this.rdoKucuk = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBoyutlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENÜ SEÇİN";
            // 
            // grpBoyutlar
            // 
            this.grpBoyutlar.Controls.Add(this.rdoBüyük);
            this.grpBoyutlar.Controls.Add(this.rdoKucuk);
            this.grpBoyutlar.Controls.Add(this.rdoOrta);
            this.grpBoyutlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoyutlar.Location = new System.Drawing.Point(12, 228);
            this.grpBoyutlar.Name = "grpBoyutlar";
            this.grpBoyutlar.Size = new System.Drawing.Size(223, 61);
            this.grpBoyutlar.TabIndex = 2;
            this.grpBoyutlar.TabStop = false;
            this.grpBoyutlar.Text = "BOYUT SEÇİNİZ";
            // 
            // rdoBüyük
            // 
            this.rdoBüyük.AutoSize = true;
            this.rdoBüyük.Location = new System.Drawing.Point(128, 28);
            this.rdoBüyük.Name = "rdoBüyük";
            this.rdoBüyük.Size = new System.Drawing.Size(60, 17);
            this.rdoBüyük.TabIndex = 1;
            this.rdoBüyük.TabStop = true;
            this.rdoBüyük.Text = "Büyük";
            this.rdoBüyük.UseVisualStyleBackColor = true;
            // 
            // rdoOrta
            // 
            this.rdoOrta.AutoSize = true;
            this.rdoOrta.Location = new System.Drawing.Point(73, 28);
            this.rdoOrta.Name = "rdoOrta";
            this.rdoOrta.Size = new System.Drawing.Size(49, 17);
            this.rdoOrta.TabIndex = 1;
            this.rdoOrta.TabStop = true;
            this.rdoOrta.Text = "Orta";
            this.rdoOrta.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "MALZEME SEÇİN";
            // 
            // lbxSiparisler
            // 
            this.lbxSiparisler.FormattingEnabled = true;
            this.lbxSiparisler.Location = new System.Drawing.Point(252, 12);
            this.lbxSiparisler.Name = "lbxSiparisler";
            this.lbxSiparisler.Size = new System.Drawing.Size(510, 446);
            this.lbxSiparisler.TabIndex = 4;
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(61, 460);
            this.nmrAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(163, 20);
            this.nmrAdet.TabIndex = 5;
            this.nmrAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ADET";
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparisEkle.Location = new System.Drawing.Point(18, 486);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(217, 63);
            this.btnSiparisEkle.TabIndex = 7;
            this.btnSiparisEkle.Text = "SİPARİŞ EKLE";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // btnSiparisiTamamla
            // 
            this.btnSiparisiTamamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparisiTamamla.Location = new System.Drawing.Point(553, 486);
            this.btnSiparisiTamamla.Name = "btnSiparisiTamamla";
            this.btnSiparisiTamamla.Size = new System.Drawing.Size(209, 63);
            this.btnSiparisiTamamla.TabIndex = 7;
            this.btnSiparisiTamamla.Text = "SİPARİŞİ TAMAMLA";
            this.btnSiparisiTamamla.UseVisualStyleBackColor = true;
            this.btnSiparisiTamamla.Click += new System.EventHandler(this.btnSiparisiTamamla_Click);
            // 
            // flpMalzemeler
            // 
            this.flpMalzemeler.Location = new System.Drawing.Point(15, 308);
            this.flpMalzemeler.Name = "flpMalzemeler";
            this.flpMalzemeler.Size = new System.Drawing.Size(220, 136);
            this.flpMalzemeler.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "TOPLAM TUTAR:";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplamTutar.ForeColor = System.Drawing.Color.Red;
            this.lblToplamTutar.Location = new System.Drawing.Point(362, 497);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(39, 13);
            this.lblToplamTutar.TabIndex = 10;
            this.lblToplamTutar.Text = "₺0,00";
            // 
            // cmbMenüler
            // 
            this.cmbMenüler.FormattingEnabled = true;
            this.cmbMenüler.Location = new System.Drawing.Point(15, 186);
            this.cmbMenüler.Name = "cmbMenüler";
            this.cmbMenüler.Size = new System.Drawing.Size(220, 21);
            this.cmbMenüler.TabIndex = 11;
            // 
            // rdoKucuk
            // 
            this.rdoKucuk.AutoSize = true;
            this.rdoKucuk.Location = new System.Drawing.Point(6, 28);
            this.rdoKucuk.Name = "rdoKucuk";
            this.rdoKucuk.Size = new System.Drawing.Size(61, 17);
            this.rdoKucuk.TabIndex = 1;
            this.rdoKucuk.TabStop = true;
            this.rdoKucuk.Text = "Küçük";
            this.rdoKucuk.UseVisualStyleBackColor = true;
            // 
            // FormSiparisOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 565);
            this.Controls.Add(this.cmbMenüler);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flpMalzemeler);
            this.Controls.Add(this.btnSiparisiTamamla);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.lbxSiparisler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpBoyutlar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSiparisOlustur";
            this.Text = "FormSiparisOlustur";
            this.Load += new System.EventHandler(this.FormSiparisOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBoyutlar.ResumeLayout(false);
            this.grpBoyutlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBoyutlar;
        private System.Windows.Forms.RadioButton rdoBüyük;
        private System.Windows.Forms.RadioButton rdoOrta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxSiparisler;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.Button btnSiparisiTamamla;
        private System.Windows.Forms.FlowLayoutPanel flpMalzemeler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.ComboBox cmbMenüler;
        private System.Windows.Forms.RadioButton rdoKucuk;
    }
}