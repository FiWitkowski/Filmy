using Filmy.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmy.Movie
{
    public struct Ocena : IComparable, IEquatable<Ocena>
    {
        public Oceny ocena;
        public Uzytkownik uzytkownik;
        public Ocena(Oceny ocena, Uzytkownik user)
        {
            this.ocena = ocena;
            this.uzytkownik = user;
        }



        public int CompareTo(object obj)
        {
            return obj is Oceny ocena ? CompareTo(ocena) : throw (new ArgumentException("Provided argument is not of type \"Ocena\"."));
        }
        public int CompareTo(Ocena other)
        {
            if ((int)ocena > (int)other.ocena)
                return 1;
            if ((int)ocena < (int)other.ocena)
                return -1;
            return 0;
        }

        public override bool Equals(object obj)
        {
            return obj is Oceny ocena && Equals(ocena);
        }

        public bool Equals(Ocena other)
        {
            return CompareTo(other) == 0 && uzytkownik.Equals(other.uzytkownik);
        }

        public static bool operator ==(Ocena left, Ocena right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Ocena left, Ocena right)
        {
            return !(left == right);
        }
    }
}
