using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filmy.Movie;
using Filmy.Exceptions;


namespace Filmy.User
{
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
        //moze
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public void OcenFilm(Film film, int ocena)
        {
            try
            {
                //A moze lepiej zeby zamienic ocene?
                if (film.OcenionyPrzez.Contains(this))
                    throw (new SecondGradeException());
                switch (ocena)
                {
                    case 1:
                        film.ListaOcen.Add(new Ocena(Oceny.OneStar,this));
                        break;
                    case 2:
                        film.ListaOcen.Add(new Ocena(Oceny.TwoStar, this));
                        break;
                    case 3:
                        film.ListaOcen.Add(new Ocena(Oceny.ThreeStar, this));
                        break;
                    case 4:
                        film.ListaOcen.Add(new Ocena(Oceny.FourStar, this));
                        break;
                    case 5:
                        film.ListaOcen.Add(new Ocena(Oceny.FiveStar, this));
                        break;
                    default:
                        throw (new IncorrectGradeException());
                }
                film.obliczSrednia();
                film.OcenionyPrzez.Add(this);
            }
            catch(Exception e)
            {
                throw (e);
            }
            
        }
    }
}
