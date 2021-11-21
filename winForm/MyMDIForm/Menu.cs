using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMDIForm
{
    public class Menu
    {
        public string MenuAdi { get; set; }
        public decimal Fiyati { get; set; }

        public override string ToString()
        {
            string donecekDeger = MenuAdi + "Menü";
            return donecekDeger;
        }

    }
}
