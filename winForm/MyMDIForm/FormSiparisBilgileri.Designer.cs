
namespace MyMDIForm
{
    partial class FormSiparisBilgileri
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
            this.lbxTümSiparisler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCiro = new System.Windows.Forms.GroupBox();
            this.lblCiro = new System.Windows.Forms.Label();
            this.grpToplamSiparisSayisi = new System.Windows.Forms.GroupBox();
            this.lblToplamSiparisSayisi = new System.Windows.Forms.Label();
            this.grpEkstraMalzemeGeliri = new System.Windows.Forms.GroupBox();
            this.lblEkstraMalzemeGeliri = new System.Windows.Forms.Label();
            this.grpSatilanÜrünSayisi = new System.Windows.Forms.GroupBox();
            this.lblSatilanÜrünSayisi = new System.Windows.Forms.Label();
            this.grpCiro.SuspendLayout();
            this.grpToplamSiparisSayisi.SuspendLayout();
            this.grpEkstraMalzemeGeliri.SuspendLayout();
            this.grpSatilanÜrünSayisi.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxTümSiparisler
            // 
            this.lbxTümSiparisler.FormattingEnabled = true;
            this.lbxTümSiparisler.HorizontalScrollbar = true;
            this.lbxTümSiparisler.Location = new System.Drawing.Point(12, 41);
            this.lbxTümSiparisler.Name = "lbxTümSiparisler";
            this.lbxTümSiparisler.Size = new System.Drawing.Size(183, 420);
            this.lbxTümSiparisler.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TÜM SİPARİŞLER";
            // 
            // grpCiro
            // 
            this.grpCiro.Controls.Add(this.lblCiro);
            this.grpCiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCiro.Location = new System.Drawing.Point(201, 41);
            this.grpCiro.Name = "grpCiro";
            this.grpCiro.Size = new System.Drawing.Size(175, 100);
            this.grpCiro.TabIndex = 2;
            this.grpCiro.TabStop = false;
            this.grpCiro.Text = "Ciro";
            // 
            // lblCiro
            // 
            this.lblCiro.AutoSize = true;
            this.lblCiro.ForeColor = System.Drawing.Color.Red;
            this.lblCiro.Location = new System.Drawing.Point(6, 43);
            this.lblCiro.Name = "lblCiro";
            this.lblCiro.Size = new System.Drawing.Size(32, 13);
            this.lblCiro.TabIndex = 0;
            this.lblCiro.Text = "0.00";
            // 
            // grpToplamSiparisSayisi
            // 
            this.grpToplamSiparisSayisi.Controls.Add(this.lblToplamSiparisSayisi);
            this.grpToplamSiparisSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpToplamSiparisSayisi.Location = new System.Drawing.Point(201, 147);
            this.grpToplamSiparisSayisi.Name = "grpToplamSiparisSayisi";
            this.grpToplamSiparisSayisi.Size = new System.Drawing.Size(175, 100);
            this.grpToplamSiparisSayisi.TabIndex = 3;
            this.grpToplamSiparisSayisi.TabStop = false;
            this.grpToplamSiparisSayisi.Text = "Toplam Sipariş Sayısı";
            // 
            // lblToplamSiparisSayisi
            // 
            this.lblToplamSiparisSayisi.AutoSize = true;
            this.lblToplamSiparisSayisi.ForeColor = System.Drawing.Color.Red;
            this.lblToplamSiparisSayisi.Location = new System.Drawing.Point(6, 44);
            this.lblToplamSiparisSayisi.Name = "lblToplamSiparisSayisi";
            this.lblToplamSiparisSayisi.Size = new System.Drawing.Size(32, 13);
            this.lblToplamSiparisSayisi.TabIndex = 0;
            this.lblToplamSiparisSayisi.Text = "0.00";
            // 
            // grpEkstraMalzemeGeliri
            // 
            this.grpEkstraMalzemeGeliri.Controls.Add(this.lblEkstraMalzemeGeliri);
            this.grpEkstraMalzemeGeliri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEkstraMalzemeGeliri.Location = new System.Drawing.Point(201, 253);
            this.grpEkstraMalzemeGeliri.Name = "grpEkstraMalzemeGeliri";
            this.grpEkstraMalzemeGeliri.Size = new System.Drawing.Size(172, 100);
            this.grpEkstraMalzemeGeliri.TabIndex = 0;
            this.grpEkstraMalzemeGeliri.TabStop = false;
            this.grpEkstraMalzemeGeliri.Text = "Ekstra Malzeme Geliri";
            // 
            // lblEkstraMalzemeGeliri
            // 
            this.lblEkstraMalzemeGeliri.AutoSize = true;
            this.lblEkstraMalzemeGeliri.ForeColor = System.Drawing.Color.Red;
            this.lblEkstraMalzemeGeliri.Location = new System.Drawing.Point(6, 38);
            this.lblEkstraMalzemeGeliri.Name = "lblEkstraMalzemeGeliri";
            this.lblEkstraMalzemeGeliri.Size = new System.Drawing.Size(32, 13);
            this.lblEkstraMalzemeGeliri.TabIndex = 0;
            this.lblEkstraMalzemeGeliri.Text = "0.00";
            // 
            // grpSatilanÜrünSayisi
            // 
            this.grpSatilanÜrünSayisi.Controls.Add(this.lblSatilanÜrünSayisi);
            this.grpSatilanÜrünSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSatilanÜrünSayisi.Location = new System.Drawing.Point(201, 359);
            this.grpSatilanÜrünSayisi.Name = "grpSatilanÜrünSayisi";
            this.grpSatilanÜrünSayisi.Size = new System.Drawing.Size(172, 100);
            this.grpSatilanÜrünSayisi.TabIndex = 0;
            this.grpSatilanÜrünSayisi.TabStop = false;
            this.grpSatilanÜrünSayisi.Text = "Satılan Ürün Sayısı";
            // 
            // lblSatilanÜrünSayisi
            // 
            this.lblSatilanÜrünSayisi.AutoSize = true;
            this.lblSatilanÜrünSayisi.ForeColor = System.Drawing.Color.Red;
            this.lblSatilanÜrünSayisi.Location = new System.Drawing.Point(6, 44);
            this.lblSatilanÜrünSayisi.Name = "lblSatilanÜrünSayisi";
            this.lblSatilanÜrünSayisi.Size = new System.Drawing.Size(32, 13);
            this.lblSatilanÜrünSayisi.TabIndex = 0;
            this.lblSatilanÜrünSayisi.Text = "0.00";
            // 
            // FormSiparisBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 482);
            this.Controls.Add(this.grpSatilanÜrünSayisi);
            this.Controls.Add(this.grpEkstraMalzemeGeliri);
            this.Controls.Add(this.grpToplamSiparisSayisi);
            this.Controls.Add(this.grpCiro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxTümSiparisler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSiparisBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormSiparisBilgileri";
            this.Load += new System.EventHandler(this.FormSiparisBilgileri_Load);
            this.grpCiro.ResumeLayout(false);
            this.grpCiro.PerformLayout();
            this.grpToplamSiparisSayisi.ResumeLayout(false);
            this.grpToplamSiparisSayisi.PerformLayout();
            this.grpEkstraMalzemeGeliri.ResumeLayout(false);
            this.grpEkstraMalzemeGeliri.PerformLayout();
            this.grpSatilanÜrünSayisi.ResumeLayout(false);
            this.grpSatilanÜrünSayisi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxTümSiparisler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCiro;
        private System.Windows.Forms.GroupBox grpToplamSiparisSayisi;
        private System.Windows.Forms.GroupBox grpEkstraMalzemeGeliri;
        private System.Windows.Forms.GroupBox grpSatilanÜrünSayisi;
        private System.Windows.Forms.Label lblCiro;
        private System.Windows.Forms.Label lblToplamSiparisSayisi;
        private System.Windows.Forms.Label lblEkstraMalzemeGeliri;
        private System.Windows.Forms.Label lblSatilanÜrünSayisi;
    }
}