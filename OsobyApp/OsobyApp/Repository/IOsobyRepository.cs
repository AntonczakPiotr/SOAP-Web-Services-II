using OsobyApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OsobyApp.Repository
{
    public interface IOsobyRepository
    {
        IEnumerable<Osoba> Get();
        Osoba Get(int id);
        void Add(Osoba obj);
        void Remove(Osoba obj);
    }
}
