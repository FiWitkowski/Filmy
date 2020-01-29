using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filmy.Movie;
using Filmy.Systems;
using Filmy.User;
using System.Windows.Forms;
using Filmy.GUI;
namespace Filmy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Parse("01/01/2011").ToShortDateString());
            
            BazaUzytkownikow baza = BazaUzytkownikow.Instance;
            baza.DodajUzytkownika(new NormalnyUzywtkownik("Jan", "Kowalski", 20, "a", "a"));
            baza.DodajUzytkownika(new NormalnyUzywtkownik("Adam", "Nowak", 23, "b", "b"));
            baza.DodajUzytkownika(new NormalnyUzywtkownik("Antoni", "Macierewicz", 20, "c", "c"));
            baza.Serialize("test.bin");
            Application.Run(new MainWindow());


            Console.ReadKey();
        }
    }
}
