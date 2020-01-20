using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmy.User
{
    public class Administrator : Uzytkownik
    {
        public Administrator(string imie, string username, string password) : base(imie, username, password)
        {
        }

        public Administrator(string imie, string nazwisko, int wiek, string userName, string password) : base(imie, nazwisko, wiek, userName, password)
        {
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        //moze
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
