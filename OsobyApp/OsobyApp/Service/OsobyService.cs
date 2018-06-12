using OsobyApp.Domain;
using OsobyApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OsobyApp.Service
{
    public class OsobyService
    {
        private IOsobyRepository osobyRepository;

        public OsobyService(IOsobyRepository repository)
        {
            osobyRepository = repository;
        }

        public List<Osoba> ListaOsob()
        {
            return osobyRepository.Get().ToList();
        }

        public List<Osoba> ListaOsob(int ilosc)
        {
            return osobyRepository.Get()
                .Take(ilosc)
                .ToList();
        }

        public List<Osoba> ListaOsob(int start, int ilosc)
        {
            return osobyRepository.Get()
                .Skip(start)
                .Take(ilosc)
                .ToList();
        }

        public Osoba WyszukajOsobe(int osobaId)
        {
            return osobyRepository.Get(osobaId);
        }

        public int DodajOsobe(string imie, string nazwisko)
        {
            Osoba osoba = new Osoba { Imie = imie, Nazwisko = nazwisko };
            osobyRepository.Add(osoba);
            return osoba.OsobaId;
        }

        public void UsunOsobe(int osobaId)
        {
            Osoba osobaTmp = osobyRepository.Get(osobaId);
            osobyRepository.Remove(osobaTmp);
        }

        public Osoba EdytujOsobe(int osobaId, string noweImie, string noweNazwisko)
        {
            Osoba osobaTmp = osobyRepository.Get(osobaId);
            osobaTmp.Imie = noweImie;
            osobaTmp.Nazwisko = noweNazwisko;
            return osobyRepository.Get(osobaId);
        }
    }
}
