using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Email : INotatka
    {
        private string emailAddress;

        public void wydrukujPotwierdzenie()
        {
            Console.WriteLine("Wyslano potwierdzenie zamowienia na adres " + emailAddress);
        }
    }
}
