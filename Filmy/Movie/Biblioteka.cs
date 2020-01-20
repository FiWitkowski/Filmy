using Filmy.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmy.Movie
{
    public sealed class Biblioteka
    {
        private Administrator admin;
        private Biblioteka(Administrator admin)
        {
            this.Admin = admin;
        }
         
        public Administrator Admin { get => admin; private set => admin = value; }

        private class Zagniezdzona
        {
            static Zagniezdzona()
            {
            }
            internal static readonly Biblioteka instance = new Biblioteka(new Administrator("Filip", "Witkowski", 23, "FiWitkowski", "admin123"));
        }
    }
}
