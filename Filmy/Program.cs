using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filmy.Movie;
using Filmy.User;

namespace Filmy
{
    class Program
    {
        static void Main(string[] args)
        {
            Uzytkownik user = new NormalnyUzywtkownik("Fifi", "Witko", "admin123");
            Film film = new Film("SkazaniNaSukces",new DateTime(2019,10,01));
            NormalnyUzywtkownik user2 = new NormalnyUzywtkownik("fifi", "witko", "admin123");
            NormalnyUzywtkownik user3 = new NormalnyUzywtkownik("fifi", "witko", "admin123");
            user2.OcenFilm(film,3);
            user3.OcenFilm(film, 4);
            Console.WriteLine(film.SredniaOcen);
            Console.ReadKey();
        }
    }
}
