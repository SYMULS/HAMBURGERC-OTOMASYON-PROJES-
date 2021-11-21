
namespace MyMDIForm
{
    partial class FormEkstraMalzemeEkle
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
            this.grpMalzemeEkle = new System.Windows.Forms.GroupBox();
            this.btnEkstraMalzemeEkle = new System.Windows.Forms.Button();
            this.nmrEkstraMalzemeFiyati = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMalzemeAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMalzemeEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraMalzemeFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMalzemeEkle
            // 
            this.grpMalzemeEkle.Controls.Add(this.btnEkstraMalzemeEkle);
            this.grpMalzemeEkle.Controls.Add(this.nmrEkstraMalzemeFiyati);
            this.grpMalzemeEkle.Controls.Add(this.label2);
            this.grpMalzemeEkle.Controls.Add(this.txtMalzemeAdi);
            this.grpMalzemeEkle.Controls.Add(this.label1);
            this.grpMalzemeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMalzemeEkle.Location = new System.Drawing.Point(12, 12);
            this.grpMalzemeEkle.Name = "grpMalzemeEkle";
            this.grpMalzemeEkle.Size = new System.Drawing.Size(291, 229);
            this.grpMalzemeEkle.TabIndex = 0;
            this.grpMalzemeEkle.TabStop = false;
            this.grpMalzemeEkle.Text = "EKSTRA MALZEME BİLGİLERİ";
            // 
            // btnEkstraMalzemeEkle
            // 
            this.btnEkstraMalzemeEkle.Location = new System.Drawing.Point(141, 122);
            this.btnEkstraMalzemeEkle.Name = "btnEkstraMalzemeEkle";
            this.btnEkstraMalzemeEkle.Size = new System.Drawing.Size(132, 62);
            this.btnEkstraMalzemeEkle.TabIndex = 4;
            this.btnEkstraMalzemeEkle.Text = "EKSTRA MALZEME EKLE";
            this.btnEkstraMalzemeEkle.UseVisualStyleBackColor = true;
            this.btnEkstraMalzemeEkle.Click += new System.EventHandler(this.btnEkstraMalzemeEkle_Click);
            // 
            // nmrEkstraMalzemeFiyati
            // 
            this.nmrEkstraMalzemeFiyati.DecimalPlaces = 2;
            this.nmrEkstraMalzemeFiyati.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nmrEkstraMalzemeFiyati.Location = new System.Drawing.Point(141, 81);
            this.nmrEkstraMalzemeFiyati.Name = "nmrEkstraMalzemeFiyati";
            this.nmrEkstraMalzemeFiyati.Size = new System.Drawing.Size(132, 20);
            this.nmrEkstraMalzemeFiyati.TabIndex = 3;
            this.nmrEkstraMalzemeFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fiyatı";
            // 
            // txtMalzemeAdi
            // 
            this.txtMalzemeAdi.Location = new System.Drawing.Point(141, 40);
            this.txtMalzemeAdi.Name = "txtMalzemeAdi";
            this.txtMalzemeAdi.Size = new System.Drawing.Size(132, 20);
            this.txtMalzemeAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ekstra Malzeme Adı";
            // 
            // FormEkstraMalzemeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 253);
            this.Controls.Add(this.grpMalzemeEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEkstraMalzemeEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormEkstraMalzemeEkle";
            this.grpMalzemeEkle.ResumeLayout(false);
            this.grpMalzemeEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraMalzemeFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMalzemeEkle;
        private System.Windows.Forms.Button btnEkstraMalzemeEkle;
        private System.Windows.Forms.NumericUpDown nmrEkstraMalzemeFiyati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMalzemeAdi;
        private System.Windows.Forms.Label label1;
    }
}