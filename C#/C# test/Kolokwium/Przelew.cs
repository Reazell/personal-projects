using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Przelew
    {
        public string kontoBankowe;
        public string tytulPrzelewu;

        public void Zaplac(Zamowienie zamowienie)
        {
            Console.WriteLine("Zaplata przelewem na kwote " + zamowienie.wartoscZamowienia());
        }

        public void wydrukPotwierdzenia()
        {
            Console.WriteLine("Potwierdzam wykonanie przelewu");
        }
    }
}
