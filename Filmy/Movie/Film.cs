using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filmy.User;
namespace Filmy.Movie
{
    public class Film : IEquatable<Film>
    {
        private List<Ocena> listaOcen;
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

    
        public double SredniaOcen { get => sredniaOcen; set => sredniaOcen = value; }
        public string Tytul { get => tytul; set => tytul = value; }
        public DateTime Premiera { get => premiera; set => premiera = value; }
        public List<Uzytkownik> OcenionyPrzez { get => ocenionyPrzez; set => ocenionyPrzez = value; }
        public List<Ocena> ListaOcen { get => listaOcen; set => listaOcen = value; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Film);
        }

        public bool Equals(Film other)
        {
            return other != null &&
                   Tytul == other.Tytul &&
                   Premiera == other.Premiera;
        }

        public double obliczSrednia()
        {
            double suma=0.0;
            ListaOcen.ForEach(e => suma += (int)e.ocena);
            return sredniaOcen=(suma/ListaOcen.Count);
        }
        //TODO
        public override string ToString()
        {
            return base.ToString();
        }

        public static bool operator ==(Film left, Film right)
        {
            return EqualityComparer<Film>.Default.Equals(left, right);
        }

        public static bool operator !=(Film left, Film right)
        {
            return !(left == right);
        }
    }

   
}
