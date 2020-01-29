using Filmy.Movie;
using Filmy.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmy.Systems
{
    public sealed class Biblioteka : iSystem<Film>
    {

        private Administrator admin;
        public Administrator Admin { get => admin; private set => admin = value; }
        






        private static Biblioteka instance=null;

        private Biblioteka(Administrator admin)
        {
            this.Admin = admin;
        }



        public static Biblioteka Instance
        {
        get
        {
            if (instance == null)
            {
                instance = new Biblioteka(Administrator.Instance);
            }
            return instance;
        }
    }

        

        private class Zagniezdzona
        {
            static Zagniezdzona()
            {
            }
            internal static readonly Biblioteka instance = new Biblioteka(new Administrator("Filip", "Witkowski", 23, "FiWitkowski", "admin123"));
        }

        public void DodajElement(Film u)
        {
            throw new NotImplementedException();
        }

        public void UsunElement(Film u)
        {
            throw new NotImplementedException();
        }
    }
}
