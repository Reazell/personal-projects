using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Kredyt
    {
        private byte liczbaRat;
        private string Bank;
        private float oprocentowanieRoczne;

        public void Zaplac(Zamowienie zamowienie)
        {
            Console.WriteLine("Zaplata karta na kwote: " + zamowienie.wartoscZamowienia() + " w " + liczbaRat + " ratach.");
        }

        public void WydrukujPotwierdzenie()
        {
            Console.WriteLine("Potwierdzenie platnosci karta");
        }
    }
}
