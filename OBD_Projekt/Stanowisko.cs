using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBD_Projekt
{
    class Stanowisko
    {
        private string _nazwa;
        private int _zarobki;
        private Uprawnienia _uprawnienia;

        public Stanowisko(string nazwa, int zarobki, Uprawnienia uprawnienia)
        {
            _nazwa = nazwa;
            _zarobki = zarobki;
            _uprawnienia = uprawnienia;
        }

        public string Nazwa
        {
            get { return _nazwa; }
        }
        public int Zarobki
        {
            get { return _zarobki; }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2};", this.Nazwa, this.Zarobki, Uprawnienia);
        }

        public Uprawnienia Uprawnienia
        {
            get { return _uprawnienia; }
        }
    }
}
