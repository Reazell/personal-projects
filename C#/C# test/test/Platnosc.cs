using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    abstract class Platnosc
    {

        protected float kwotaPlatnosci;

        public abstract void Zaplac(Zamowienie zamowienie);

        public abstract void wydrukPotwierdzenia();

    }
}
