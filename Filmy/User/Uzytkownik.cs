using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmy.User
{
    public abstract class Uzytkownik
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
        public string Password { get => password; set => password = value; }

        public Uzytkownik(string imie, string nazwisko, int wiek, string userName, string password)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
            UserName = userName;
            Password = password;
        }
        public Uzytkownik(string imie, string username,string password) : this(imie, String.Empty, -1, username, password)
        {

        }

       
    }
}
