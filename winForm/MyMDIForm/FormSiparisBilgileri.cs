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
    public partial class FormSiparisBilgileri : Form
    {
        public FormSiparisBilgileri()
        {
            InitializeComponent();
        }

        private void FormSiparisBilgileri_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal ekstraMalzemeGeliri = 0;
            int satisAdedi = 0;

            foreach (Siparis siparis in FormSiparisOlustur.tumSiparisler)
            {
                ciro += siparis.ToplamTutar;
                foreach (Ekstra ekstra in siparis.EkstraMalzemeleri)
                {
                    ekstraMalzemeGeliri += ekstra.Fiyati;
                }

                satisAdedi = satisAdedi + siparis.Adet;

                lbxTümSiparisler.Items.Add(siparis);
            }

            lblCiro.Text = ciro.ToString("C2");
            lblEkstraMalzemeGeliri.Text = ekstraMalzemeGeliri.ToString("C2");
            lblToplamSiparisSayisi.Text = lbxTümSiparisler.Items.Count.ToString();
            lblSatilanÜrünSayisi.Text = satisAdedi.ToString();
        }
    }
}
