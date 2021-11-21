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
    public partial class FormMenüEkle : Form
    {
        public FormMenüEkle()
        {
            InitializeComponent();
        }

        private void btnMenüEkle_Click(object sender, EventArgs e)
        {
            FormSiparisOlustur.menuler.Add(new Menu {MenuAdi = txtMenuAdi.Text, Fiyati = nmrMenuFiyati.Value });
        }
    }
}
