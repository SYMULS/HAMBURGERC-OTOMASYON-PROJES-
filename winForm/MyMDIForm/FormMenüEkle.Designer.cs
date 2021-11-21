
namespace MyMDIForm
{
    partial class FormMenüEkle
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
            this.grpMenüEkle = new System.Windows.Forms.GroupBox();
            this.btnMenüEkle = new System.Windows.Forms.Button();
            this.nmrMenuFiyati = new System.Windows.Forms.NumericUpDown();
            this.txtMenuAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMenüEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMenuFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenüEkle
            // 
            this.grpMenüEkle.Controls.Add(this.btnMenüEkle);
            this.grpMenüEkle.Controls.Add(this.nmrMenuFiyati);
            this.grpMenüEkle.Controls.Add(this.txtMenuAdi);
            this.grpMenüEkle.Controls.Add(this.label2);
            this.grpMenüEkle.Controls.Add(this.label1);
            this.grpMenüEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMenüEkle.Location = new System.Drawing.Point(12, 29);
            this.grpMenüEkle.Name = "grpMenüEkle";
            this.grpMenüEkle.Size = new System.Drawing.Size(276, 217);
            this.grpMenüEkle.TabIndex = 0;
            this.grpMenüEkle.TabStop = false;
            this.grpMenüEkle.Text = "MENÜ BİLGİLERİ";
            // 
            // btnMenüEkle
            // 
            this.btnMenüEkle.Location = new System.Drawing.Point(90, 102);
            this.btnMenüEkle.Name = "btnMenüEkle";
            this.btnMenüEkle.Size = new System.Drawing.Size(159, 57);
            this.btnMenüEkle.TabIndex = 4;
            this.btnMenüEkle.Text = "MENÜ EKLE";
            this.btnMenüEkle.UseVisualStyleBackColor = true;
            this.btnMenüEkle.Click += new System.EventHandler(this.btnMenüEkle_Click);
            // 
            // nmrMenuFiyati
            // 
            this.nmrMenuFiyati.DecimalPlaces = 2;
            this.nmrMenuFiyati.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.nmrMenuFiyati.Location = new System.Drawing.Point(90, 65);
            this.nmrMenuFiyati.Name = "nmrMenuFiyati";
            this.nmrMenuFiyati.Size = new System.Drawing.Size(159, 20);
            this.nmrMenuFiyati.TabIndex = 3;
            this.nmrMenuFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMenuAdi
            // 
            this.txtMenuAdi.Location = new System.Drawing.Point(90, 32);
            this.txtMenuAdi.Name = "txtMenuAdi";
            this.txtMenuAdi.Size = new System.Drawing.Size(159, 20);
            this.txtMenuAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyatı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menü Adı";
            // 
            // FormMenüEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 258);
            this.Controls.Add(this.grpMenüEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenüEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormMenüEkle";
            this.grpMenüEkle.ResumeLayout(false);
            this.grpMenüEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMenuFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMenüEkle;
        private System.Windows.Forms.Button btnMenüEkle;
        private System.Windows.Forms.NumericUpDown nmrMenuFiyati;
        private System.Windows.Forms.TextBox txtMenuAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}