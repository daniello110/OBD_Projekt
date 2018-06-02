using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBD_Projekt
{
    abstract class Pojazd
    {
        private int _rokProdukcji;
        private string _nazwa, _numerRej;
        private int _liczbaOsi;
        private int _przebieg;
        public Pracownik _kierowca;

        public Pojazd(string nazwa, string numerRej, int liczbaOsi, int rokProdukcji, int przebieg, Pracownik kierowca)
        {
            _nazwa = nazwa;
            _numerRej = numerRej;
            _liczbaOsi = liczbaOsi;
            _rokProdukcji = rokProdukcji;
            _przebieg = przebieg;
            _kierowca = kierowca;
        }

        public int RokProdukcji
        {
            get { return _rokProdukcji; }
        }

        public int LiczbaOsi
        {
            get { return _liczbaOsi; }
        }

        public string Nazwa
        {
            get { return _nazwa; }
        }

        public string NumerRej
        {
            get { return _numerRej; }
        }
        public int Przebieg
        {
            get { return _przebieg; }
        }

        public Pracownik Kierowca
        {
            get { return _kierowca; }
        }

        public void Jedz(int kilometry)
        {
            _przebieg += kilometry;
            Console.Write("\n" + this._nazwa + " przejechał " + kilometry + " kilometrów. Obecny przebieg: " + this._przebieg);
        }

        public virtual void OpiszSie() { }
    }
}
