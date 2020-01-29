using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filmy.Exceptions;
using Filmy.Systems;


namespace Filmy.User
{
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
                if(instance == null)
                {
                    instance = new Administrator();
                }
                return instance;
            }
        }

       

        public static Administrator Create(string username, string password)
        {
            if(instance == null)
            {
                instance = new Administrator(username, password);
                return instance;
            }
            throw (new AdminAldeadyCreatedException());
        }


        private List<iSystem<object>> listOfSystems = new List<iSystem<object>>();
        public List<iSystem<object>> ListOfSystems { get => listOfSystems; set => listOfSystems = value; }


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

        public bool AddUser(Uzytkownik U)
        {
            return true;
        }
    }
}
