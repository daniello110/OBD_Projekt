using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Db4objects.Db4o;
using Db4objects.Db4o.CS;
using Db4objects.Db4o.Linq;
using Db4objects.Db4o.NativeQueries;
using Db4objects.Db4o.Instrumentation;

namespace OBD_Projekt
{
    class Program
    {
        public static void ListResult(IObjectSet result)
        {
            Console.WriteLine(result.Count);
            foreach (object item in result)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            // UTWORZENIE OBIEKTU BAZY DANYCH
            IObjectContainer db = Db4oEmbedded.OpenFile(Db4oEmbedded.NewConfiguration(), "PojazdyDB");
            try
            {
                // UTWORZENIE OBIEKTÓW KLAS
                /// UPRAWNIENIA ///
                Uprawnienia uprawnieniaWysokie = new Uprawnienia(true, true);
                Uprawnienia uprawnieniaNiskie = new Uprawnienia(false, true);
                /// STANOWISKO ///
                Stanowisko kierowca1 = new Stanowisko("Doœwiadczony kierowca", 5000, uprawnieniaWysokie);
                Stanowisko kierowca2 = new Stanowisko("Niedoœwiadczony kierowca", 3000, uprawnieniaNiskie);
                /// PRACOWNIK ///
                Pracownik andrzejKowalski = new Pracownik("Andrzej", "Kowalski", "12 kwietnia 1975", kierowca2);

                Pracownik zygmuntZachorski = new Pracownik("Zygmunt", "Zachorski", "30 czerwca 1963", kierowca1);
                /// AUTOBUS ///
                Autobus solaris1 = new Autobus("Solaris Urbino 18", "WX 36543", 3, 2014, 130000, 120, andrzejKowalski);
                /// CIEZAROWKA ///
                Ciezarowka iveco1 = new Ciezarowka("Iveco Eurocargo", "WX 859JF", 2, 2010, 170000, 3500, zygmuntZachorski);

                // UMIESZCZENIE OBIEKTÓW DO BAZY DANYCH
                db.Store(uprawnieniaWysokie);
                db.Store(uprawnieniaNiskie);
                db.Store(kierowca1);
                db.Store(kierowca2);
                db.Store(andrzejKowalski);
                db.Store(zygmuntZachorski);
                db.Store(solaris1);
                db.Store(iveco1);
                Console.WriteLine("Operation completed: objects stored!");
                Console.WriteLine("\nQueries: ");

                // WYSZUKAJ I WYŒWIETL OBIEKTY KLASY PRACOWNIK #QueryByExample
                IObjectSet result = db.QueryByExample(typeof(Pojazd));
                ListResult(result);
                // DLA KA¯DEGO WYSZUKANEGO POJAZDU WYŒWIETL METODÊ PrzedstawSiê() oraz Jedz()
                foreach (Pojazd item in result)
                {
                    item.OpiszSie();
                    item.Jedz(100);
                }
                // DLA KA¯DEGO WYSZUKANEGO PRACOWNIKA WYŒWIETL METODÊ PrzedstawSiê() oraz Jedz()
                IObjectSet result2 = db.QueryByExample(typeof(Pracownik));
                foreach (Pracownik item in result2)
                {
                    item.PrzedstawSie();
                }


                Console.ReadKey();
            }
            finally
            {
                db.Close();
            }

        }
    }
}
