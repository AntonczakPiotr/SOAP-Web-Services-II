using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using OsobyApp.Domain;
using OsobyApp.Service;

namespace OsobyApp.WebService
{
    /// <summary>
    /// Summary description for Osoby
    /// </summary>
    [WebService(Namespace = "http://OsobyApp/WebService/Osoby/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Osoby : System.Web.Services.WebService
    {

        //[WebMethod]
        //public string HelloWorld()
        //{
        //    return "Hello World";
        //}

        [WebMethod]
        public List<Osoba> ListaOsobPelna()
        {
            return Services.OsobyService.ListaOsob();
        }

        [WebMethod]
        public List<Osoba> ListaOsob(int ilosc)
        {
            return Services.OsobyService.ListaOsob(ilosc);
        }

        [WebMethod]
        public List<Osoba> ListaOsobFiltr(int start, int ilosc)
        {
            return Services.OsobyService.ListaOsob(start, ilosc);
        }

        [WebMethod]
        public Osoba WyszukajOsobe(int osobaId)
        {
            return Services.OsobyService.WyszukajOsobe(osobaId);
        }

        [WebMethod]
        public int DodajOsobe(string imie, string nazwisko)
        {
            return Services.OsobyService.DodajOsobe(imie, nazwisko);
        }

        [WebMethod]
        public void UsunOsobe(int osobaId)
        {
            Services.OsobyService.UsunOsobe(osobaId);
        }

        [WebMethod]
        public Osoba EdytujOsobe(int osobaId, string noweImie, string noweNazwisko)
        {
            return Services.OsobyService.EdytujOsobe(osobaId, noweImie, noweNazwisko);
        }

    }
}

