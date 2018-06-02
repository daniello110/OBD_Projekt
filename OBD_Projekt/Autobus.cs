using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBD_Projekt
{
    class Autobus : Pojazd
    {
        private int _liczbaMiejsc;

        public Autobus(string nazwa, string numerRej, int liczbaOsi, int rokProdukcji, int przebieg, int liczbaMiejsc, Pracownik kierowca)
             : base(nazwa, numerRej, liczbaOsi, rokProdukcji, przebieg, kierowca)
        {
            _liczbaMiejsc = liczbaMiejsc;
        }

        public int LiczbaMiejsc
        {
            get { return _liczbaMiejsc; }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3};", this.Nazwa, this.NumerRej, this.LiczbaMiejsc, Kierowca.Nazwisko);
        }

        public override void OpiszSie()
        {
            Console.WriteLine("\nPojazd to autobus, a dokładnie: " + this.Nazwa + ", o numerze rejestracyjnym: " + this.NumerRej +
                                ". Został wyprodukowany w " + this.RokProdukcji + " roku.\nAutobus posiada " + this.LiczbaMiejsc + " miejsc siedzących. Jeździ nim " + this._kierowca.Imie + " " + this._kierowca.Nazwisko + ".");
        }
    }
}
