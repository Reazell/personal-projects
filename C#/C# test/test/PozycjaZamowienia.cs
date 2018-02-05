using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class PozycjaZamowienia
    {
        private string nazwaTowaru;
        private float cenaJednostkowa;
        private int stawkaVAT;
        public float ilosc;


        public double obliczBrutto()
        {
            return ilosc * (cenaJednostkowa + obliczPodatek());
        }

        public double obliczPodatek()
        {           
            return  cenaJednostkowa * ((float)stawkaVAT / 100);
        }
    }
}
