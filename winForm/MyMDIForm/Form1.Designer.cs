
namespace MyMDIForm
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmSiparisYönetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSiparisOlustur = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSiparisBilgileri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmÜrünYönetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMenüEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEkstraMalzemeEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSiparisYönetimi,
            this.tsmÜrünYönetimi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(754, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmSiparisYönetimi
            // 
            this.tsmSiparisYönetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSiparisOlustur,
            this.tsmSiparisBilgileri});
            this.tsmSiparisYönetimi.Name = "tsmSiparisYönetimi";
            this.tsmSiparisYönetimi.Size = new System.Drawing.Size(103, 20);
            this.tsmSiparisYönetimi.Text = "Sipariş Yönetimi";
            // 
            // tsmSiparisOlustur
            // 
            this.tsmSiparisOlustur.Name = "tsmSiparisOlustur";
            this.tsmSiparisOlustur.Size = new System.Drawing.Size(180, 22);
            this.tsmSiparisOlustur.Text = "Sipariş Oluştur";
            this.tsmSiparisOlustur.Click += new System.EventHandler(this.tsmSiparisOlustur_Click);
            // 
            // tsmSiparisBilgileri
            // 
            this.tsmSiparisBilgileri.Name = "tsmSiparisBilgileri";
            this.tsmSiparisBilgileri.Size = new System.Drawing.Size(180, 22);
            this.tsmSiparisBilgileri.Text = "Sipariş Bilgileri";
            this.tsmSiparisBilgileri.Click += new System.EventHandler(this.tsmSiparisBilgileri_Click);
            // 
            // tsmÜrünYönetimi
            // 
            this.tsmÜrünYönetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenüEkle,
            this.tsmEkstraMalzemeEkle});
            this.tsmÜrünYönetimi.Name = "tsmÜrünYönetimi";
            this.tsmÜrünYönetimi.Size = new System.Drawing.Size(95, 20);
            this.tsmÜrünYönetimi.Text = "Ürün Yönetimi";
            // 
            // tsmMenüEkle
            // 
            this.tsmMenüEkle.Name = "tsmMenüEkle";
            this.tsmMenüEkle.Size = new System.Drawing.Size(180, 22);
            this.tsmMenüEkle.Text = "Menü Ekle";
            this.tsmMenüEkle.Click += new System.EventHandler(this.tsmMenüEkle_Click);
            // 
            // tsmEkstraMalzemeEkle
            // 
            this.tsmEkstraMalzemeEkle.Name = "tsmEkstraMalzemeEkle";
            this.tsmEkstraMalzemeEkle.Size = new System.Drawing.Size(180, 22);
            this.tsmEkstraMalzemeEkle.Text = "Ekstra Malzeme Ekle";
            this.tsmEkstraMalzemeEkle.Click += new System.EventHandler(this.tsmEkstraMalzemeEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 503);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MyMDIForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmSiparisYönetimi;
        private System.Windows.Forms.ToolStripMenuItem tsmSiparisOlustur;
        private System.Windows.Forms.ToolStripMenuItem tsmSiparisBilgileri;
        private System.Windows.Forms.ToolStripMenuItem tsmÜrünYönetimi;
        private System.Windows.Forms.ToolStripMenuItem tsmMenüEkle;
        private System.Windows.Forms.ToolStripMenuItem tsmEkstraMalzemeEkle;
    }
}

