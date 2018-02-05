using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kolokwium
{
    class Gotowka : Platnosc
    {

        public override void Zaplac(Zamowienie zamowienie)
        {
            Console.WriteLine("Zaplata gotowka na kwote " + zamowienie.wartoscZamowienia());
        }

        public override void wydrukPotwierdzenia()
        {
            Console.WriteLine("Potwierdzenie platnosci karta");
        }
    }
}
