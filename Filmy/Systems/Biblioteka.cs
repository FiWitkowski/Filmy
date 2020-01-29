using Filmy.Movie;
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
    public sealed class Biblioteka : iSystem<Film>
    {
        private LinkedList<Film> films;

        private static Biblioteka instance = null;
        private Biblioteka()
        {
            Admin = Administrator.Instance;
            Films = new LinkedList<Film>();
        }

        public static Biblioteka Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Biblioteka();
                }
                return instance;
            }
        }

        private Administrator admin;
        public Administrator Admin { get => admin; private set => admin = value; }
        public LinkedList<Film> Films { get => films; set => films = value; }

        void iSystem<Film>.DodajElement(Film u)
        {
            DodajFilm(u);
        }

        bool iSystem<Film>.UsunElement(Film u)
        {
            return this.UsunFilm(u);
        }
        
        public void DodajFilm(Film film)
        {
            if (!Films.Any(f => f.Tytul == film.Tytul))
                Films.AddLast(film);
            else
                throw (new Exception("Ten film juz mamy!"));
        }

        public bool UsunFilm(string film)
        {
            if (Films.Any(f => f.Tytul == film))
                return Films.Remove(Films.First(f => f.Tytul == film));
            throw (new Exception("Nie mamy takiego filmu!"));
        }
        public bool UsunFilm(Film film)
        {
            return UsunFilm(film.Tytul);
        }

        public void Serialize(string path)
        {
            


                using (Stream stream = new FileStream(path, FileMode.Create)) {
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
                    return instance = formatter.Deserialize(stream) as Biblioteka;
                }
            }
            catch
            {
                return Biblioteka.Instance;
            }
        }
    }
}
