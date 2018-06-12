using OsobyApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace OsobyApp.Repository.Memory
{
    public class OsobyRepository : IOsobyRepository
    {
        private static List<Osoba> osoby = new List<Osoba>();
        private static int lastId = 14;

        static OsobyRepository()
        {
            osoby.Add(new Osoba
            {
                OsobaId = 10,
                Imie = "Jan",
                Nazwisko = "Kowalski"
            });
            osoby.Add(new Osoba
            {
                OsobaId = 11,
                Imie = "Piotr",
                Nazwisko = "Kowalski"
            });
            osoby.Add(new Osoba
            {
                OsobaId = 12,
                Imie = "Alina",
                Nazwisko = "Nowak"
            });
            osoby.Add(new Osoba
            {
                OsobaId = 13,
                Imie = "Anna",
                Nazwisko = "Pogodna"
            });
            osoby.Add(new Osoba
            {
                OsobaId = 14,
                Imie = "Tomasz",
                Nazwisko = "Ratajski"
            });
        }
        public IEnumerable<Osoba> Get()
        {
            // zwracanie kopii kolekcji - brak zmian spoza OsobyRepository
            return new List<Osoba>(osoby);
        }

        public Osoba Get(int id)
        {
            foreach (Osoba obj in osoby)
            {
                if (obj.OsobaId == id)
                    return obj;
            }
            // przypadek specjalny - pusty obiekt, gdy nie znaleziono
            return new Osoba();
        }

        public void Add(Osoba obj)
        {
            obj.OsobaId = Interlocked.Increment(ref lastId);
            osoby.Add(obj);
        }

        public void Remove(Osoba obj)
        {
            osoby.Remove(obj);
        }

    }
}
