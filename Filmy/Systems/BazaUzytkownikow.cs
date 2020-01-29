using Filmy.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmy.Systems
{
    public sealed class BazaUzytkownikow
    {
        private Administrator admin;
        private List<Uzytkownik> listaUzytkownikow;

        private BazaUzytkownikow(Administrator admin)
        {
            ListaUzytkownikow = new List<Uzytkownik>();
        }

        public static BazaUzytkownikow Instance { get { return Zagniezdzona.instance; } }

        public List<Uzytkownik> ListaUzytkownikow { get => listaUzytkownikow;private set => listaUzytkownikow = value; }

        private bool DodajUzytkownika(Uzytkownik user)
        {
            
            try
            {
                ListaUzytkownikow.Add(user);
            }
            catch(Exception e)
            {
                throw (e);
            }
            return true;
        }

        private class Zagniezdzona
        {
            static Zagniezdzona()
            {
            }
            internal static readonly BazaUzytkownikow instance = new BazaUzytkownikow(new Administrator("Filip","Witkowski",23,"FiWitkowski","admin123"));
        }



    }
}
