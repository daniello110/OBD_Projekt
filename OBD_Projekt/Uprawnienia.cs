using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBD_Projekt
{
    class Uprawnienia
    {
        private bool _dostepDoSejfu, _dostepDoKomputera;

        public Uprawnienia(bool dostepDoSejfu, bool dostepDoKomputera)
        {
            _dostepDoKomputera = dostepDoKomputera;
            _dostepDoSejfu = dostepDoSejfu;
        }

        public bool DostepDoSejfu
        {
            get { return _dostepDoSejfu; }
        }
        public bool DostepDoKomputera
        {
            get { return _dostepDoKomputera; }
        }

        public override string ToString()
        {
            return string.Format("Dostęp do sejfu: {0}, Dostęp do komputera: {1};", this.DostepDoSejfu, this.DostepDoKomputera);
        }

    }
}
