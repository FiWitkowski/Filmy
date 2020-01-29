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
    public partial class UserConsole : Form
    {
        Form prev;
        Biblioteka biblioteka = Biblioteka.Instance;
        NormalnyUzywtkownik currentUser;

        public UserConsole(Form prev, NormalnyUzywtkownik user)
        {
            this.prev = prev;
            InitializeComponent();
            StringBuilder builder = new StringBuilder();
            List<Film> lista = biblioteka.Films.ToList();
            lista.Sort();
            lista.ForEach(f => builder.AppendLine(f.ToString()));
            tbLista.Text = builder.ToString();
            currentUser = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btOcen_Click(object sender, EventArgs e)
        {
            try
            {
                string tytul = tbTytulOcen.Text;
                int ocena = Int32.Parse(tbOcena.Text);
                if (ocena == 1 || ocena == 2 || ocena == 3 || ocena == 4 || ocena == 5)
                {
                    currentUser.OcenFilm(tytul, ocena);
                }
                else
                {
                    Form exWindow = new ExceptionWindow("Wystaw ocene z zakresu 1 do 5");
                    exWindow.ShowDialog();
                }
                StringBuilder builder = new StringBuilder();
                List<Film> lista = biblioteka.Films.ToList();
                lista.Sort();
                lista.ForEach(f => builder.AppendLine(f.ToString()));
                tbLista.Text = builder.ToString();
            }
            catch(Exception ex){
                Form exWindow = new ExceptionWindow(ex.Message);
                exWindow.ShowDialog();
            }
        }

        private void btUsunOcene_Click(object sender, EventArgs e)
        {
            try
            {
                string tytul = tbTytulUsun.Text;
                currentUser.UsunOcene(biblioteka.Films.First(f => f.Tytul == tytul));
                StringBuilder builder = new StringBuilder();
                List<Film> lista = biblioteka.Films.ToList();
                lista.Sort();
                lista.ForEach(f => builder.AppendLine(f.ToString()));
                tbLista.Text = builder.ToString();
            }
            catch(Exception ex)
            {
                Form exWindow = new ExceptionWindow(ex.Message);
                exWindow.ShowDialog();
            }
        }

        private void btWyloguj_Click(object sender, EventArgs e)
        {
            prev.Show();
            this.Close();
        }
    }
}
