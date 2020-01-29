using Filmy.Movie;
using Filmy.Systems;
using Filmy.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmy.GUI
{
    public partial class AdminConsole : Form
    {
        Biblioteka bibliotekaFilmow = Biblioteka.Instance;
        BazaUzytkownikow bazaUzytkownikow = BazaUzytkownikow.Instance;
        Form prev;
        public AdminConsole(Form prev)
        {
            this.prev = prev;
            InitializeComponent();
            StringBuilder builder = new StringBuilder();
            bazaUzytkownikow.ListaUzytkownikow.ToList().ForEach(e => builder.AppendLine(e.UserName));
            tbUsers.Text = builder.ToString();
            StringBuilder builder2 = new StringBuilder();
            List<Film> lista = bibliotekaFilmow.Films.ToList();
            lista.Sort();
            lista.ForEach(f => builder2.AppendLine(f.Tytul));
            tbFilmy.Text = builder2.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbImie_Enter(object sender, EventArgs e)
        {
            if (tbImie.Text == "imie")
            {
                tbImie.Text = "";
                tbImie.ForeColor = Color.Black;
            }
        }

        private void tbNazwisko_Enter(object sender, EventArgs e)
        {
            if (tbNazwisko.Text == "nazwisko")
            {
                tbNazwisko.Text = "";
                tbNazwisko.ForeColor = Color.Black;
            }
        }

        private void tbWiek_Enter(object sender, EventArgs e)
        {
            if (tbWiek.Text == "wiek")
            {
                tbWiek.Text = "";
                tbWiek.ForeColor = Color.Black;
            }
        }

        private void tbUserName_Enter(object sender, EventArgs e)
        {
            if (tbUserName.Text == "username")
            {
                tbUserName.Text = "";
                tbUserName.ForeColor = Color.Black;
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "password")
            {
                tbPassword.Text = "";
                tbPassword.ForeColor = Color.Black;
            }
        }

        private void tbUserName2_Enter(object sender, EventArgs e)
        {
            if (tbUserName2.Text == "username")
            {
                tbUserName2.Text = "";
                tbUserName2.ForeColor = Color.Black;
            }
        }

        private void tbNazwa_Enter(object sender, EventArgs e)
        {
            if (tbNazwa.Text == "Nazwa")
            {
                tbNazwa.Text = "";
                tbNazwa.ForeColor = Color.Black;
            }
        }

        private void tbDataWydania_Enter(object sender, EventArgs e)
        {
            if (tbDataWydania.Text == "Data Wydania")
            {
                tbDataWydania.Text = "";
                tbDataWydania.ForeColor = Color.Black;
            }
        }

        private void tbNazwa2_Enter(object sender, EventArgs e)
        {
            if (tbNazwa2.Text == "Nazwa")
            {
                tbNazwa2.Text = "";
                tbNazwa2.ForeColor = Color.Black;
            }
        }

        private void btDodajUser_Click(object sender, EventArgs e)
        {
            try
            {
                string imie = tbImie.Text;
                string nazwisko = tbNazwisko.Text;
                int wiek = -1;
                Int32.TryParse(tbWiek.Text, out wiek);
                string username = tbUserName.Text;
                string password = tbPassword.Text;
                if (imie != "" && imie != "imie" && username != "" && username != "username" && password != "" && password != "password")
                {
                    if (wiek != -1 && nazwisko != "" && nazwisko != "nazwisko")
                    {
                        bazaUzytkownikow.DodajUzytkownika(new NormalnyUzywtkownik(imie, nazwisko, wiek, username, password));
                    }
                    else
                    {
                        bazaUzytkownikow.DodajUzytkownika(new NormalnyUzywtkownik(imie, username, password));
                    }
                    StringBuilder builder = new StringBuilder();
                    bazaUzytkownikow.ListaUzytkownikow.ToList().ForEach(u=>builder.AppendLine(u.UserName));
                    tbUsers.Text = builder.ToString();



                }
                else
                {
                    Form exWindow = new ExceptionWindow("Zle dane");
                    exWindow.ShowDialog();

                }
            }
            catch(Exception ex)
            {
                Form exWindow = new ExceptionWindow(ex.Message);
                exWindow.ShowDialog();
            }
        }

        private void btUsunUser_Click(object sender, EventArgs e)
        {
            string username = tbUserName2.Text;
            try
            {
                if (username != "" && username != "username")
                {
                    bazaUzytkownikow.UsunUzytkownika(username);
                    StringBuilder builder = new StringBuilder();
                    bazaUzytkownikow.ListaUzytkownikow.ToList().ForEach(u => builder.AppendLine(u.UserName));
                    tbUsers.Text = builder.ToString();
                }
            }
            catch(Exception ex)
            {
                Form exWindow = new ExceptionWindow(ex.Message);
                exWindow.ShowDialog();
            }
        }

        private void btDodajFilm_Click(object sender, EventArgs e)
        {
            string nazwa = tbNazwa.Text;
            try
            {
                DateTime data = new DateTime(2050, 1, 1);
                DateTime.TryParse(tbDataWydania.Text, out data);
                if (nazwa != "" && nazwa != "Nazwa" && data != new DateTime(2050, 1, 1))
                {

                    bibliotekaFilmow.DodajFilm(new Movie.Film(nazwa, data));
                    StringBuilder builder = new StringBuilder();
                    List<Film> lista = bibliotekaFilmow.Films.ToList();
                    lista.Sort();
                    lista.ForEach(f => builder.AppendLine(f.Tytul));
                    tbFilmy.Text = builder.ToString();

                }
                else
                {
                    Form exWindow = new ExceptionWindow("Zle dane!");
                    exWindow.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                Form exWindow = new ExceptionWindow(ex.Message);
                exWindow.ShowDialog();
            }
        }

        private void btUsunFilm_Click(object sender, EventArgs e)
        {
            string nazwa = tbNazwa2.Text;
            try
            {
                if (nazwa != "" && nazwa != "Nazwa")
                {
                    bibliotekaFilmow.UsunFilm(nazwa);
                    StringBuilder builder = new StringBuilder();
                    List<Film> lista = bibliotekaFilmow.Films.ToList();
                    lista.Sort();
                    lista.ForEach(f => builder.AppendLine(f.Tytul));
                    tbFilmy.Text = builder.ToString();
                }
                else
                {
                    Form exWindow = new ExceptionWindow("Zle dane!");
                    exWindow.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                Form exWindow = new ExceptionWindow(ex.Message);
                exWindow.ShowDialog();
            }
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            prev.Show();
            this.Close();
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbUsers_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
