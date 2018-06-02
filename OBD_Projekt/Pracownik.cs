using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBD_Projekt
{
    class Pracownik
    {
        private string _imie, _nazwisko, _dataUrodzenia;
        private Stanowisko _stanowisko;
        
        public Pracownik(string imie, string nazwisko, string dataUrodzenia, Stanowisko stanowisko)
        {
            _imie = imie;
            _nazwisko = nazwisko;
            _dataUrodzenia = dataUrodzenia;
            _stanowisko = stanowisko;
        }

        public string Imie
        {
            get { return _imie; }
        }

        public string Nazwisko
        {
            get { return _nazwisko; }
        }

        public string DataUrodzenia
        {
            get { return _dataUrodzenia; }
        }

        public Stanowisko Stanowisko
        {
            get { return _stanowisko; }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3};", _imie, _nazwisko, _dataUrodzenia, _stanowisko.Nazwa);
        }

        public void PrzedstawSie()
        {
            Console.WriteLine("\nNazywam się " + this.Imie + " " + this.Nazwisko + ". Urodziłem się " + this.DataUrodzenia + ".");
        }
    }
}
