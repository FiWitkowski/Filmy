using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filmy.User;
namespace Filmy.Movie
{
    public class Film
    {
        private List<Oceny> listaOcen;
        private double sredniaOcen;
        private string tytul;
        private DateTime premiera;
        private List<Uzytkownik> ocenionyPrzez;

        public Film(string tytul, DateTime premiera)
        {
            ListaOcen = new List<Oceny>();
            SredniaOcen = 0.0;
            Tytul = tytul;
            Premiera = premiera;
            ocenionyPrzez = new List<Uzytkownik>();
        }

        public List<Oceny> ListaOcen { get => listaOcen; set => listaOcen = value; }
        public double SredniaOcen { get => sredniaOcen; set => sredniaOcen = value; }
        public string Tytul { get => tytul; set => tytul = value; }
        public DateTime Premiera { get => premiera; set => premiera = value; }
        public List<Uzytkownik> OcenionyPrzez { get => ocenionyPrzez; set => ocenionyPrzez = value; }
        public double obliczSrednia()
        {
            double suma=0.0;
            ListaOcen.ForEach(e => suma += (int)e);
            return sredniaOcen=(suma/ListaOcen.Count);
        }
    }
}
