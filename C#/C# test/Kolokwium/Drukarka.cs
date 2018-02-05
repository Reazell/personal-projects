using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Drukarka : INotatka
    {

        public void wydrukujPotwierdzenie()
        {
            Console.WriteLine("Drukuje potwierdzenie zamowienia");
        }
    }
}
