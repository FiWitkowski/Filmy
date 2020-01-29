using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Filmy.User
{
    [Serializable]
    public abstract class Uzytkownik : IEquatable<Uzytkownik>, ICloneable
    {
        private string imie;
        private string nazwisko;
        private int wiek;
        private string userName;
        private string password;

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public int Wiek { get => wiek; set => wiek = value; }
        public string UserName { get => userName; set => userName = value; }
        protected string Password { private get => password; set => password = value; }

        protected Uzytkownik(string imie, string nazwisko, int wiek, string userName, string password)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
            UserName = userName;
            Password = password;
        }
        protected Uzytkownik(string imie, string username, string password) : this(imie, String.Empty, -1, username, password)
        { }
        protected Uzytkownik(string username, string password) : this(string.Empty, username, password)
        {

        }
        protected Uzytkownik() : this(String.Empty,"admin","admin")
        {

        }

        public bool checkPassword(string password)
        {
            return Password == password;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Uzytkownik);
        }

        public bool Equals(Uzytkownik other)
        {
            return other != null &&
                   UserName == other.UserName &&
                   Password == other.Password;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            try
            { 
              
                builder.Append(this.Imie).Append(" ").Append(this.nazwisko).Append("\t" + this.wiek + " lat(a)").Append(" " + UserName).AppendLine(" " + password);
            }
            catch(Exception e)
            {
                throw (e);
            }
            return builder.ToString();
        }

        public object Clone()
        {
            Uzytkownik u = new NormalnyUzywtkownik(Imie,Nazwisko,Wiek,UserName+"1",Password);
            return u;

        }

        public static bool operator ==(Uzytkownik left, Uzytkownik right)
        {
            return EqualityComparer<Uzytkownik>.Default.Equals(left, right);
        }

        public static bool operator !=(Uzytkownik left, Uzytkownik right)
        {
            return !(left == right);
        }
    }
}
