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
    public partial class FormSiparisOlustur : Form
    {
        public FormSiparisOlustur()
        {
            InitializeComponent();
        }
        public static List<Siparis> tumSiparisler = new List<Siparis>();
        public static List<Siparis> mevcutSiparisler = new List<Siparis>();

        public static List<Menu> menuler = new List<Menu>()
        {
            new Menu{MenuAdi = "Big King", Fiyati = 20.50M},
            new Menu{MenuAdi = "Whoper Jr.", Fiyati = 19.00M},
            new Menu{MenuAdi = "Double King Chicken", Fiyati = 21.00M},
            new Menu{MenuAdi = "Big Royale", Fiyati = 27.50M},
            new Menu{MenuAdi = "Köfteburger", Fiyati = 23.00M},
            new Menu{MenuAdi = "Chicken Royale", Fiyati = 18.00M},
            new Menu{MenuAdi = "Steakhouse", Fiyati = 29.75M},
        };

        public static List<Ekstra> ekstralar = new List<Ekstra>()
        {
            new Ekstra{EkstraMalzemeIsmi = "Ketçap", Fiyati = 1.00M},
            new Ekstra{EkstraMalzemeIsmi = "Mayonez", Fiyati = 1.00M},
            new Ekstra{EkstraMalzemeIsmi = "BBQ Sos", Fiyati = 1.50M},
            new Ekstra{EkstraMalzemeIsmi = "Ranch Sos", Fiyati = 1.50M},
        };
        
        //private void FormSiparisEkle_Load(object sender, EventArgs e)
        //{
        //    foreach (Menu item in menuler)
        //        cmbMenüler.Items.Add(item); //ToString() metodu override edildiği için .... Menü şeklinde bastırılacak.

        //    foreach (Ekstra item in ekstralar)
        //        flpMalzemeler.Controls.Add(new CheckBox() { Text = item.EkstraMalzemeIsmi, Tag = item });

        //    foreach (Siparis item in mevcutSiparisler)
        //        lbxSiparisler.Items.Add(item); // form açıldığında mevcut(tamalanmayan) sipariş varsa listboxa ekleyecekir.

        //    TutarHesapla();
        //    rdoKucuk.Checked = false;
        //    cmbMenüler.SelectedIndex = 0; // Default olarak -1 dir. Ancal, -1 olursa herhangi bir eleman seçili olarak gelmez. 0 olursa ilk eleman seçilir gelir.
        //}      

        private void FormSiparisOlustur_Load(object sender, EventArgs e)
        {
            foreach (Menu item in menuler)
                cmbMenüler.Items.Add(item); //ToString() metodu override edildiği için .... Menü şeklinde bastırılacak.

            foreach (Ekstra item in ekstralar)
                flpMalzemeler.Controls.Add(new CheckBox() { Text = item.EkstraMalzemeIsmi, Tag = item });

            foreach (Siparis item in mevcutSiparisler)
                lbxSiparisler.Items.Add(item); // form açıldığında mevcut(tamalanmayan) sipariş varsa listboxa ekleyecekir.

            TutarHesapla();
            rdoKucuk.Checked = true;
            cmbMenüler.SelectedIndex = 0; // Default olarak -1 dir. Ancal, -1 olursa herhangi bir eleman seçili olarak gelmez. 0 olursa ilk eleman seçilir gelir.
        }

        private decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < lbxSiparisler.Items.Count; i++)
            {
                Siparis gelenSiparis = (Siparis)lbxSiparisler.Items[i];
                toplamTutar = toplamTutar + gelenSiparis.ToplamTutar;
            }

            lblToplamTutar.Text = toplamTutar.ToString("C2");
            return toplamTutar;
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.secilenMenu =(Menu)cmbMenüler.SelectedItem;

            if (rdoKucuk.Checked)
                yeniSiparis.Boyutu = Boyut.Kucuk;
            else if (rdoOrta.Checked)
                yeniSiparis.Boyutu = Boyut.Orta;
            else
                yeniSiparis.Boyutu = Boyut.Buyuk;

            yeniSiparis.EkstraMalzemeleri = new List<Ekstra>();

            foreach (CheckBox kontrol in flpMalzemeler.Controls)
            {
                if (kontrol.Checked)
                {
                    yeniSiparis.EkstraMalzemeleri.Add((Ekstra)kontrol.Tag); //FLP nin kontrollerinden herbirinin tag propertysinde tutulan ekstra malzeme listesinin bir kopyasını aldık ve sipariş nesnesinin ekstra malzemeleri listesine ekledik.
                }
            }
            yeniSiparis.Adet =Convert.ToInt32(nmrAdet.Value);

            yeniSiparis.Hesapla(); //classta yazılan metot sayesinde toplam tutar hesaplanıp ilgili propertye aktarılacaktır.


            mevcutSiparisler.Add(yeniSiparis);
            lbxSiparisler.Items.Add(yeniSiparis);
            TutarHesapla(); // toplam tutarı labelde göstermek için.
            tumSiparisler.Add(yeniSiparis);

            //fonksiyon sınıfından temizle metodu gelecek.
        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Sipariş Tutarı:" + TutarHesapla().ToString("C2") + "\nSatın alma işlemini onaylıyor musunuz?", "SiparişBilgileri", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                lbxSiparisler.Items.Clear(); // listboxı temizle
                mevcutSiparisler.Clear(); // mevcut siparişler listesini temizle.
                TutarHesapla(); //labeldeki değeri temizle tl yi 0.00 yapacak
                MessageBox.Show("Sipariş Tamamlandı");
            }
            else if (dr == DialogResult.No)
                MessageBox.Show("Siparişler İptal Edilmiştir.");
        }
    }
}
