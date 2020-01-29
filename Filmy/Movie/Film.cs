using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filmy.User;
namespace Filmy.Movie
{
    [Serializable]
    public class Film : IEquatable<Film>, IComparable
    {
        private LinkedList<Ocena> listaOcen;
        private double sredniaOcen;
        private string tytul;
        private DateTime premiera;
      

        public Film(string tytul, DateTime premiera)
        {
            ListaOcen = new LinkedList<Ocena>();
            SredniaOcen = 0.0;
            Tytul = tytul;
            Premiera = premiera;
          
        }

    
        public double SredniaOcen { get => sredniaOcen; set => sredniaOcen = value; }
        public string Tytul { get => tytul; set => tytul = value; }
        public DateTime Premiera { get => premiera; set => premiera = value; }
        public LinkedList<Ocena> ListaOcen { get => listaOcen; set => listaOcen = value; }

        public int CompareTo(object obj)
        {
            if (sredniaOcen > ((Film)obj).sredniaOcen)
                return -1;
            if (sredniaOcen < ((Film)obj).sredniaOcen)
                return 1;
            return 0;
        }

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
            
            ListaOcen.ToList().ForEach(e => suma += (int)e.ocena+1);
            if (ListaOcen.Count == 0)
                return 0.0;
            return sredniaOcen=(suma/ListaOcen.Count);
        }
        //TODO
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(this.tytul+" ");
            builder.Append("Premiera: " + this.Premiera.ToShortDateString() + " ");
            builder.Append("Ocena: " + SredniaOcen);
            return builder.ToString();

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
