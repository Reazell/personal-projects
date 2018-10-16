using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Zamowienie
    {
        private DateTime dataRealizacji;
        private bool statusZamowienia;
        private string identyfikatorZamowienia;
        private List<PozycjaZamowienia> lista_pozycjiZamowienia;
        private bool potwierdzenieElektroniczne;


        public double wartoscZamowienia()
        {
            double wartosc = 0;
            foreach (var item in lista_pozycjiZamowienia)
                wartosc += item.obliczBrutto();

            return wartosc;
        }
        
        public double wartoscPodatku()
        {
            double podatek = 0;
            foreach (var item in lista_pozycjiZamowienia)
                podatek += item.obliczPodatek();
            return podatek;
        }

        public bool oplacZamowienie(Platnosc platnosc)
        {
            platnosc.Zaplac(this);
            return true;
        }
        public void drukujPotwierdzenie()
        {
            if (potwierdzenieElektroniczne)
                new Email().wydrukujPotwierdzenie();
            else
                new Drukarka().wydrukujPotwierdzenie();
        }

        public bool dodajPozycjeZamowienia(PozycjaZamowienia pozycjaZamowienia)
        {
            lista_pozycjiZamowienia.Add(pozycjaZamowienia);
            return lista_pozycjiZamowienia.Contains(pozycjaZamowienia);
        }


    }
}
