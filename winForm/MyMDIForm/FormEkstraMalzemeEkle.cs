using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMDIForm
{
    public partial class FormEkstraMalzemeEkle : Form
    {
        public FormEkstraMalzemeEkle()
        {
            InitializeComponent();
        }

        private void btnEkstraMalzemeEkle_Click(object sender, EventArgs e)
        {
            FormSiparisOlustur.ekstralar.Add(new Ekstra { EkstraMalzemeIsmi = txtMalzemeAdi.Text, Fiyati = nmrEkstraMalzemeFiyati.Value });

            //TODO: eKLENDİKTEN SONRA TEMİZLE METODU ÇAĞIRILSIN.

            MessageBox.Show("Menü Başarılı Bir Şekilde Eklendi.");
        }
    }
}
