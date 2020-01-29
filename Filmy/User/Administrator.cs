using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filmy.Exceptions;
using Filmy.Systems;


namespace Filmy.User
{
    [Serializable]
    public sealed class Administrator : Uzytkownik
    {
        
        //Used for singleton property
        private static Administrator instance = null;
        private Administrator(string username, string password):base(username,password) { }
        private Administrator() : this("admin", "admin") { }
        public static Administrator Instance
        {
            get
            {
                return instance;
            }
        }
        public static Administrator Create(string username, string password)
        {
            if (instance == null)
            {
                instance = new Administrator(username, password);
                return instance;
            }
            throw (new AdminAldeadyCreatedException());
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        //moze
    
        public override string ToString()
        {
            return base.ToString();
        }


    }
}
