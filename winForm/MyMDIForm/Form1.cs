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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Childform(Form childform)
        {
            this.Width = childform.Width + 25;
            this.Height = childform.Height + 70;

            bool durum = false;

            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == childform.Text)
                {
                    durum = true;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }                
            }

            if (durum == false)
            {
                childform.MdiParent = this;
                childform.Show();
            }
        }

        private void tsmSiparisOlustur_Click(object sender, EventArgs e)
        {
            Childform(new FormSiparisOlustur());
        }

        private void tsmSiparisBilgileri_Click(object sender, EventArgs e)
        {
            Childform(new FormSiparisBilgileri());
        }

        private void tsmMenüEkle_Click(object sender, EventArgs e)
        {
            Childform(new FormMenüEkle());
        }

        private void tsmEkstraMalzemeEkle_Click(object sender, EventArgs e)
        {
            Childform(new FormEkstraMalzemeEkle());
        }
    }
}
