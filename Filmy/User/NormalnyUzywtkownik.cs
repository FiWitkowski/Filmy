using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filmy.Movie;
using Filmy.Exceptions;
using Filmy.Systems;

namespace Filmy.User
{
    [Serializable]
    public class NormalnyUzywtkownik : Uzytkownik
    {
        public NormalnyUzywtkownik(string imie, string username, string password) : base(imie, username, password)
        {
        }

        public NormalnyUzywtkownik(string imie, string nazwisko, int wiek, string userName, string password) : base(imie, nazwisko, wiek, userName, password)
        {
        }
        
        

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void UsunOcene(Film film)
        {
            try
            {
                film.ListaOcen.Remove(film.ListaOcen.First(e => e.uzytkownik.Equals(this)));
                film.obliczSrednia();
            }
            catch(ArgumentNullException e)
            {
                
            }
            catch(Exception e)
            {
                
            }           
        }
        public void OcenFilm(string tytul, int ocena)
        {
            try
            {
                Film film = Biblioteka.Instance.Films.First(f => f.Tytul == tytul);
                UsunOcene(film);
                    
                switch (ocena)
                {
                    case 1:
                        film.ListaOcen.AddLast(new Ocena(Oceny.OneStar, this)); 
                        break;
                    case 2:
                        film.ListaOcen.AddLast(new Ocena(Oceny.TwoStar, this));
                        break;
                    case 3:
                        film.ListaOcen.AddLast(new Ocena(Oceny.ThreeStar, this));
                        break;
                    case 4:
                        film.ListaOcen.AddLast(new Ocena(Oceny.FourStar, this));
                        break;
                    case 5:
                        film.ListaOcen.AddLast(new Ocena(Oceny.FiveStar, this));
                        break;
                    default:
                        throw (new IncorrectGradeException());
                }
                film.obliczSrednia();
               
            }
            catch(Exception e)
            {
                throw (e);
            }
            
        }
    }
}
