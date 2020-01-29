using Filmy.User;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Filmy.Systems
{
    [Serializable]
    public sealed class BazaUzytkownikow :iSystem<Uzytkownik>
    {
        private static BazaUzytkownikow instance = null;
        private Administrator admin;
        private LinkedList<Uzytkownik> listaUzytkownikow;

        private BazaUzytkownikow()
        {
            Admin = Administrator.Instance;
            ListaUzytkownikow = new LinkedList<Uzytkownik>();
            
        }

        public static BazaUzytkownikow Instance {
            get
            {
                if (instance == null)
                {
                    instance = new BazaUzytkownikow();
                }
                return instance;
            }
        }

        public LinkedList<Uzytkownik> ListaUzytkownikow { get => listaUzytkownikow;private set => listaUzytkownikow = value; }
        public Administrator Admin { get => admin; set => admin = value; }

       void iSystem<Uzytkownik>.DodajElement(Uzytkownik u)
        {
            DodajUzytkownika(u);
        }

        bool iSystem<Uzytkownik>.UsunElement(Uzytkownik u)
        {
            return (UsunUzytkownika(u));
        }

        public bool DodajUzytkownika(Uzytkownik user)
        {
            
            try
            {
                if (ListaUzytkownikow.Any(e => e.Equals(user)))
                    throw new ArgumentException("User already exists");
                ListaUzytkownikow.AddLast(user);
            }
            catch(Exception e)
            {
                throw e;
            }
            return true;
        }
        private bool UsunUzytkownika(Uzytkownik u)
        {
            try
            {
                return listaUzytkownikow.Remove(u);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public bool UsunUzytkownika(string userName)
        {
            try
            {
                return  UsunUzytkownika(listaUzytkownikow.First(e=>e.UserName==userName));
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Serialize(string path)
        {



            using (Stream stream = new FileStream(path, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, this);
            }

        }

        public object Deserialize(string path)
        {
            try
            {
                using (Stream stream = new FileStream(path, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return instance = formatter.Deserialize(stream) as BazaUzytkownikow;
                }

            }
            catch
            {
                return BazaUzytkownikow.Instance;
            }
        }


    }
}
