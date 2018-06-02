using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBD_Projekt
{
    class Ciezarowka : Pojazd
    {
        private int _ladownosc;

        public Ciezarowka(string nazwa, string numerRej, int liczbaOsi, int rokProdukcji, int przebieg, int ladownosc, Pracownik kierowca)
             : base(nazwa, numerRej, liczbaOsi, rokProdukcji, przebieg, kierowca)
        {
            _ladownosc = ladownosc;
        }

        public int Ladownosc
        {
            get { return _ladownosc; }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3};", this.Nazwa, this.NumerRej, this.Ladownosc, Kierowca.Nazwisko);
        }

        public override void OpiszSie()
        {
            Console.WriteLine("\nPojazd to ciężarówka, a dokładnie: " + this.Nazwa + ", o numerze rejestracyjnym: " + this.NumerRej +
                                ". Został wyprodukowany w " + this.RokProdukcji + " roku.\nJego ładowność wynosi: " + this.Ladownosc + ". Jeździ nią " + this._kierowca.Imie + " " + this._kierowca.Nazwisko + ".");
        }
    }
}
