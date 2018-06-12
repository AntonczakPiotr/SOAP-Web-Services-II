using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OsobyKlient.OsobyWS;

namespace OsobyKlient
{
    class Program
    {
        static void Main(string[] args)
        {
            OdczytajOrazPokazPelnaListeOsob();
            Console.WriteLine();
            OdczytajOrazPokazListeOsob(4);
            Console.WriteLine();
            FiltrujOrazPokazListeOsob(2, 2);
            Console.WriteLine();
            DodajOsobe("Cezary", "Sobieski");
            WyszukajOrazPokazOsobe(15);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Usunięcie osoby o id = 13...");
            UsunOsobe(13);
            Console.WriteLine("Pełna lista osób po usunięciu osoby o id = 13...");
            OdczytajOrazPokazPelnaListeOsob();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Edycja osoby o id = 12...");
            EdytujOsobe(12, "Barbara", "Streisand");
            OdczytajOrazPokazPelnaListeOsob();
            Console.WriteLine();

            Console.ReadLine();
        }

        private static void DodajOsobe(string imie, string nazwisko)
        {
            using (OsobySoapClient usluga = new OsobySoapClient())
            {
                int i = 0;
                // wywołanie usługi
                i = usluga.DodajOsobe(imie, nazwisko);
            }
        }

        private static void WyszukajOrazPokazOsobe(int id)
        {
            using (OsobySoapClient usluga = new OsobySoapClient())
            {
                // wywołanie usługi
                Osoba wynik = usluga.WyszukajOsobe(id);
                // przetwarzanie otrzymanych danych
                PokazOsobe(wynik);
            }
        }

        private static void OdczytajOrazPokazPelnaListeOsob()
        {
            using (OsobySoapClient usluga = new OsobySoapClient())
            {
                // wywołanie usługi
                Osoba[] wynik = usluga.ListaOsobPelna();
                // przetwarzanie otrzymanych danych
                PokazOsoby(wynik);
            }
        }

        private static void FiltrujOrazPokazListeOsob(int start, int ilosc)
        {
            using (OsobySoapClient usluga = new OsobySoapClient())
            {
                // wywołanie usługi
                Osoba[] wynik = usluga.ListaOsobFiltr(start, ilosc);
                // przetwarzanie otrzymanych danych
                PokazOsoby(wynik);
            }
        }

        private static void OdczytajOrazPokazListeOsob(int ilosc)
        {
            using (OsobySoapClient usluga = new OsobySoapClient())
            {
                // wywołanie usługi
                Osoba[] wynik = usluga.ListaOsob(ilosc);
                // przetwarzanie otrzymanych danych
                PokazOsoby(wynik);
            }
        }

        private static void PokazOsoby(IEnumerable<Osoba> dane)
        {
            foreach (Osoba osoba in dane)
            {
                PokazOsobe(osoba);
            }
        }

        private static void PokazOsobe(Osoba osoba)
        {
            // przetwarzanie jednego obiektu danych
            Console.WriteLine($"{osoba.OsobaId} - {osoba.Imie} {osoba.Nazwisko}");

        }

        private static void UsunOsobe(int id)
        {
            using (OsobySoapClient usluga = new OsobySoapClient())
            {
                // wywołanie usługi
                usluga.UsunOsobe(id);
            }
        }

        private static void EdytujOsobe(int id, string noweImie, string noweNazwisko)
        {
            using (OsobySoapClient usluga = new OsobySoapClient())
            {
                // wywołanie usługi
                Osoba osobaTmp = usluga.EdytujOsobe(id, noweImie, noweNazwisko);
            }
        }

    }
}

